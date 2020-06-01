namespace UI {
    partial class MobileView {
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
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.currentScreenLbl = new System.Windows.Forms.Label();
            this.topBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 48);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(398, 649);
            this.mainPanel.TabIndex = 0;
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.topBarPanel.Controls.Add(this.currentScreenLbl);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(398, 42);
            this.topBarPanel.TabIndex = 0;
            // 
            // currentScreenLbl
            // 
            this.currentScreenLbl.AutoSize = true;
            this.currentScreenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScreenLbl.ForeColor = System.Drawing.Color.White;
            this.currentScreenLbl.Location = new System.Drawing.Point(159, 9);
            this.currentScreenLbl.Name = "currentScreenLbl";
            this.currentScreenLbl.Size = new System.Drawing.Size(0, 24);
            this.currentScreenLbl.TabIndex = 1;
            // 
            // MobileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(398, 697);
            this.Controls.Add(this.topBarPanel);
            this.Controls.Add(this.mainPanel);
            this.Name = "MobileView";
            this.Text = "MobileView";
            this.topBarPanel.ResumeLayout(false);
            this.topBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Label currentScreenLbl;
    }
}