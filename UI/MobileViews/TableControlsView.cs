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
    public partial class TableControlsView: UserControl {
        public TableControlsView(Table table) {
            InitializeComponent();

            label1.Text = table.Number.ToString();
        }
    }
}
