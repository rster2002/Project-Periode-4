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

namespace UI  {
    public partial class PersoneelView: UserControl {

        StaffService staffService = new StaffService();
        List<Staff> staffList = new List<Staff>();
        int nextLabelYAxis = 175;

        public PersoneelView() {
            InitializeComponent();
            staffList = staffService.GetAllStaff();
            LoadPersoneelInfo();
        }

        List<Label> nameLabelList = new List<Label>();
        List<Label> functionLabelList = new List<Label>();

        private void LoadPersoneelInfo() {

            for (int i = 0; i < staffList.Count; i++) {
                Staff currentStaff = staffList[i];

                nameLabelList.Add(new Label());
                functionLabelList.Add(new Label());
                nameLabelList[i].Text = currentStaff.Name;
                functionLabelList[i].Text = currentStaff.Role;

                nameLabelList[i].Click += new EventHandler((object sender, EventArgs e) => OpenEmployeePage(currentStaff.Id));

            }

            foreach (Label label in nameLabelList) {
                label.Location = new Point(150, nextLabelYAxis);
                label.Width = 1600;
                label.Height = 50;
                label.ForeColor = Color.White;
                label.BackColor = Color.FromArgb(33, 33, 33);
                label.Font = new Font("Microsoft Sans Serif", 25);
                label.Padding = new Padding(0, 5, 0, 0);

                Controls.Add(label);
                nextLabelYAxis += 65;
            }

            nextLabelYAxis = 175;
            foreach (Label label in functionLabelList) {
                label.Location = new Point(1550, nextLabelYAxis);
                label.AutoSize = true;
                label.Font = new Font("Microsoft Sans Serif", 25);
                label.ForeColor = Color.White;
                label.BackColor = Color.FromArgb(33, 33, 33);
                label.Padding = new Padding(0, 5, 0, 0);
                Controls.Add(label);
                label.BringToFront();
                nextLabelYAxis += 65;
            }

        }

        void OpenEmployeePage(int employeeId) {
            Form popup = new PersoneelPopup(staffList[employeeId -1]);
            popup.StartPosition = FormStartPosition.Manual;
            Point newLocation = nameLabelList[employeeId - 1].Location;
            newLocation.Offset(500, 50);
            popup.Location = newLocation;
            popup.ShowDialog();
        }
    }
}

