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

namespace UI.DesktopViews {
    public partial class StockManagementPopup: Form {
        Model.MenuItem objectToChange;
        MenuItemService itemService = new MenuItemService();
        public StockManagementPopup(Model.MenuItem menuItemToChange) {
            InitializeComponent();
            objectToChange = itemService.GetMenuItemById(menuItemToChange.Id);
            lblItemNaam.Text = objectToChange.Name;
            lblAmount.Text += objectToChange.AmountInStock.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e) {
            objectToChange.AmountInStock += (int) amountSelector.Value;
            itemService.UpdateAmountInStock(objectToChange);
            this.Close();
        }

        private void BtnRemove_Click(object sender, EventArgs e) {
            if (!(objectToChange.AmountInStock - (int) amountSelector.Value < 0)) {
                objectToChange.AmountInStock -= (int) amountSelector.Value;
                itemService.UpdateAmountInStock(objectToChange);
                this.Close();
            } 

        }

        private void amountSelector_ValueChanged(object sender, EventArgs e) {
            
            btnAdd.Enabled = (sender as NumericUpDown).Value != 0;
            btnRemove.Enabled = (sender as NumericUpDown).Value != 0 && !(objectToChange.AmountInStock - (int) amountSelector.Value < 0);
            
        }
    }

}
