using System.Collections.Generic;

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
            this.testViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voorraadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tafelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personeelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omzetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.testViewToolStripMenuItem,
            this.barToolStripMenuItem,
            this.voorraadToolStripMenuItem,
            this.tafelsToolStripMenuItem,
            this.personeelToolStripMenuItem,
            this.omzetToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1904, 59);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // testViewToolStripMenuItem
            // 
            this.testViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.testViewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.testViewToolStripMenuItem.Name = "testViewToolStripMenuItem";
            this.testViewToolStripMenuItem.Size = new System.Drawing.Size(158, 55);
            this.testViewToolStripMenuItem.Tag = "chef, owner";
            this.testViewToolStripMenuItem.Text = "Keuken";
            this.testViewToolStripMenuItem.Click += new System.EventHandler(this.KitchenToolBarClick);
            // 
            // barToolStripMenuItem
            // 
            this.barToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.barToolStripMenuItem.Name = "barToolStripMenuItem";
            this.barToolStripMenuItem.Size = new System.Drawing.Size(88, 55);
            this.barToolStripMenuItem.Tag = "bartender, owner";
            this.barToolStripMenuItem.Text = "Bar";
            this.barToolStripMenuItem.Click += new System.EventHandler(this.BarToolStripMenuItem_Click);
            // 
            // voorraadToolStripMenuItem
            // 
            this.voorraadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.voorraadToolStripMenuItem.Name = "voorraadToolStripMenuItem";
            this.voorraadToolStripMenuItem.Size = new System.Drawing.Size(186, 55);
            this.voorraadToolStripMenuItem.Tag = "bartender, chef, owner";
            this.voorraadToolStripMenuItem.Text = "Voorraad";
            this.voorraadToolStripMenuItem.Click += new System.EventHandler(this.VoorraadToolStripMenuItem_Click);
            // 
            // tafelsToolStripMenuItem
            // 
            this.tafelsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tafelsToolStripMenuItem.Name = "tafelsToolStripMenuItem";
            this.tafelsToolStripMenuItem.Size = new System.Drawing.Size(126, 55);
            this.tafelsToolStripMenuItem.Tag = "owner";
            this.tafelsToolStripMenuItem.Text = "Tafels";
            // 
            // personeelToolStripMenuItem
            // 
            this.personeelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.personeelToolStripMenuItem.Name = "personeelToolStripMenuItem";
            this.personeelToolStripMenuItem.Size = new System.Drawing.Size(196, 55);
            this.personeelToolStripMenuItem.Tag = "owner";
            this.personeelToolStripMenuItem.Text = "Personeel";
            // 
            // omzetToolStripMenuItem
            // 
            this.omzetToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.omzetToolStripMenuItem.Name = "omzetToolStripMenuItem";
            this.omzetToolStripMenuItem.Size = new System.Drawing.Size(146, 55);
            this.omzetToolStripMenuItem.Tag = "owner";
            this.omzetToolStripMenuItem.Text = "Omzet";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(132, 55);
            this.menuToolStripMenuItem.Tag = "owner";
            this.menuToolStripMenuItem.Text = "Menu";
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
        private System.Windows.Forms.ToolStripMenuItem testViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voorraadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tafelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personeelViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omzetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}

