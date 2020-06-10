using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.MobileViews;
using Model;
using System.Security.Policy;
using System.Security.Cryptography;

namespace UI.MobileViews {
    public partial class LoginViewMobile: UserControl {
        public MobileView mobileView = MobileView.GetInstance();
        public UserSession userSession = UserSession.GetInstance();
        private int staffId;
        private string wachtwoord;
        private Staff loggedStaff;

        public LoginViewMobile() {
            InitializeComponent();
            txtb_wachtwoord.UseSystemPasswordChar = true;
        }

        private void Btn_login_Click(object sender, EventArgs e) {
            if (txtb_gebruiker.Text == "" || txtb_wachtwoord.Text == "")
                lbl_geengegevens.Text = "Staffnummer en wachtwoord \nmoeten ingevuld zijn!";
            else {
                wachtwoord = txtb_wachtwoord.Text;
                if (ParseGegevens(txtb_gebruiker.Text)) {
                    StaffService staffService = new StaffService();
                    loggedStaff = staffService.GetStaffById(staffId);

                    if (CheckGebruiker(loggedStaff, wachtwoord)) {
                        userSession.SetLoggedInStaff(loggedStaff);
                        KiesScherm(loggedStaff);
                    }
                    else {
                        txtb_wachtwoord.Text = null;
                        lbl_geengegevens.Text = "Onjuist staffnummer of wachtwoord";
                    }
                } else {
                    txtb_wachtwoord.Text = null;
                    lbl_geengegevens.Text = "Onjuist staffnummer of wachtwoord";
                }
            }
        }

        private bool CheckGebruiker(Staff loggedStaff, string password) { //check inlog gegevens
            if (loggedStaff == null) return false;
            if (loggedStaff.Hash == GetHashString(loggedStaff, password)) {
                return true;
            }

            return false;
        }

        private bool ParseGegevens(string gebruikersnaam) { //try parse string naar int
            bool staffIdCorrect = int.TryParse(gebruikersnaam, out int result);

            if (!staffIdCorrect)
                return false;

            staffId = result;
            return true;
        }

        private void KiesScherm(Staff staff) {
            string rol = staff.Role;

            switch (rol) {
                case "waiter":
                    mobileView.LoadView(new TableView(), "Tafels");
                    userSession = UserSession.GetInstance();
                    break;
                case "owner":
                    mobileView.LoadView(new TableView(), "Tafels");
                    userSession = UserSession.GetInstance();
                    break;
                case "bartender":
                    lbl_geengegevens.Text = "Barpersoneel kan niet hier inloggen";
                    break;
                case "chef":
                    lbl_geengegevens.Text = "Keukenpersoneel kan niet hier inloggen";
                    break;
            }
        }

        private byte[] GetHash(Staff staff, string wachtwoord) {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(wachtwoord + staff.Salt));
        }
        public string GetHashString(Staff staff, string wachtwoord) {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(staff, wachtwoord)) {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        private void Btn_changeView_Click(object sender, EventArgs e) {
            mobileView.Close();
        }
    }
}
