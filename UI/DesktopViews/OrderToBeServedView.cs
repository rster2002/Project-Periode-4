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
    public partial class OrderToBeServedView: UserControl {
        private ReservationService reservationSerivce = new ReservationService();
        private List<Reservation> reservations;
        private string foodType;
        public OrderToBeServedView(string foodType) {
            this.foodType = foodType;
            InitializeComponent();

            PopulateOrderLayout();
            //set interval for timer and enable timer.
            refreshTimer.Interval = 5000;
            refreshTimer.Enabled = true;
            //start the timer
            refreshTimer.Start();
        }
        private void PopulateOrderLayout() {
            reservations = reservationSerivce.GetAllReservations();

            orderReadyOverviewLayout.Controls.Clear();
            orderReadyOverviewLayout.RowCount = 0;
            orderReadyOverviewLayout.RowStyles.Clear();

            reservations = reservations
                .Select(reservation => {
                    reservation.Orders = reservation.Orders
                        .Select(order => {
                            order.MenuItems = GetAmount(order.MenuItems
                                .Where(menuItem => menuItem.Type == foodType)
                                .ToList());

                            return order;
                        })
                        .Where(order => order.MenuItems.Count > 0 && order.Status == "closed")
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
                orderReadyOverviewLayout.RowCount++;

                orderReadyOverviewLayout.RowStyles.Add(new RowStyle(SizeType.Percent, (float) rowHeight));
            }
            foreach (Reservation reservation in reservations) {
                orderReadyOverviewLayout.Controls.AddRange(GenerateOrderPanel(reservation).ToArray());
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
                    Text = $"Tafel {reservation.Table.Number}, {order.Tag}",
                    BackColor = Color.White,
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

                groupBox.Controls.Add(listView);
                groupBox.Controls.Add(panel);

                boxes.Add(groupBox);
            }
            return boxes;
        }

        private void RefreshTimer_Tick(object sender, EventArgs e) {
            PopulateOrderLayout();
        }
    }
}
