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
    public partial class AddMenuItemForm: Form {
        private Model.Menu menu;
        private MenuItemService menuItemService = new MenuItemService();
        private MenuService menuService = new MenuService();
        private string type;
        public AddMenuItemForm(Model.Menu menu) {
            this.menu = menu;

            InitializeComponent();

            comboBoxBTW.SelectedIndex = 0;
            if(menu.Name == "Drankenkaart") {
                comboBoxType.Hide();
                LblType.Hide();
                type = "drink";
            } else {
                type = "food";
            }
            comboBoxType.SelectedIndex = 0;

            CenterToScreen();
        }

        private void BtnAddDish_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) {
                // it is not empty or null!
                Random rdm = new Random();
                int menuItemId = rdm.Next(1, 999999);
                int VAT;
                if (comboBoxBTW.SelectedItem == comboBoxBTW.Items[0]) {
                    VAT = 21;
                } else {
                    VAT = 6;
                }
                menuItemService.AddMenuItem(menuItemId, textBox1.Text, numericUpDown1.Value, VAT, (int) numericUpDown3.Value, type, comboBoxType.SelectedItem.ToString());
                menuService.AddItemToMenu(menu.Id, menuItemId);
            } else {
                LblWarning.Text = "Kan geen item zonder naam toevoegen!";
            }
        }
    }
}
