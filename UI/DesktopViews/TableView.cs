using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.DesktopViews {
    public partial class TableView: UserControl {        
        
        public TableView() {
            InitializeComponent();
            LoadImages();
        }

        public void LoadImages() {

            listView1.View = View.LargeIcon;
            listView1.LargeImageList = new ImageList();
            listView1.LargeImageList.ImageSize = new Size(256, 170);
            listView1.LargeImageList.Images.Add("test", Properties.Resources.Table);

            for (int i = 0; i < 10; i++) {

                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = 0;
                lvi.Text = "Tafel " + (i + 1).ToString();
                lvi.Font = new Font("Microsoft Sans Serif", 16);
                listView1.Items.Add(lvi);
            }


        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e) {
            e.DrawDefault = true;
            e.Graphics.DrawRectangle(Pens.Black, e.Bounds);
        }
    }
}
