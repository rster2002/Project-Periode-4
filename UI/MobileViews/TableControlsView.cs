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
        private OrderService orderService = new OrderService();
        private List<Model.Menu> menus;
        private Table table;

        public TableControlsView(Table table) {
            InitializeComponent();

            this.table = table;
            menus = menuService.GetMenus();

            reservationPopupPanel.Visible = false;
            reservationPopupPanel.Dock = DockStyle.Fill;

            Size = new Size(398, 649);
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

            float percentPerButton = 100 / (menus.Count + 1);

            foreach (Model.Menu menu in menusAvailableNow) {
                buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, percentPerButton));
                buttonLayout.RowCount++;

                buttonLayout.Controls.Add(GenerateMenuButton(menu));
            }


            //Generate order served button
            Button servedButton = new Button();
            servedButton.Dock = DockStyle.Fill;
            servedButton.Text = "Bestelling geserveerd!";
            servedButton.BackColor = Color.White;
            servedButton.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            servedButton.Click += ServedButtonOnClick;

            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, percentPerButton));
            buttonLayout.RowCount++;
            buttonLayout.Controls.Add(servedButton);

            if (table.Status == "Available") {
                Button reserveButton = new Button();
                reserveButton.Dock = DockStyle.Fill;
                reserveButton.Text = "Reserveer tafel";
                reserveButton.BackColor = Color.FromArgb(221, 243, 17);
                reserveButton.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
                reserveButton.Click += ReserveButtonOnClick;

                buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, percentPerButton));
                buttonLayout.RowCount++;
                buttonLayout.Controls.Add(reserveButton);
            } else {
                // Generate checkout button
                Button checkoutButton = new Button();
                checkoutButton.Dock = DockStyle.Fill;
                checkoutButton.Text = "Afrekenen";
                checkoutButton.BackColor = Color.FromArgb(39, 194, 65);
                checkoutButton.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
                checkoutButton.Click += CheckoutButtonOnClick;

                buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, percentPerButton));
                buttonLayout.RowCount++;

                buttonLayout.Controls.Add(checkoutButton);
            }
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

            mobileView.LoadView(new TakeOrderView(menu, table));
        }

        private void CheckoutButtonOnClick(object sender, EventArgs args) {
            mobileView.LoadView(new CheckoutView(table));
        }

        private void ServedButtonOnClick(object sender, EventArgs args) {
            List<Order> orders = orderService.GetListPreparedOrdersByTableId(table.Number);
            foreach (Order order in orders) {
                orderService.CloseOrder(order.Id);
            }
            mobileView.ResetTo(new TableView(), "Tafels");
        }

        private void ShowReservationPopup() {
            reservationPopupPanel.Visible = true;
        }

        private void HideReservationPopup() {
            txtBoxReservationName.Text = "";
            reservationPopupPanel.Visible = false;
        }

        private void ReserveButtonOnClick(object sender, EventArgs args) {
            ShowReservationPopup();
        }

        private void CancelReservationButtonOnClick(object sender, EventArgs e) {
            HideReservationPopup();
        }

        private void CloseReservationPopupLabelOnClick(object sender, EventArgs e) {
            HideReservationPopup();
        }

        private void ConfirmReservationButtonOnClick(object sender, EventArgs e) {
            ReservationService reservationService = new ReservationService();
            CustomerService customerService = new CustomerService();
            Random rnd = new Random();
            Customer customer = new Customer() {
                Id = rnd.Next(1, 999999),
                Name = txtBoxReservationName.Text
            };

            customerService.AddCustomer(customer.Id, customer.Name);
            reservationService.AddReservation(rnd.Next(1, 9999999), table.Number, customer.Id);

            mobileView.ResetTo(new TableView(), "Tafels");
        }
    }
}
