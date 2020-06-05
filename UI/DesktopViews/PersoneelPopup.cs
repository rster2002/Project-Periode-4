using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI {
    public partial class PersoneelPopup: Form {

        PersoneelView mainView;
        Staff employee;
        public PersoneelPopup(Staff employee, PersoneelView mainview) {
            InitializeComponent();
            this.employee = employee;
            labelEName.Text += employee.Name;
            labelEId.Text += employee.Id;
            labelERole.Text += employee.Role;
            if(employee.Role == "owner") {
                ontslagBtn.Enabled = false;
            }
            mainView = mainview;
        }


        private void ontslagBtn_Click(object sender, EventArgs e) {
            Form confirm = new ExtraConfirmationPopup(employee, this);
            confirm.StartPosition = FormStartPosition.Manual;
            Point startPos = this.Location;
            startPos.Offset(25, 50);
            confirm.Location = startPos;
            confirm.ShowDialog();
            
        }

        private void PersoneelPopup_FormClosed(object sender, FormClosedEventArgs e) {
            foreach (Control c in mainView.Controls.OfType<Label>().ToList()) {
                if (c.Name == "") {
                    c.Dispose();
                }
            }
            mainView.LoadPersoneelInfo();
        }
    }
}
