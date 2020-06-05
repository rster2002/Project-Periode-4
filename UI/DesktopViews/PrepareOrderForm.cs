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
    public partial class PrepareOrderForm: Form {

        private Order order;
        private OrderService orderService;
        public PrepareOrderForm(Order order) {
            InitializeComponent();

            //center the pop up
            CenterToScreen();

            this.order = order;
            orderService = new OrderService();
            //make clickevent
            btnGereed.Click += new EventHandler(PrepareOrder);
        }
        protected void PrepareOrder(object sender, EventArgs e) {
            //prepare the order by setting reservation id on null 
            orderService.UpdateReservationId(order.Id, null);
        }
    }
}
