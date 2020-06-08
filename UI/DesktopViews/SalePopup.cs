using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.DesktopViews {
    public partial class SalePopup: Form {
        private Receipt receipt;

        public SalePopup(Receipt receipt) {
            this.receipt = receipt;

            InitializeComponent();
            PopulateOrderList();
        }

        private void PopulateOrderList() {
            ordersListView.Groups.Clear();
            ordersListView.Items.Clear();

            foreach (Order order in receipt.Orders) {
                Staff placedBy = order.PlacedBy;
                ListViewGroup group = new ListViewGroup($"Opgenomen door: {placedBy.Name} (nr {placedBy.Id})");

                foreach (Model.MenuItem menuItem in order.MenuItems) {
                    ListViewItem item = new ListViewItem(menuItem.Name);
                    item.SubItems.Add("€ " + menuItem.Price.ToString("0.00"));

                    item.Group = group;

                    ordersListView.Items.Add(item);
                }

                ordersListView.Groups.Add(group);
            }
        }
    }
}
