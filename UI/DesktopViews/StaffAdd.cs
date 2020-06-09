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
    public partial class StaffAdd: Form {
        StaffView mainView;
        StaffService staffService = new StaffService();
        Random randomSalt = new Random();
        public StaffAdd(StaffView mainView) {
            InitializeComponent();
            this.mainView = mainView;
            
        }

        private void PersoneelAdd_FormClosed(object sender, FormClosedEventArgs e) {
            mainView.LoadPersoneelInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (staffService.AddStaffMember(textBoxName.Text,  textBoxRole.Text, randomSalt.Next(0, 999999), textBoxPass.Text)) {
                labelNotifcation.Text = "Medewerker toegevoegd!";
                textBoxName.Enabled = false;
                textBoxRole.Enabled = false;
                textBoxPass.Enabled = false;
                btnAdd.Enabled = false;
            } else {
                labelNotifcation.Text = "Medewerker toevoegen mislukt, probeer het later nog eens.";
            }
        }
        private void btnBack_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
