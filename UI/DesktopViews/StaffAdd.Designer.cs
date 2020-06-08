namespace UI {
    partial class StaffAdd {
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
            this.labelBG = new System.Windows.Forms.Label();
            this.labelERole = new System.Windows.Forms.Label();
            this.labelEPass = new System.Windows.Forms.Label();
            this.labelEName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelNotifcation = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBG
            // 
            this.labelBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelBG.ForeColor = System.Drawing.Color.White;
            this.labelBG.Location = new System.Drawing.Point(43, 28);
            this.labelBG.Name = "labelBG";
            this.labelBG.Size = new System.Drawing.Size(532, 35);
            this.labelBG.TabIndex = 7;
            this.labelBG.Text = "Nieuwe Medewerker";
            // 
            // labelERole
            // 
            this.labelERole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelERole.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelERole.ForeColor = System.Drawing.Color.White;
            this.labelERole.Location = new System.Drawing.Point(43, 156);
            this.labelERole.Name = "labelERole";
            this.labelERole.Size = new System.Drawing.Size(125, 35);
            this.labelERole.TabIndex = 6;
            this.labelERole.Text = "Functie: ";
            this.labelERole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEPass
            // 
            this.labelEPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelEPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelEPass.ForeColor = System.Drawing.Color.White;
            this.labelEPass.Location = new System.Drawing.Point(43, 116);
            this.labelEPass.Name = "labelEPass";
            this.labelEPass.Size = new System.Drawing.Size(125, 35);
            this.labelEPass.TabIndex = 5;
            this.labelEPass.Text = "Paswoord:";
            this.labelEPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEName
            // 
            this.labelEName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelEName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelEName.ForeColor = System.Drawing.Color.White;
            this.labelEName.Location = new System.Drawing.Point(43, 75);
            this.labelEName.Name = "labelEName";
            this.labelEName.Size = new System.Drawing.Size(125, 35);
            this.labelEName.TabIndex = 4;
            this.labelEName.Text = "Naam: ";
            this.labelEName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBoxName.Location = new System.Drawing.Point(174, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(401, 35);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBoxPass.Location = new System.Drawing.Point(174, 116);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(260, 35);
            this.textBoxPass.TabIndex = 9;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBoxRole.Location = new System.Drawing.Point(174, 156);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(137, 35);
            this.textBoxRole.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(500, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Voeg Toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelNotifcation
            // 
            this.labelNotifcation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelNotifcation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNotifcation.ForeColor = System.Drawing.Color.White;
            this.labelNotifcation.Location = new System.Drawing.Point(44, 204);
            this.labelNotifcation.Name = "labelNotifcation";
            this.labelNotifcation.Size = new System.Drawing.Size(531, 44);
            this.labelNotifcation.TabIndex = 12;
            this.labelNotifcation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(43, 261);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PersoneelAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(623, 306);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelNotifcation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelBG);
            this.Controls.Add(this.labelERole);
            this.Controls.Add(this.labelEPass);
            this.Controls.Add(this.labelEName);
            this.Name = "PersoneelAdd";
            this.Text = "PersoneelAdd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PersoneelAdd_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBG;
        private System.Windows.Forms.Label labelERole;
        private System.Windows.Forms.Label labelEPass;
        private System.Windows.Forms.Label labelEName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelNotifcation;
        private System.Windows.Forms.Button btnBack;
    }
}