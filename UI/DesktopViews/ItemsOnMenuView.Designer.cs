namespace UI.DesktopViews {
    partial class ItemsOnMenuView {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.PnlMenuItem = new System.Windows.Forms.Panel();
            this.refreshItemsOnMenu = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PnlMenuItem
            // 
            this.PnlMenuItem.AutoScroll = true;
            this.PnlMenuItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMenuItem.Location = new System.Drawing.Point(0, 0);
            this.PnlMenuItem.Name = "PnlMenuItem";
            this.PnlMenuItem.Size = new System.Drawing.Size(1904, 982);
            this.PnlMenuItem.TabIndex = 0;
            // 
            // refreshItemsOnMenu
            // 
            this.refreshItemsOnMenu.Tick += new System.EventHandler(this.RefreshItemsOnMenu_Tick);
            // 
            // ItemsOnMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.PnlMenuItem);
            this.Name = "ItemsOnMenuView";
            this.Size = new System.Drawing.Size(1904, 982);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenuItem;
        private System.Windows.Forms.Timer refreshItemsOnMenu;
    }
}
