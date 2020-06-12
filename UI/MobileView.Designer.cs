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
            this.currentPageLbl = new System.Windows.Forms.Label();
            this.historyBackButton = new System.Windows.Forms.Button();
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
            this.topBarPanel.Controls.Add(this.currentPageLbl);
            this.topBarPanel.Controls.Add(this.historyBackButton);
            this.topBarPanel.Controls.Add(this.currentScreenLbl);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(398, 42);
            this.topBarPanel.TabIndex = 0;
            // 
            // currentPageLbl
            // 
            this.currentPageLbl.AutoSize = true;
            this.currentPageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPageLbl.ForeColor = System.Drawing.Color.White;
            this.currentPageLbl.Location = new System.Drawing.Point(12, 8);
            this.currentPageLbl.Name = "currentPageLbl";
            this.currentPageLbl.Size = new System.Drawing.Size(0, 26);
            this.currentPageLbl.TabIndex = 0;
            // 
            // historyBackButton
            // 
            this.historyBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.historyBackButton.CausesValidation = false;
            this.historyBackButton.FlatAppearance.BorderSize = 0;
            this.historyBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBackButton.ForeColor = System.Drawing.Color.White;
            this.historyBackButton.Location = new System.Drawing.Point(291, 3);
            this.historyBackButton.Name = "historyBackButton";
            this.historyBackButton.Size = new System.Drawing.Size(104, 36);
            this.historyBackButton.TabIndex = 1;
            this.historyBackButton.Text = "Log uit";
            this.historyBackButton.UseVisualStyleBackColor = false;
            this.historyBackButton.Click += new System.EventHandler(this.HistoryBackButtonOnClick);
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
        private System.Windows.Forms.Button historyBackButton;
        private System.Windows.Forms.Label currentPageLbl;
    }
}