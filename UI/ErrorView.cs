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
    public partial class ErrorView: Form {
        public ErrorView(string errorMessage) {
            InitializeComponent();

            lblErrorMessage.Text = errorMessage;
        }

        private void CloseDialogButton_OnClick(object sender, EventArgs e) {
            Close();
        }
    }
}
