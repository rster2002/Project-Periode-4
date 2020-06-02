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
    public partial class ExtraConfirmationPopup: Form {
        Staff employeeToFire;
        StaffService staffService = new StaffService();
        PersoneelPopup opener;
        public ExtraConfirmationPopup(Staff employee, PersoneelPopup opener) {
            InitializeComponent();
            employeeToFire = employee;
            this.opener = opener;
        }
        
        private void terugBtn_Click(object sender, EventArgs e) {
            this.Close();

        }

        private void confirmBtn_Click(object sender, EventArgs e) {
            if(staffService.DeleteStaffById(employeeToFire.Id)) {
                label1.Text = "Werknemer succesvol verwijderd.";
                this.Close();
                opener.Close();
            } else {
                label1.Text = "Werknemer kon niet verwijderd worden, probeer het later nog eens.";
            }
        }
    }
}
