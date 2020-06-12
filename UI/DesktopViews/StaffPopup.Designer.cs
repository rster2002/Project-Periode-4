namespace UI {
    partial class StaffPopup {
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
            this.labelEName = new System.Windows.Forms.Label();
            this.labelEId = new System.Windows.Forms.Label();
            this.labelERole = new System.Windows.Forms.Label();
            this.labelBG = new System.Windows.Forms.Label();
            this.ontslagBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEName
            // 
            this.labelEName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelEName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelEName.ForeColor = System.Drawing.Color.White;
            this.labelEName.Location = new System.Drawing.Point(42, 74);
            this.labelEName.Name = "labelEName";
            this.labelEName.Size = new System.Drawing.Size(375, 35);
            this.labelEName.TabIndex = 0;
            this.labelEName.Text = "Naam: ";
            this.labelEName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEId
            // 
            this.labelEId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelEId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelEId.ForeColor = System.Drawing.Color.White;
            this.labelEId.Location = new System.Drawing.Point(42, 114);
            this.labelEId.Name = "labelEId";
            this.labelEId.Size = new System.Drawing.Size(375, 35);
            this.labelEId.TabIndex = 1;
            this.labelEId.Text = "ID: ";
            this.labelEId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelERole
            // 
            this.labelERole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelERole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelERole.ForeColor = System.Drawing.Color.White;
            this.labelERole.Location = new System.Drawing.Point(42, 155);
            this.labelERole.Name = "labelERole";
            this.labelERole.Size = new System.Drawing.Size(375, 35);
            this.labelERole.TabIndex = 2;
            this.labelERole.Text = "Functie: ";
            this.labelERole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBG
            // 
            this.labelBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelBG.ForeColor = System.Drawing.Color.White;
            this.labelBG.Location = new System.Drawing.Point(41, 27);
            this.labelBG.Name = "labelBG";
            this.labelBG.Size = new System.Drawing.Size(175, 35);
            this.labelBG.TabIndex = 3;
            this.labelBG.Text = "Medewerker";
            this.labelBG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ontslagBtn
            // 
            this.ontslagBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ontslagBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ontslagBtn.ForeColor = System.Drawing.Color.White;
            this.ontslagBtn.Location = new System.Drawing.Point(282, 202);
            this.ontslagBtn.Name = "ontslagBtn";
            this.ontslagBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ontslagBtn.Size = new System.Drawing.Size(135, 35);
            this.ontslagBtn.TabIndex = 4;
            this.ontslagBtn.Text = "Verwijdering";
            this.ontslagBtn.UseVisualStyleBackColor = false;
            this.ontslagBtn.Click += new System.EventHandler(this.ontslagBtn_Click);
            // 
            // StaffPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.ontslagBtn);
            this.Controls.Add(this.labelBG);
            this.Controls.Add(this.labelERole);
            this.Controls.Add(this.labelEId);
            this.Controls.Add(this.labelEName);
            this.Name = "StaffPopup";
            this.Text = "PersoneelPopup";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PersoneelPopup_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelEName;
        private System.Windows.Forms.Label labelEId;
        private System.Windows.Forms.Label labelERole;
        private System.Windows.Forms.Label labelBG;
        private System.Windows.Forms.Button ontslagBtn;
    }
}