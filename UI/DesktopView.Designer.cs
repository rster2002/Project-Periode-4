﻿using System.Collections.Generic;

namespace UI {
    partial class DesktopView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.kitchenOrderViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barOrderViewStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omzetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 59);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1904, 982);
            this.mainPanel.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitchenOrderViewToolStripMenuItem,
            this.barOrderViewStripMenuItem,
            this.stockViewToolStripMenuItem,
            this.staffViewToolStripMenuItem,
            this.tablesViewToolStripMenuItem,
            this.omzetToolStripMenuItem,
            this.menuViewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1904, 59);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // kitchenOrderViewToolStripMenuItem
            // 
            this.kitchenOrderViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.kitchenOrderViewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.kitchenOrderViewToolStripMenuItem.Name = "kitchenOrderViewToolStripMenuItem";
            this.kitchenOrderViewToolStripMenuItem.Size = new System.Drawing.Size(159, 55);
            this.kitchenOrderViewToolStripMenuItem.Tag = "chef, owner";
            this.kitchenOrderViewToolStripMenuItem.Text = "Keuken";
            this.kitchenOrderViewToolStripMenuItem.Click += new System.EventHandler(this.KitchenToolBarClick);
            // 
            // barOrderViewStripMenuItem
            // 
            this.barOrderViewStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.barOrderViewStripMenuItem.Name = "barOrderViewStripMenuItem";
            this.barOrderViewStripMenuItem.Size = new System.Drawing.Size(88, 55);
            this.barOrderViewStripMenuItem.Tag = "bartender, owner";
            this.barOrderViewStripMenuItem.Text = "Bar";
            this.barOrderViewStripMenuItem.Click += new System.EventHandler(this.BarToolStripMenuItem_Click);
            // 
            // stockViewToolStripMenuItem
            // 
            this.stockViewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.stockViewToolStripMenuItem.Name = "stockViewToolStripMenuItem";
            this.stockViewToolStripMenuItem.Size = new System.Drawing.Size(188, 55);
            this.stockViewToolStripMenuItem.Tag = "bartender, chef, owner";
            this.stockViewToolStripMenuItem.Text = "Voorraad";
            this.stockViewToolStripMenuItem.Click += new System.EventHandler(this.VoorraadToolStripMenuItem_Click);
            // 
            // staffViewToolStripMenuItem
            // 
            this.staffViewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.staffViewToolStripMenuItem.Name = "staffViewToolStripMenuItem";
            this.staffViewToolStripMenuItem.Size = new System.Drawing.Size(197, 55);
            this.staffViewToolStripMenuItem.Tag = "owner";
            this.staffViewToolStripMenuItem.Text = "Personeel";
            this.staffViewToolStripMenuItem.Click += new System.EventHandler(this.StaffToolBarClick);
            // 
            // tablesViewToolStripMenuItem
            // 
            this.tablesViewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tablesViewToolStripMenuItem.Name = "tablesViewToolStripMenuItem";
            this.tablesViewToolStripMenuItem.Size = new System.Drawing.Size(130, 55);
            this.tablesViewToolStripMenuItem.Tag = "owner";
            this.tablesViewToolStripMenuItem.Text = "Tafels";
            this.tablesViewToolStripMenuItem.Click += new System.EventHandler(this.tablesViewToolStripMenuItem_Click);
            // 
            // omzetToolStripMenuItem
            // 
            this.omzetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.omzetToolStripMenuItem.Name = "omzetToolStripMenuItem";
            this.omzetToolStripMenuItem.Size = new System.Drawing.Size(146, 55);
            this.omzetToolStripMenuItem.Tag = "owner";
            this.omzetToolStripMenuItem.Text = "Omzet";
            // 
            // menuViewToolStripMenuItem
            // 
            this.menuViewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuViewToolStripMenuItem.Name = "menuViewToolStripMenuItem";
            this.menuViewToolStripMenuItem.Size = new System.Drawing.Size(132, 55);
            this.menuViewToolStripMenuItem.Tag = "owner";
            this.menuViewToolStripMenuItem.Text = "Menu";
            // 
            // DesktopView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip);
            this.Name = "DesktopView";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem kitchenOrderViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barOrderViewStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablesViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personeelViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omzetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffViewToolStripMenuItem;
    }
}

