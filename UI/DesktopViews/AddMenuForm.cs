using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.DesktopViews {
    public partial class AddMenuForm: Form {
        MenuService menuService = new MenuService();
        public AddMenuForm() {
            InitializeComponent();

            CenterToScreen();

            TimePickerStart.Format = DateTimePickerFormat.Custom;
            TimePickerStart.CustomFormat = "HH:mm tt";
            TimePickerStart.ShowUpDown = true;

            TimePickerEnd.Format = DateTimePickerFormat.Custom;
            TimePickerEnd.CustomFormat = "HH:mm tt";
            TimePickerEnd.ShowUpDown = true;
        }

        private void BtnAddMenu_Click(object sender, EventArgs e) {

            TimeSpan time1 = TimePickerStart.Value.TimeOfDay;
            TimeSpan time2 = TimePickerEnd.Value.TimeOfDay;
            Random rdm = new Random();

            if (!string.IsNullOrWhiteSpace(TextBoxName.Text)) {
                if(time1 < time2) {
                    menuService.AddMenu(rdm.Next(1, 999999),TextBoxName.Text,time1,time2);
                    Close();
                } else {
                    LblWarning.Text = "Kan geen menu toevoegen die latere begin tijd heeft dan eind tijd!";
                }
            } else {
                LblWarning.Text = "Kan geen menu zonder naam toevoegen!";
            }
        }
    }
}
