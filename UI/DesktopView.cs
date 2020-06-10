using Model;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.DesktopViews;

namespace UI {
    public partial class DesktopView: Form {
        public static DesktopView instance;
        public UserControl loadedView;
        private UserSession userSession = UserSession.GetInstance();

        public static DesktopView GetInstance() {
            if (instance == null) instance = new DesktopView();
            return instance;
        }

        private DesktopView() {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void ShowTabs() {
            for (int i = 0; i < menuStrip.Items.Count; i++) {
                ToolStripItem item = menuStrip.Items[i];

                item.Visible = ((string) item.Tag).Contains(userSession.LoggedInStaff.Role);

                // Checken op naam is een beetje, eh...
                if (loadedView != null && item.Name.ToLower().Contains(loadedView.Name.ToLower())) {
                    item.BackColor = Color.FromArgb(255, 10, 10);
                } else {
                    item.BackColor = Color.FromArgb(33, 33, 33);
                }
            }
        }

        public void LoadView(UserControl userControl) {
            loadedView = userControl;

            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;

            logoutButton.Visible = userSession.LoggedInStaff.Role != "unauthorized";

            mainPanel.Controls.Add(userControl);
            ShowTabs();
        }

        private void KitchenToolBarClick(object sender, EventArgs e) {
            LoadView(new OrderView("food"));
        }

        private void StaffToolBarClick(object sender, EventArgs e) {
            LoadView(new StaffView());
        }

        private void BarToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadView(new OrderView("drink"));
        }

        private void VoorraadToolStripMenuItem_Click(object sender, EventArgs e) {
            if(userSession.LoggedInStaff.Role == "owner") {
                LoadView(new StockPickerView(this));
            }
            else if(userSession.LoggedInStaff.Role == "chef") {
                LoadView(new StockView("food"));
            } 
            else if (userSession.LoggedInStaff.Role == "bartender") {
                LoadView(new StockView("drink"));
            }
        }

        private void SalesViewToolStripMenuItemOnClick(object sender, EventArgs e) {
            LoadView(new SalesView());
        }

        private void MenuViewToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadView(new MenuPickerView(this));
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            userSession.Logout();
            LoadView(new LoginView());
        }
    }
}
