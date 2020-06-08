namespace UI.DesktopViews {
    partial class MenuPickerView {
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
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.refreshMenuTimer = new System.Windows.Forms.Timer(this.components);
            this.LblMenu = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.PnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.LblAmount);
            this.PnlMenu.Controls.Add(this.LblMenu);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(1904, 982);
            this.PnlMenu.TabIndex = 0;
            // 
            // refreshMenuTimer
            // 
            this.refreshMenuTimer.Tick += new System.EventHandler(this.RefreshMenuTimer_Tick);
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(55, 40);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(102, 39);
            this.LblMenu.TabIndex = 0;
            this.LblMenu.Text = "Menu";
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmount.Location = new System.Drawing.Point(1465, 40);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(114, 39);
            this.LblAmount.TabIndex = 1;
            this.LblAmount.Text = "Aantal";
            // 
            // MenuPickerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.PnlMenu);
            this.Name = "MenuPickerView";
            this.Size = new System.Drawing.Size(1904, 982);
            this.PnlMenu.ResumeLayout(false);
            this.PnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private System.Windows.Forms.Timer refreshMenuTimer;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.Label LblAmount;
    }
}
