using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.MobileViews;

namespace UI {
    public partial class MobileView: Form {
        private static MobileView instance;
        private List<UserControl> history = new List<UserControl>();

        private MobileView() {
            InitializeComponent();
            LoadView(new TableView());
        }

        public static MobileView GetInstance() {
            if (instance == null) instance = new MobileView();
            return instance;
        }

        public void LoadView(UserControl userControl, bool trackInHistory = true) {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;

            if (trackInHistory) {
                history.Add(userControl);
            }

            ShowBackButton();

            mainPanel.Controls.Add(userControl);
        }

        private void ShowBackButton() {
            historyBackButton.Visible = history.Count > 1;
        }

        private void button1_Click(object sender, EventArgs e) {
            history.Remove(history.Last());
            LoadView(history.Last(), false);
        }
    }
}
