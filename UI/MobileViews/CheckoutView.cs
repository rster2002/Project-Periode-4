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
using System.Reflection;
using System.Data.SqlTypes;
using System.Drawing.Drawing2D;

namespace UI.MobileViews {
    public partial class CheckoutView: UserControl {
        private ReservationService reservationService = new ReservationService();
        private OrderService orderService = new OrderService();
        private ReceiptService receiptService = new ReceiptService();
        private MobileView mobileView = MobileView.GetInstance();

        private Table table;
        private List<Order> orders;
        private string selectedPaymentMethod;

        private Color optionSelectedColor = Color.FromArgb(9, 111, 189);
        private Color optionDefaultColor = Color.White;

        public CheckoutView(Table table) {
            InitializeComponent();
            Size = new Size(398, 649);
            paymentMethodDialog.Dock = DockStyle.Fill;

            this.table = table;
            GetOrder();

            List<Model.MenuItem> menuItems = CollapseMenuItems(
                CompileTotalMenuItemsList(orders)
            );
            PopulateMenuItemsList(menuItems);
            PopulateVATList(menuItems);
        }

        private void GetOrder() {
            orders = orderService.GetOrderByTableId(table.Number);
            startPaymentButton.Enabled = orders.Count > 0;
        }

        private List<Model.MenuItem> CompileTotalMenuItemsList(List<Order> orders) {
            List<Model.MenuItem> menuItems = new List<Model.MenuItem>();

            foreach (Order order in orders) {
                menuItems.AddRange(order.MenuItems);
            }

            return menuItems;
        }

        private List<Model.MenuItem> CollapseMenuItems(List<Model.MenuItem> menuItems) {
            Dictionary<int, Model.MenuItem> menuItemsMap = new Dictionary<int, Model.MenuItem>();

            foreach (Model.MenuItem menuItem in menuItems) {
                if (!menuItemsMap.ContainsKey(menuItem.Id)) {
                    menuItem.Amount = 1;
                    menuItemsMap[menuItem.Id] = menuItem;
                } else {
                    menuItemsMap[menuItem.Id].Amount += 1;
                }
            }

            return menuItemsMap.Values.ToList();
        }

        private void PopulateMenuItemsList(List<Model.MenuItem> menuItems) {
            menuItemsList.Items.Clear();

            foreach (Model.MenuItem menuItem in menuItems) {
                ListViewItem listViewItem = new ListViewItem(menuItem.Name);
                listViewItem.SubItems.Add(menuItem.Amount + "x");
                listViewItem.SubItems.Add(string.Format("€ {0}", (menuItem.Amount * menuItem.Price).ToString("0.00")));

                menuItemsList.Items.Add(listViewItem);
            }
        }

        private void PopulateVATList(List<Model.MenuItem> menuItems) {
            VATListView.Items.Clear();

            decimal totalPrice = GetTotalPrice(menuItems);

            decimal nonalchoholVAT = GetVAT(menuItems, 6);
            decimal alchoholVAT = GetVAT(menuItems, 21);

            decimal totalPriceWithoutVAt = totalPrice - nonalchoholVAT - alchoholVAT;

            VATListView.Items.Add(CreateVATRow("Totaal (Excl. BTW)", "€ " + totalPriceWithoutVAt.ToString("0.00")));
            VATListView.Items.Add(CreateVATRow("6% BTW", "€ " + nonalchoholVAT.ToString("0.00")));
            VATListView.Items.Add(CreateVATRow("21% BTW", "€ " + alchoholVAT.ToString("0.00")));
            VATListView.Items.Add(CreateVATRow("Totaal (Incl. BTW)", "€ " + totalPrice.ToString("0.00")));
        }

        private ListViewItem CreateVATRow(string key, string value) {
            ListViewItem listViewItem = new ListViewItem(key);
            listViewItem.SubItems.Add(value);

            return listViewItem;
        }

        private decimal GetVAT(List<Model.MenuItem> menuItems, int VATPercentage) {
            return menuItems
                .Where(menuItem => menuItem.VAT == VATPercentage)
                .Select(menuItem => menuItem.Price / 100 * menuItem.VAT)
                .Sum();
        }

        private decimal GetTotalPrice(List<Model.MenuItem> menuItems) {
            return menuItems
                .Sum(menuItem => menuItem.Price * menuItem.Amount);
        }

        private void StartPaymentButtonOnClick(object sender, EventArgs e) {
            ShowPaymentMethodDialog();
        }

        private void ShowPaymentMethodDialog() {
            paymentMethodDialog.Visible = true;
        }

        private void HidePaymentMethodDialog() {
            paymentMethodDialog.Visible = false;
        }

        private void SelectPaymentMethod(object sender, string paymentMethod) {
            Button button = (Button) sender;

            cashPaymentMethodButton.BackColor = optionDefaultColor;
            debitCardPaymentMethodButton.BackColor = optionDefaultColor;
            creditCardPaymentMethodButton.BackColor = optionDefaultColor;

            confirmPaymentButton.Enabled = true;
            button.BackColor = optionSelectedColor;

            selectedPaymentMethod = paymentMethod;
        }

        private void CashPaymentMethodButtonOnClick(object sender, EventArgs e) => SelectPaymentMethod(sender, "cash");
        private void DebitCardPaymentMethodButtonOnClick(object sender, EventArgs e) => SelectPaymentMethod(sender, "pin");
        private void CreditCardPaymentMethodButtonOnClick(object sender, EventArgs e) => SelectPaymentMethod(sender, "visa");

        private void ConfirmPaymentButtonOnClick(object sender, EventArgs e) {
            Reservation reservation = reservationService.GetReservationByTableNumber(table.Number);
            if (reservation == null) throw new Exception("Cannot find a reservation assosiated with this table");

            Random random = new Random();
            int receiptId = random.Next();

            receiptService.AddReceipt(receiptId, selectedPaymentMethod);
            orderService.UpdateReceiptIdByReservationId(reservation.Id, receiptId);
            reservationService.DeleteById(reservation.Id);

            mobileView.ResetTo(new TableView(), "Tafels");
        }
    }
}
