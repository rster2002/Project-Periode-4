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

namespace UI.DesktopViews {
    public partial class OrderBarView: UserControl {
        private ReservationService reservationSerivce = new ReservationService();
        private List<Reservation> reservations;
        private string drinkType;
        public OrderBarView(string drinkType) {
            this.drinkType = drinkType;
            InitializeComponent();

            reservations = reservationSerivce.GetAllReservations();
            PopulateOrderLayout();
        }
        private void PopulateOrderLayout() {
            orderBarOverviewLayout.Controls.Clear();
            orderBarOverviewLayout.RowCount = 0;
            orderBarOverviewLayout.RowStyles.Clear();

            reservations = reservations
                .Select(reservation => {
                    reservation.Orders = reservation.Orders
                        .Select(order => {
                            order.MenuItems = GetAmount(order.MenuItems
                                .Where(menuItem => menuItem.Type == drinkType)
                                .ToList());

                            return order;
                        })
                        .Where(order => order.MenuItems.Count > 0)
                        .ToList();

                    return reservation;
                })
                .Where(reservation => reservation.Orders.Count > 0)
                .ToList();

            List<Order> orders = reservations
                .SelectMany(reservation => reservation.Orders)
                .ToList();

            int requiredNumberOfRows = (int) Math.Ceiling((decimal) orders.Count / 2);

            // Minimal one row
            requiredNumberOfRows = requiredNumberOfRows > 0 ? requiredNumberOfRows : 1;
            decimal rowHeight = 100 / requiredNumberOfRows;

            for (int i = 0; i < requiredNumberOfRows; i++) {
                orderBarOverviewLayout.RowCount++;

                orderBarOverviewLayout.RowStyles.Add(new RowStyle(SizeType.Percent, (float) rowHeight));
            }

            foreach (Reservation reservation in reservations) {
                orderBarOverviewLayout.Controls.AddRange(GenerateOrderPanel(reservation).ToArray());
            }
        }

        private List<Model.MenuItem> GetAmount(List<Model.MenuItem> menuItems) {
            Dictionary<int, Model.MenuItem> menuItemMap = new Dictionary<int, Model.MenuItem>();

            foreach (Model.MenuItem item in menuItems) {

                int menuItemId = item.Id;

                if (!menuItemMap.ContainsKey(menuItemId)) {
                    item.Amount = 1;
                    menuItemMap[menuItemId] = item;
                } else {
                    menuItemMap[menuItemId].Amount++;
                }

            }

            return menuItemMap.Values.ToList();
        }
        private List<GroupBox> GenerateOrderPanel(Reservation reservation) {
            List<GroupBox> boxes = new List<GroupBox>();

            foreach (Order order in reservation.Orders) {
                GroupBox groupBox = new GroupBox() {
                    Text = $"Tafel {reservation.Table.Number}, {order.Tag}"
                };

                groupBox.Dock = DockStyle.Fill;
                groupBox.Font = new Font(groupBox.Font, FontStyle.Bold);

                ListView listView = new ListView() {
                    View = View.Details,
                    BorderStyle = BorderStyle.None,
                    Height = groupBox.Height * 2
                };

                Panel panel = new Panel() {
                    Dock = DockStyle.Bottom
                };

                Button buttonCancel = new Button() {
                    Text = "Annuleer",
                    BackColor = Color.Red,
                    Dock = DockStyle.Left,
                    Width = groupBox.Width
                };
                //make the click event with an extra parameter of order so our form has it too
                //buttonCancel.Click += delegate (object sender, EventArgs e) { CancelOrder(sender, e, order); };
                buttonCancel.Click += (sender, e) => CancelOrder(sender, e, order);

                Button buttonOrderReady = new Button() {
                    Text = "Bestelling klaarzetten",
                    BackColor = Color.Green,
                    Dock = DockStyle.Right,
                    Width = groupBox.Width
                };

                buttonOrderReady.Click += (sender, e) => PrepareOrder(sender, e, order);

                listView.Font = new Font(listView.Font, FontStyle.Regular);
                listView.Columns.Add("Aantal");
                listView.Columns.Add("Gerechten", 300);
                listView.Columns.Add("Opmerking", 300);
                listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
                listView.Dock = DockStyle.Top;

                foreach (Model.MenuItem menuItem in order.MenuItems) {
                    ListViewItem item = new ListViewItem(menuItem.Amount.ToString());
                    item.SubItems.Add(menuItem.Name);
                    item.SubItems.Add(menuItem.Comment);
                    listView.Items.Add(item);
                }

                panel.Controls.Add(buttonCancel);
                panel.Controls.Add(buttonOrderReady);

                groupBox.Controls.Add(listView);
                groupBox.Controls.Add(panel);

                boxes.Add(groupBox);
            }
            return boxes;
        }
        protected void CancelOrder(object sender, EventArgs e, Order order) {
            //make the pop up and give the order with it
            CancelOrderForm cancel = new CancelOrderForm(order);
            cancel.ShowDialog();
        }

        protected void PrepareOrder(object sender, EventArgs e, Order order) {
            //make the up up and give the order with it
            PrepareOrderForm prepare = new PrepareOrderForm(order);
            prepare.ShowDialog();
        }
    }
}
