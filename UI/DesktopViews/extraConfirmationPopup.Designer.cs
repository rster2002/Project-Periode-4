namespace UI {
    partial class ExtraConfirmationPopup {
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
            this.label1 = new System.Windows.Forms.Label();
            this.terugBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (33)))), ((int) (((byte) (33)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weet u het zeker? \r\nDit kan niet ongedaan gemaakt worden!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // terugBtn
            // 
            this.terugBtn.BackColor = System.Drawing.SystemColors.Control;
            this.terugBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.terugBtn.ForeColor = System.Drawing.Color.Black;
            this.terugBtn.Location = new System.Drawing.Point(36, 114);
            this.terugBtn.Name = "terugBtn";
            this.terugBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.terugBtn.Size = new System.Drawing.Size(135, 35);
            this.terugBtn.TabIndex = 5;
            this.terugBtn.Text = "Terug";
            this.terugBtn.UseVisualStyleBackColor = false;
            this.terugBtn.Click += new System.EventHandler(this.terugBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.SystemColors.Control;
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmBtn.ForeColor = System.Drawing.Color.Black;
            this.confirmBtn.Location = new System.Drawing.Point(262, 114);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confirmBtn.Size = new System.Drawing.Size(135, 35);
            this.confirmBtn.TabIndex = 6;
            this.confirmBtn.Text = "Ja";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // extraConfirmationPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (181)))), ((int) (((byte) (181)))), ((int) (((byte) (181)))));
            this.ClientSize = new System.Drawing.Size(434, 161);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.terugBtn);
            this.Controls.Add(this.label1);
            this.Name = "extraConfirmationPopup";
            this.Text = "extraConfirmationPopup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button terugBtn;
        private System.Windows.Forms.Button confirmBtn;
    }
}