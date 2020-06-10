using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.DesktopViews;
using UI.MobileViews;

namespace UI {
    public partial class ViewPicker: Form {
        public ViewPicker() {
            InitializeComponent();
        }

        private void MobileView_Click(object sender, EventArgs e) {
            MobileView mobileView = MobileView.GetInstance();
            mobileView.LoadView(new LoginViewMobile(), "Login");

            Hide();
            mobileView.ShowDialog();
            Show();
        }

        private void DesktopView_Click(object sender, EventArgs e) {
            DesktopView desktopView = DesktopView.GetInstance();
            desktopView.LoadView(new LoginView());
            
            Hide();
            desktopView.ShowDialog();
            Show();
        }
    }
}
