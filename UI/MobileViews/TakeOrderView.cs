using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI.MobileViews {
    public partial class TakeOrderView: UserControl {
        private Model.Menu menu;

        public TakeOrderView(Model.Menu menu) {
            this.menu = menu;

            InitializeComponent();
        }

        private void PopulateMenuItemTypes() {
            menuItemTypeButtons.Controls.Clear();
            menuItemTypeButtons.RowStyles.Clear();
            menuItemTypeButtons.RowCount = 0;


        }
    }
}
