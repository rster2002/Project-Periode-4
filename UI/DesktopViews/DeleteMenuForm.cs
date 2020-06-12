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
    public partial class DeleteMenuForm: Form {
        private Model.Menu menu;
        private MenuService menuService = new MenuService();
        private DesktopView parent;
        public DeleteMenuForm(Model.Menu menu, DesktopView parent) {
            this.menu = menu;
            this.parent = parent;

            InitializeComponent();

            CenterToScreen();
        }

        private void BtnNo_Click(object sender, EventArgs e) {
            Close();
        }

        private void BtnYes_Click(object sender, EventArgs e) {
            menuService.DeleteMenu(menu.Id);
            Close();
            parent.LoadView(new MenuPickerView(parent));
        }
    }
}
