﻿using System;
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
    public partial class StockView: UserControl {
        private MenuItemService menuItemSerivce = new MenuItemService();
        private List<Model.MenuItem> items;
        private string foodType;
        private int nextLabelYAxis;
        public StockView(string foodType) {
            this.foodType = foodType;

            InitializeComponent();
            PopulateStockView();

            if(foodType == "drink") {
                LblDish.Text = "Dranken";
            }

            //set interval for timer and enable timer.
            refreshStockTimer.Interval = 20000;
            refreshStockTimer.Enabled = true;

            //start the timer
            refreshStockTimer.Start();
        }

        private void PopulateStockView() {
            items = menuItemSerivce.OrderByStock();
            PnlStock.Controls.Clear();
            PnlStock.Controls.Add(LblDish);
            PnlStock.Controls.Add(LblAmount);
            nextLabelYAxis = 125;

            items = items
                .Where(menuItem => menuItem.Type == foodType)
                .ToList();

            foreach(Model.MenuItem item in items) {
                PnlStock.Controls.Add(GenerateAmountLabel(item));
                PnlStock.Controls.Add(GenerateNameLabel(item));

                nextLabelYAxis += 65;
            }
        }
        private Label GenerateNameLabel(Model.MenuItem item) {
            Label lbl = new Label();
            lbl.Text = item.Name;
            lbl.Location = new Point(60, nextLabelYAxis);
            lbl.ForeColor = Color.White;

            if(item.AmountInStock < 15) {
                lbl.BackColor = Color.FromArgb(158, 44, 44);
            } else if(item.AmountInStock >= 15 && item.AmountInStock < 25){
                lbl.BackColor = Color.FromArgb(181, 97, 27);
            } else {
                lbl.BackColor = Color.FromArgb(55, 107, 51);
            }

            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = new Font("Microsoft Sans Serif", 25);
            lbl.Width = 1600;
            lbl.Height = 50;
            if (UserSession.GetInstance().LoggedInStaff.Role == "owner") {
                lbl.Click += new EventHandler((object sender, EventArgs e) => CreateChangePopup(item));
            }

            return lbl;
        }

        private void CreateChangePopup(Model.MenuItem itemToChange) {
            StockManagementPopup popup = new StockManagementPopup(itemToChange);
            popup.ShowDialog();

        }
        private Label GenerateAmountLabel(Model.MenuItem item) {
            Label lbl = new Label();

            lbl.Text = item.AmountInStock.ToString();
            lbl.Location = new Point(1500, nextLabelYAxis);
            lbl.ForeColor = Color.White;

            if (item.AmountInStock < 15) {
                lbl.BackColor = Color.FromArgb(158, 44, 44);
            } else if (item.AmountInStock >= 15 && item.AmountInStock < 25) {
                lbl.BackColor = Color.FromArgb(181, 97, 27);
            } else {
                lbl.BackColor = Color.FromArgb(55, 107, 51);
            }

            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = new Font("Microsoft Sans Serif", 20);
            lbl.Padding = new Padding(0, 5, 0, 0);
            lbl.AutoSize = true;

            return lbl;
        }

        private void RefreshStockTimer_Tick(object sender, EventArgs e) {
            PopulateStockView();
        }
    }
}
