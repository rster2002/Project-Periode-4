using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.DesktopViews {
    public partial class TestView: UserControl {
        public TestView() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DesktopView desktopView = DesktopView.GetInstance();
            

            button1.Text = desktopView.loggedIn.Name;
        }
    }
}
