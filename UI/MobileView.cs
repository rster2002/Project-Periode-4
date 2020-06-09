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
        private List<HistoryItem> history = new List<HistoryItem>();

        private MobileView() {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public static MobileView GetInstance() {
            if (instance == null) instance = new MobileView();
            return instance;
        }

        public void LoadView(UserControl userControl, bool trackInHistory = true) {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;

            if (trackInHistory) {
                history.Add(new HistoryItem() {
                    UserControl = userControl,
                    LabelText = currentPageLbl.Text
                });
            }

            ShowBackButton();

            mainPanel.Controls.Add(userControl);
        }

        public void LoadView(UserControl userControl, string setLabelText, bool trackInHistort = true) {
            currentPageLbl.Text = setLabelText;
            LoadView(userControl, trackInHistort);
        }

        public void ClearHistory() {
            history.Clear();
        }

        public void ResetTo(UserControl userControl, string setLabelText) {
            ClearHistory();
            LoadView(userControl, setLabelText);
            ShowBackButton();
        }

        private void ShowBackButton() {
            if (history.Count == 1) {
                historyBackButton.Hide();
            }
            else {
                historyBackButton.Show();
            }
            if (history.Count > 2) {
                historyBackButton.Text = "Terug";
            } else {
                historyBackButton.Text = "Logout";
            }
        }

        private void HistoryBackButtonOnClick(object sender, EventArgs e) {
            history.Remove(history.Last());

            HistoryItem lastHistoryItem = history.Last();
            currentPageLbl.Text = lastHistoryItem.LabelText;
            LoadView(lastHistoryItem.UserControl, false);
        }
    }

    class HistoryItem {
        public UserControl UserControl { get; set; }
        public string LabelText { get; set; }
    }
}
