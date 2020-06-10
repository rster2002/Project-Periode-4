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
        private MenuService menuService = new MenuService();
        public AddMenuItemForm(Model.Menu menu) {
            this.menu = menu;

            InitializeComponent();

            comboBoxBTW.SelectedIndex = 0;
            if(menu.Name == "Drankedkaart") {
                comboBoxType.Items.Clear();
                comboBoxType.Items.Add("Drink");
            }
            comboBoxType.SelectedIndex = 0;

            CenterToScreen();
        }

        private void BtnAddDish_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(textBox1.Text)) {
                // it is not empty or null!
                //menuService.AddDishToMenu();
            } else {
                LblWarning.Text = "Kan geen item zonder naam toevoegen!";
            }
        }
    }
}
