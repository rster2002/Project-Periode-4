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
    public partial class CancelOrderForm: Form {

        private Order order;
        private OrderService orderService;

        public CancelOrderForm(Order order) {
            InitializeComponent();
            //center the pop up
            CenterToScreen();

            this.order = order;
            orderService = new OrderService();
            //make clickevent
            btnYes.Click += new EventHandler(DeleteOrder);
        }

        protected void DeleteOrder(object sender, EventArgs e) {
           //orderService.DeleteById(order.Id);
        }
    }
}
