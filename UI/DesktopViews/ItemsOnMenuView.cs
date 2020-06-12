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
using System.Runtime.Remoting.Channels;

namespace UI.DesktopViews {
    public partial class ItemsOnMenuView: UserControl {
        private Model.Menu menu;
        private MenuService menuService = new MenuService();
        private int nextLabelYAxis;
        private DesktopView parent;
        public ItemsOnMenuView(Model.Menu selectedMenu,DesktopView parent) {
            menu = selectedMenu;
            this.parent = parent;

            InitializeComponent();

            PopulateItemLayout();

            //set interval for timer and enable timer.
            refreshItemsOnMenu.Interval = 5000;
            refreshItemsOnMenu.Enabled = true;
            //start the timer
            refreshItemsOnMenu.Start();
        }

        private void PopulateItemLayout() {
            PnlMenuItem.Controls.Clear();
            nextLabelYAxis = 125;
            PnlMenuItem.Controls.Add(GenerateButtonAdd());
            PnlMenuItem.Controls.Add(GenerateButtonDeleteMenu());

            foreach (Model.MenuItem item in menu.Items) {
                PnlMenuItem.Controls.Add(GenerateLabelMenuItem(item));
                nextLabelYAxis += 65;
            }
        }

        private Control GenerateButtonAdd() {
            Button btn = new Button();

            btn.Text = "Toevoegen gerecht";
            btn.Location = new Point(55, 50);

            btn.Font = new Font("Microsoft Sans Serif", 20);
            btn.BackColor = Color.FromArgb(132, 204, 6);

            btn.AutoSize = true;
            btn.Click += new EventHandler(AddDish);

            return btn;
        }

        private Control GenerateButtonDeleteMenu() {
            Button btn = new Button();

            btn.Text = "verwijder menu";
            btn.Location = new Point(1455, 50);


            btn.Font = new Font("Microsoft Sans Serif", 20);
            btn.ForeColor = Color.White;
            btn.BackColor = Color.FromArgb(152, 0, 0);

            btn.AutoSize = true;
            btn.Click += new EventHandler(DeleteMenu);

            return btn;
        }
        private Control GenerateLabelMenuItem(Model.MenuItem item) {
            Label lbl = new Label();

            lbl.Text = item.Name;
            lbl.Location = new Point(60, nextLabelYAxis);

            lbl.ForeColor = Color.White;
            lbl.BackColor = Color.FromArgb(33, 33, 33);

            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = new Font("Microsoft Sans Serif", 20);
            lbl.Padding = new Padding(0, 5, 0, 0);

            lbl.Width = 1600;
            lbl.Height = 50;

            lbl.Click += (sender, e) => DeleteMenuItem(sender, e, item);

            return lbl;
        }

        private void AddDish(object sender, EventArgs e){
            AddMenuItemForm addMenuItem = new AddMenuItemForm(menu);
            addMenuItem.ShowDialog();
        }

        private void DeleteMenu(object sender, EventArgs e) {
            DeleteMenuForm deleteMenu = new DeleteMenuForm(menu,parent);
            deleteMenu.ShowDialog();
        }
        private void DeleteMenuItem(object sender, EventArgs e, Model.MenuItem item) {
            DeleteMenuItemForm deleteMenuItem = new DeleteMenuItemForm(item);
            deleteMenuItem.ShowDialog();
        }

        private void RefreshItemsOnMenu_Tick(object sender, EventArgs e) {
            PopulateItemLayout();
        }
    }
}
