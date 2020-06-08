namespace UI.DesktopViews {
    partial class StockView {
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
            this.refreshStockTimer = new System.Windows.Forms.Timer(this.components);
            this.PnlStock = new System.Windows.Forms.Panel();
            this.LblAmount = new System.Windows.Forms.Label();
            this.LblGerecht = new System.Windows.Forms.Label();
            this.PnlStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshStockTimer
            // 
            this.refreshStockTimer.Tick += new System.EventHandler(this.RefreshStockTimer_Tick);
            // 
            // PnlStock
            // 
            this.PnlStock.AutoScroll = true;
            this.PnlStock.Controls.Add(this.LblAmount);
            this.PnlStock.Controls.Add(this.LblGerecht);
            this.PnlStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlStock.Location = new System.Drawing.Point(0, 0);
            this.PnlStock.Name = "PnlStock";
            this.PnlStock.Size = new System.Drawing.Size(1904, 982);
            this.PnlStock.TabIndex = 0;
            // 
            // LblAmount
            // 
            this.LblAmount.AutoSize = true;
            this.LblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmount.Location = new System.Drawing.Point(1450, 70);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(133, 46);
            this.LblAmount.TabIndex = 1;
            this.LblAmount.Text = "Aantal";
            // 
            // LblGerecht
            // 
            this.LblGerecht.AutoSize = true;
            this.LblGerecht.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGerecht.Location = new System.Drawing.Point(52, 70);
            this.LblGerecht.Name = "LblGerecht";
            this.LblGerecht.Size = new System.Drawing.Size(162, 46);
            this.LblGerecht.TabIndex = 0;
            this.LblGerecht.Text = "Gerecht";
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.PnlStock);
            this.Name = "StockView";
            this.Size = new System.Drawing.Size(1904, 982);
            this.PnlStock.ResumeLayout(false);
            this.PnlStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer refreshStockTimer;
        private System.Windows.Forms.Panel PnlStock;
        private System.Windows.Forms.Label LblGerecht;
        private System.Windows.Forms.Label LblAmount;
    }
}
