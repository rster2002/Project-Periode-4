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
    public partial class TableView: UserControl {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableView));
        private TableService tableSerivce = new TableService();
        private List<Table> tables;

        public TableView() {
            InitializeComponent();

            tables = tableSerivce.GetAllTables();
            PopulateTableLayout();
        }

        private void PopulateTableLayout() {
            tablesOverviewLayout.Controls.Clear();
            tablesOverviewLayout.RowCount = 0;
            tablesOverviewLayout.RowStyles.Clear();

            int requiredNumberOfRows = (tables.Count + 1) / 2;
            decimal rowHeight = 100 / requiredNumberOfRows;

            for (int i = 0; i < requiredNumberOfRows; i++) {
                tablesOverviewLayout.RowCount++;

                tablesOverviewLayout.RowStyles.Add(new RowStyle(SizeType.Percent, (float) rowHeight));
            }

            foreach (Table table in tables) {
                tablesOverviewLayout.Controls.Add(GenerateTablePanel(table));
            }
        }

        private Panel GenerateTablePanel(Table table) {
            Panel panel = new Panel();
            PictureBox pictureBox = new PictureBox();
            Label label = new Label();

            panel.Size = new Size(193, 141);

            // Prepare pictureBox
            pictureBox.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Size = new Size(186, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new Point(4, 3);
            pictureBox.Tag = table;
            pictureBox.Click += TablePanelOnClick;

            // Prepare label
            label.Text = "Table " + table.Number;
            label.Dock = DockStyle.Bottom;
            label.Location = new Point(0, 121);
            label.Size = new Size(193, 20);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte) 0);

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(label);

            return panel;
        }

        private void TablePanelOnClick(object sender, EventArgs args) {
            MobileView mobileView = MobileView.GetInstance();
            PictureBox pictureBox = (PictureBox) sender;
            Table table = (Table) pictureBox.Tag;

            mobileView.LoadView(new TableControlsView(table));
        }
    }
}
