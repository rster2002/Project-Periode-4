﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Model;

namespace UI {
    public partial class LoginView: UserControl {
        private DesktopView mainView = DesktopView.GetInstance();
        private int staffId;
        private string wachtwoord;
        private Staff loggedStaff;

        public LoginView() {
            InitializeComponent();
            txtb_wachtwoord.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e) {
            if (txtb_gebruiker.Text == "" || txtb_wachtwoord.Text == "")
                lbl_geengegevens.Text = "Staffnummer en wachtwoord \nmoeten ingevuld zijn!";
            else {
                wachtwoord = txtb_wachtwoord.Text;
                if (ParseGegevens(txtb_gebruiker.Text)) {
                    if (CheckGebruiker(staffId, wachtwoord))
                        KiesScherm(loggedStaff);
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
        private bool CheckGebruiker(int staffId, string password) { //check inlog gegevens
            StaffService staffService = new StaffService();
            loggedStaff = staffService.GetStaffById(staffId);

            if (loggedStaff.Hash == GetHashString(loggedStaff, password)) {
                return true;
            }

            return false;
        }
        private bool ParseGegevens(string gebruikersnaam) { //try parse gebruikersnaam string naar int
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
                    mainView.LoadView(new TestView());
                    break;
                case "owner":
                    mainView.LoadView(new TestView());
                    break;
                case "bartender":
                    mainView.LoadView(new TestView());
                    break;
                case "chef":
                    mainView.LoadView(new TestView());
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
    }
}
