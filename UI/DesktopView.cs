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

namespace UI {
    public partial class DesktopView: Form {
        public static DesktopView instance;
        public UserControl loadedView;

        // Handiger als apparte class vanwege Seperation of Consern?
        public Staff loggedIn = new Staff() {
            Role = "unautherized"
        };

        public static DesktopView GetInstance() {
            if (instance == null) instance = new DesktopView();
            return instance;
        }

        private DesktopView() {
            InitializeComponent();
        }

        private void ShowTabs() {
            for (int i = 0; i < menuStrip.Items.Count; i++) {
                ToolStripItem item = menuStrip.Items[i];

                item.Visible = ((string) item.Tag).Contains(loggedIn.Role);

                // Checken op naam is een beetje, eh...
                //if (loadedView != null && item.Name.ToLower().Contains(loadedView.Name.ToLower())) {
                //    item.BackColor = Color.FromArgb(255, 255, 255);
                //} else {
                //    item.BackColor = Color.FromArgb(33, 33, 33);
                //}
            }
        }

        public void LoadView(UserControl userControl) {
            loadedView = userControl;

            ShowTabs();
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(userControl);
        }

        private void KitchenToolBarClick(object sender, EventArgs e) {
            LoadView(new TestView());
        }
    }
}
