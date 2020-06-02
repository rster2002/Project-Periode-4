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
    public partial class OrderView: UserControl {
        private ReservationService reservationSerivce = new ReservationService();
        private List<Reservation> reservations;
        private string foodType;

        public OrderView(string foodType) {
            this.foodType = foodType;
            InitializeComponent();

            reservations = reservationSerivce.GetAllReservations();
            PopulateOrderLayout();
        }

        private void PopulateOrderLayout() {
            orderOverviewLayout.Controls.Clear();
            orderOverviewLayout.RowCount = 0;
            orderOverviewLayout.RowStyles.Clear();

            List<Order> orders = new List<Order>();

            foreach (Reservation reservation in reservations) {
                orders.AddRange(
                    reservation
                        .Orders
                        // Filter out any non-food menu items from all orders
                        .Select(order => {
                            order.MenuItems = order.MenuItems
                                .Where(item => item.Type == foodType)
                                .ToList();

                            return order;
                        })
                        // Filter out any orders that do not contain food items
                        .Where(order => order.MenuItems.Count > 0)

                        
                        .ToList()
                );
            }

            int requiredNumberOfRows = (int) Math.Ceiling((decimal) orders.Count / 2);

            // Minimal one row
            requiredNumberOfRows = requiredNumberOfRows > 0 ? requiredNumberOfRows : 1;
            decimal rowHeight = 100 / requiredNumberOfRows;

            for(int i = 0; i < requiredNumberOfRows; i++) {
                orderOverviewLayout.RowCount++;

                orderOverviewLayout.RowStyles.Add(new RowStyle(SizeType.Percent, (float) rowHeight));
            }

            foreach(Reservation reservation in reservations) {
                orderOverviewLayout.Controls.AddRange(GenerateOrderPanel(reservation).ToArray());
            }
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
                buttonCancel.Click += delegate (object sender, EventArgs e) { CancelOrder(sender, e, order); };
                Button buttonOrderReady = new Button() {
                    Text = "Bestelling klaarzetten",
                    BackColor = Color.Green,
                    Dock = DockStyle.Right,
                    Width = groupBox.Width
                };

                listView.Font = new Font(listView.Font, FontStyle.Regular);
                listView.Columns.Add("Aantal");
                listView.Columns.Add("Gerechten",300);
                listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
                listView.Dock = DockStyle.Top;

                foreach(Model.MenuItem menuItem in order.MenuItems) {
                    ListViewItem item = new ListViewItem(menuItem.Amount.ToString());
                    item.SubItems.Add(menuItem.Name);
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
            CancelOrderForm cancel = new CancelOrderForm(order);
            cancel.ShowDialog();
        }
    }
}
