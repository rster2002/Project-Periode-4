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

namespace UI.DesktopViews {
    public partial class MenuPickerView: UserControl {
        private MenuService menuService = new MenuService();
        private List<Model.Menu> menus;
        private int nextLabelYAxis;
        private DesktopView parent;
        public MenuPickerView(DesktopView parent) {

            this.parent = parent;
            InitializeComponent();

            PopulateMenuView();
        }
        private void PopulateMenuView() {
            menus = menuService.GetMenus();
            PnlMenu.Controls.Clear();

            PnlMenu.Controls.Add(LblMenu);
            PnlMenu.Controls.Add(LblAmount);

            nextLabelYAxis = 100;

            //set interval for timer and enable timer.
            refreshMenuTimer.Interval = 20000;
            refreshMenuTimer.Enabled = true;

            //start the timer
            refreshMenuTimer.Start();

            foreach (Model.Menu menu in menus) {
                PnlMenu.Controls.Add(GenerateAmountLabel(menu));
                PnlMenu.Controls.Add(GenerateNameLabel(menu));

                nextLabelYAxis += 65;
            }
        }

        private Control GenerateNameLabel(Model.Menu menu) {
            Label lbl = new Label();

            lbl.Text = menu.Name;
            lbl.Location = new Point(60, nextLabelYAxis);

            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.FromArgb(33, 33, 33);

            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = new Font("Microsoft Sans Serif", 25);

            lbl.Width = 1600;
            lbl.Height = 50;

            lbl.Click += (sender, e) => ShowItemsOnMenu(sender, e, menu);

            return lbl;
        }

        private Control GenerateAmountLabel(Model.Menu menu) {
            Label lbl = new Label();

            lbl.Text = menu.Items.Count.ToString();
            lbl.Location = new Point(1500, nextLabelYAxis);

            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.FromArgb(33, 33, 33);

            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = new Font("Microsoft Sans Serif", 20);
            lbl.Padding = new Padding(0, 5, 0, 0);
            lbl.AutoSize = true;

            return lbl;
        }

        private void RefreshMenuTimer_Tick(object sender, EventArgs e) {
            PopulateMenuView();
        }

        private void ShowItemsOnMenu(object sender, EventArgs e, Model.Menu selectedMenu) {
            parent.LoadView(new ItemsOnMenuView(selectedMenu));
        }
    }
}
