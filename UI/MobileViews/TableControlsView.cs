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
    public partial class TableControlsView: UserControl {
        private MobileView mobileView = MobileView.GetInstance();
        private MenuService menuService = new MenuService();
        private List<Model.Menu> menus;
        private Table table;

        public TableControlsView(Table table) {
            InitializeComponent();

            this.table = table;
            menus = menuService.GetMenus();
            PopulateTableContols();
        }

        private void PopulateTableContols() {
            TimeSpan timeNow = DateTime.Now.TimeOfDay;
            buttonLayout.Controls.Clear();
            buttonLayout.RowStyles.Clear();
            buttonLayout.RowCount = 0;

            List<Model.Menu> menusAvailableNow = menus
                .Where(menu => timeNow > menu.StartTime && timeNow < menu.EndTime)
                .ToList();

            float percentPerButton = 100 / menus.Count + 1;

            foreach (Model.Menu menu in menusAvailableNow) {
                buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, percentPerButton));
                buttonLayout.RowCount++;

                buttonLayout.Controls.Add(GenerateMenuButton(menu));
            }

            // Generate checkout button
            Button checkoutButton = new Button();
            checkoutButton.Dock = DockStyle.Fill;
            checkoutButton.Text = "Afrekenen";
            checkoutButton.BackColor = Color.FromArgb(39, 194, 65);
            checkoutButton.Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            checkoutButton.Click += CheckoutButtonOnClick;

            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, percentPerButton));
            buttonLayout.RowCount++;

            buttonLayout.Controls.Add(checkoutButton);
        }

        private Button GenerateMenuButton(Model.Menu menu) {
            Button button = new Button();

            button.Dock = DockStyle.Fill;
            button.Text = menu.Name;
            button.BackColor = Color.White;
            button.Font = new Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button.Tag = menu;
            button.Click += MenuButtonOnClick;

            return button;
        }

        private void MenuButtonOnClick(object sender, EventArgs args) {
            Button button = (Button) sender;
            Model.Menu menu = (Model.Menu) button.Tag;

            mobileView.LoadView(new TakeOrderView(menu));
        }

        private void CheckoutButtonOnClick(object sender, EventArgs args) {
            mobileView.LoadView(new CheckoutView(table));
        }
    }
}
