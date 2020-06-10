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
    public partial class DeleteMenuItemForm: Form {
        private MenuItemService menuItemService = new MenuItemService();
        private Model.MenuItem item;
        public DeleteMenuItemForm(Model.MenuItem item) {
            this.item = item;

            InitializeComponent();

            CenterToScreen();
        }

        private void BtnNo_Click(object sender, EventArgs e) {
            Close();
        }

        private void BtnYes_Click(object sender, EventArgs e) {
            menuItemService.DeleteMenuItem(item.Id);
            Close();
        }
    }
}
