namespace UI.DesktopViews {
    partial class StockPickerView {
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
            this.LblKitchen = new System.Windows.Forms.Label();
            this.LblBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblKitchen
            // 
            this.LblKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKitchen.ForeColor = System.Drawing.Color.White;
            this.LblKitchen.Location = new System.Drawing.Point(283, 173);
            this.LblKitchen.Name = "LblKitchen";
            this.LblKitchen.Size = new System.Drawing.Size(670, 46);
            this.LblKitchen.TabIndex = 0;
            this.LblKitchen.Text = "Keuken";
            this.LblKitchen.Click += new System.EventHandler(this.LblKitchen_Click);
            // 
            // LblBar
            // 
            this.LblBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LblBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBar.ForeColor = System.Drawing.Color.White;
            this.LblBar.Location = new System.Drawing.Point(283, 290);
            this.LblBar.Name = "LblBar";
            this.LblBar.Size = new System.Drawing.Size(670, 46);
            this.LblBar.TabIndex = 1;
            this.LblBar.Text = "Bar";
            this.LblBar.Click += new System.EventHandler(this.LblBar_Click);
            // 
            // StockPickerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.LblBar);
            this.Controls.Add(this.LblKitchen);
            this.Name = "StockPickerView";
            this.Size = new System.Drawing.Size(1904, 982);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblKitchen;
        private System.Windows.Forms.Label LblBar;
    }
}
