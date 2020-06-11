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
        private TableService tableService = new TableService();
        private ReservationService reservationService = new ReservationService();
        private OrderService orderService = new OrderService();
        private List<Table> tables;

        public TableView() {
            InitializeComponent();
            try {
                tables = tableService.GetAllTables();
            } catch (Exception error) {
                ErrorView errorView = new ErrorView(error.Message);
                errorView.ShowDialog();
            }

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
            Panel textPanel = new Panel();
            PictureBox pictureBox = new PictureBox();
            Label tafelLabel = new Label();
            Label waittimeLabel = new Label();

            panel.Size = new Size(193, 115);
            textPanel.Size = new Size(193, 27);
            textPanel.Dock = DockStyle.Bottom;

            // Prepare pictureBox
            pictureBox.Image = ((Image) (resources.GetObject("pictureBox1.Image")));
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Size = new Size(186, 83);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Tag = table;
            pictureBox.Click += TablePanelOnClick;

            //prepare wachttijd label
            waittimeLabel.BackColor = Color.FromArgb(181, 181, 181);
            waittimeLabel.Dock = DockStyle.Right;
            waittimeLabel.TextAlign = ContentAlignment.BottomRight;
            waittimeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);

            // Prepare tafellabel
            tafelLabel.Text = "Tafel " + table.Number;
            tafelLabel.Dock = DockStyle.Left;
            tafelLabel.TextAlign = ContentAlignment.BottomLeft;
            tafelLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);

            if (table.Status == "Available") {
                tafelLabel.ForeColor = Color.Black;
                tafelLabel.BackColor = Color.FromArgb(132, 204, 6);
                
            } else if (table.Status == "Reserved") {
                tafelLabel.ForeColor = Color.Black;
                tafelLabel.BackColor = Color.FromArgb(221, 243, 17);
            } else {
                tafelLabel.ForeColor = Color.White;
                tafelLabel.BackColor = Color.FromArgb(152, 0, 0);
            }

            if (orderService.GetPreparedOrdersByTableId(table.Number)) {
                waittimeLabel.BackColor = Color.Orange;
            } else if (tableService.CheckOrderPresent(table.Number)) {
                waittimeLabel.BackColor = Color.DarkTurquoise;
            } else {
                waittimeLabel.BackColor = Color.FromArgb(181, 181, 181);
            }
            
            textPanel.Controls.Add(tafelLabel);
            textPanel.Controls.Add(waittimeLabel);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(textPanel);

            return panel;
        }
        
        private void TablePanelOnClick(object sender, EventArgs args) {
            MobileView mobileView = MobileView.GetInstance();
            PictureBox pictureBox = (PictureBox) sender;
            Table table = (Table) pictureBox.Tag;

            mobileView.LoadView(new TableControlsView(table), "Tafel " + table.Number);
        }
    }
}
