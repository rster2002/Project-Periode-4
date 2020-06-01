using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI {
    public partial class ViewPicker: Form {
        public ViewPicker() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MobileView mobileView = MobileView.GetInstance();
            mobileView.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) {
            DesktopView desktopView = DesktopView.GetInstance();
            desktopView.LoadView(new LoginView());

            desktopView.ShowDialog();
        }
    }
}
