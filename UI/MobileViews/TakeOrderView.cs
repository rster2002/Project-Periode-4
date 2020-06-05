using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI.MobileViews {
    public partial class TakeOrderView: UserControl {
        private UserSession userSession = UserSession.GetInstance();
        private MobileView mobileView = MobileView.GetInstance();
        private MenuItemService menuItemService = new MenuItemService();

        private Model.Menu menu;
        private Order order;
        private Table table;

        private List<Model.MenuItem> loadedMenuItems;
        private Model.MenuItem loadedMenuItem;

        public TakeOrderView(Model.Menu menu, Table table) {
            this.menu = menu;
            this.table = table;
            order = new Order();

            InitializeComponent();
            PopulateMenuItemTypes();

            Size = new Size(398, 649);
            popupDialog.Dock = DockStyle.Fill;
            confirmationDialog.Dock = DockStyle.Fill;
        }

        // Generates the buttons for the different types of MenuItems
        private void PopulateMenuItemTypes() {
            menuItemTypeButtons.Controls.Clear();
            menuItemTypeButtons.RowStyles.Clear();

            List<Model.MenuItem> menuItems = menu.Items;
            List<Model.MenuItem> drinks = menuItemService.GetDrinks();

            menuItems.AddRange(drinks);

            Dictionary<string, List<Model.MenuItem>> categories = new Dictionary<string, List<Model.MenuItem>>();

            foreach (Model.MenuItem menuItem in menu.Items) {
                if (!categories.ContainsKey(menuItem.Subtype)) categories.Add(menuItem.Subtype, new List<Model.MenuItem>());

                categories[menuItem.Subtype].Add(menuItem);
            }

            int numberOfRows = (int) Math.Ceiling((decimal) categories.Count / 3);
            float percentagePerRow = 100 / numberOfRows;

            menuItemTypeButtons.RowCount = numberOfRows;

            foreach (KeyValuePair<string, List<Model.MenuItem>> category in categories) {
                menuItemTypeButtons.RowStyles.Add(new RowStyle(SizeType.Percent, percentagePerRow));

                menuItemTypeButtons.Controls.Add(GenerateCategoryButton(category.Value));
            }
        }

        // Generates one category button
        private Button GenerateCategoryButton(List<Model.MenuItem> menuItems) {
            Button categoryButton = new Button();

            categoryButton.Text = menuItems[0].Subtype;
            categoryButton.BackColor = Color.White;
            categoryButton.Dock = DockStyle.Fill;
            categoryButton.Tag = menuItems;
            categoryButton.Click += CategoryButtonOnClick;

            return categoryButton;
        }

        // Handler for when a category button is clicked
        private void CategoryButtonOnClick(object sender, EventArgs args) {
            Button button = (Button) sender;
            List<Model.MenuItem> menuItems = (List<Model.MenuItem>) button.Tag;

            categoryLabel.Text = menuItems[0].Subtype;
            categoryLabel.Visible = true;

            loadedMenuItems = menuItems;
            PopulateMenuItemList();
        }

        // Generates the buttons for the menu items with that subtype
        private void PopulateMenuItemList() {
            foreach (Button button in menuItemTypeButtons.Controls) {
                button.BackColor = button.Tag == loadedMenuItems ? Color.FromArgb(152, 0, 0) : Color.White;
            }

            int numberOfRows = (int) Math.Ceiling((decimal) loadedMenuItems.Count / 4);
            float percentagePerRow = 100 / numberOfRows;

            menuItemList.Controls.Clear();
            menuItemList.RowStyles.Clear();
            menuItemList.RowCount = numberOfRows;

            foreach (Model.MenuItem menuItem in loadedMenuItems) {
                menuItemList.RowStyles.Add(new RowStyle(SizeType.Percent, percentagePerRow));
                menuItemList.Controls.Add(GenerateMenuItemButton(menuItem));
            }
        }

        // Generates one button for the menu item
        private Button GenerateMenuItemButton(Model.MenuItem menuItem) {
            Button menuItemButton = new Button();

            menuItemButton.Text = $"{menuItem.Name} ({menuItem.AmountInStock}x)";
            menuItemButton.Dock = DockStyle.Fill;
            menuItemButton.Tag = menuItem;
            menuItemButton.Click += MenuItemButtonOnClick;

            if (menuItem.AmountInStock <= 3) {
                menuItemButton.Enabled = false;
                menuItemButton.Text = "(Niet op voorraad) " + menuItemButton.Text;
            }

            return menuItemButton;
        }

        // Handler for when a menu item button is clicked
        private void MenuItemButtonOnClick(object sender, EventArgs args) {
            Button button = (Button) sender;
            Model.MenuItem menuItem = (Model.MenuItem) button.Tag;
            menuItem.AmountInStock -= 1;

            bool isInList = order.MenuItems.Any(item => item.Id == menuItem.Id);

            if (isInList) {
                order.MenuItems = order.MenuItems
                    .Select(item => {
                        if (item.Id == menuItem.Id) {
                            item.Amount += 1;
                        }

                        return item;
                    })
                    .ToList();
            } else {
                menuItem.Amount = 1;
                order.MenuItems.Add(menuItem);
            }

            PopulateMenuItemList();
            RefreshOrderList();
        }

        // Refreshes the order list
        private void RefreshOrderList() {
            orderList.Items.Clear();

            foreach (Model.MenuItem menuItem in order.MenuItems) {
                ListViewItem item = new ListViewItem(menuItem.Name);
                item.SubItems.Add(menuItem.Comment != null ? menuItem.Comment : "");
                item.SubItems.Add(menuItem.Amount + "x");
                item.Tag = menuItem;

                orderList.Items.Add(item);
            }
        }

        private void OrderListOnEntrySelect(object sender, EventArgs e) {
            if (orderList.SelectedItems.Count == 0) return;

            Model.MenuItem menuItem = (Model.MenuItem) orderList.SelectedItems[0].Tag;

            ShowPopupDialog(menuItem);
        }

        private void ShowPopupDialog(Model.MenuItem menuItem) {
            loadedMenuItem = menuItem;

            dialogTitleLbl.Text = menuItem.Name;
            menuItemAmountNumberBox.Value = menuItem.Amount;

            popupDialog.Visible = true;
        }

        private void HidePopupDialog() {
            popupDialog.Visible = false;
        }

        private void PopupDialogOnClick(object sender, EventArgs e) {
            HidePopupDialog();
        }

        private void DialogConfirmButtonOnClick(object sender, EventArgs e) {
            loadedMenuItem.Comment = commentTextbox.Text;
            loadedMenuItem.Amount = (int) menuItemAmountNumberBox.Value;

            RefreshOrderList();
            HidePopupDialog();
        }

        private void DialogRemoveButtonOnClick(object sender, EventArgs e) {
            order.MenuItems.Remove(loadedMenuItem);

            HidePopupDialog();
        }

        private void PlaceOrderButtonOnClick(object sender, EventArgs e) {
            ShowConfirmationDialog();
        }

        private void BackToTablesViewButton(object sender, EventArgs e) {
            OrderService orderService = new OrderService();
            orderService.PlaceOrder(table, order, splitOrderCheckbox.Checked);

            mobileView.LoadView(new TableView());
        }

        private void CancelOrderButtonOnClick(object sender, EventArgs e) {
            HideConfirmationDialog();
        }

        private void ShowConfirmationDialog() {
            confirmationDialog.Visible = true;
        }

        private void HideConfirmationDialog() {
            confirmationDialog.Visible = false;
        }
    }
}
