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
    public partial class StockPickerView: UserControl {
        DesktopView parent;
        public StockPickerView(DesktopView sender) {
            parent = sender;
            InitializeComponent();
        }

        private void LblKitchen_Click(object sender, EventArgs e) {
            parent.LoadView(new StockView("food"));
        }

        private void LblBar_Click(object sender, EventArgs e) {
            parent.LoadView(new StockView("drink"));
        }
    }
}
