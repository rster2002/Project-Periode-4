namespace UI.MobileViews {
    partial class LoginViewMobile {
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
            this.pbox_logo = new System.Windows.Forms.PictureBox();
            this.lbl_gebruiker = new System.Windows.Forms.Label();
            this.txtb_gebruiker = new System.Windows.Forms.TextBox();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.txtb_wachtwoord = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_geengegevens = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_logo
            // 
            this.pbox_logo.Image = global::UI.Properties.Resources.chapoo_logo;
            this.pbox_logo.Location = new System.Drawing.Point(75, 43);
            this.pbox_logo.Name = "pbox_logo";
            this.pbox_logo.Size = new System.Drawing.Size(265, 158);
            this.pbox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_logo.TabIndex = 1;
            this.pbox_logo.TabStop = false;
            // 
            // lbl_gebruiker
            // 
            this.lbl_gebruiker.AutoSize = true;
            this.lbl_gebruiker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbl_gebruiker.Location = new System.Drawing.Point(22, 275);
            this.lbl_gebruiker.Name = "lbl_gebruiker";
            this.lbl_gebruiker.Size = new System.Drawing.Size(170, 25);
            this.lbl_gebruiker.TabIndex = 2;
            this.lbl_gebruiker.Text = "Gebruikersnaam";
            // 
            // txtb_gebruiker
            // 
            this.txtb_gebruiker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtb_gebruiker.Location = new System.Drawing.Point(27, 303);
            this.txtb_gebruiker.Name = "txtb_gebruiker";
            this.txtb_gebruiker.Size = new System.Drawing.Size(337, 31);
            this.txtb_gebruiker.TabIndex = 4;
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbl_wachtwoord.Location = new System.Drawing.Point(22, 363);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(131, 25);
            this.lbl_wachtwoord.TabIndex = 5;
            this.lbl_wachtwoord.Text = "Wachtwoord";
            // 
            // txtb_wachtwoord
            // 
            this.txtb_wachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtb_wachtwoord.Location = new System.Drawing.Point(27, 391);
            this.txtb_wachtwoord.Name = "txtb_wachtwoord";
            this.txtb_wachtwoord.Size = new System.Drawing.Size(337, 31);
            this.txtb_wachtwoord.TabIndex = 6;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(6)))));
            this.btn_login.FlatAppearance.BorderSize = 3;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btn_login.Location = new System.Drawing.Point(109, 527);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(176, 61);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_geengegevens
            // 
            this.lbl_geengegevens.AutoSize = true;
            this.lbl_geengegevens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbl_geengegevens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_geengegevens.Location = new System.Drawing.Point(23, 440);
            this.lbl_geengegevens.Name = "lbl_geengegevens";
            this.lbl_geengegevens.Size = new System.Drawing.Size(37, 20);
            this.lbl_geengegevens.TabIndex = 9;
            this.lbl_geengegevens.Text = "MM";
            // 
            // LoginViewMobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.lbl_geengegevens);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtb_wachtwoord);
            this.Controls.Add(this.lbl_wachtwoord);
            this.Controls.Add(this.txtb_gebruiker);
            this.Controls.Add(this.lbl_gebruiker);
            this.Controls.Add(this.pbox_logo);
            this.Name = "LoginViewMobile";
            this.Size = new System.Drawing.Size(398, 649);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_logo;
        private System.Windows.Forms.Label lbl_gebruiker;
        private System.Windows.Forms.TextBox txtb_gebruiker;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.TextBox txtb_wachtwoord;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_geengegevens;
    }
}
