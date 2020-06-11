namespace UI.DesktopViews {
    partial class LoginView {
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
            this.btn_login = new System.Windows.Forms.Button();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lbl_gebruiker = new System.Windows.Forms.Label();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.txtb_gebruiker = new System.Windows.Forms.TextBox();
            this.txtb_wachtwoord = new System.Windows.Forms.TextBox();
            this.lbl_geengegevens = new System.Windows.Forms.Label();
            this.Btn_changeView = new System.Windows.Forms.Button();
            this.Cbox_showpassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(6)))));
            this.btn_login.FlatAppearance.BorderSize = 3;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.btn_login.Location = new System.Drawing.Point(819, 537);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(269, 74);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_logo.Image = global::UI.Properties.Resources.chapoo_logo;
            this.pb_logo.Location = new System.Drawing.Point(780, 86);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(343, 219);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 1;
            this.pb_logo.TabStop = false;
            // 
            // lbl_gebruiker
            // 
            this.lbl_gebruiker.AutoSize = true;
            this.lbl_gebruiker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_gebruiker.Location = new System.Drawing.Point(570, 367);
            this.lbl_gebruiker.Name = "lbl_gebruiker";
            this.lbl_gebruiker.Size = new System.Drawing.Size(214, 31);
            this.lbl_gebruiker.TabIndex = 2;
            this.lbl_gebruiker.Text = "Gebruikersnaam";
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_wachtwoord.Location = new System.Drawing.Point(619, 445);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(165, 31);
            this.lbl_wachtwoord.TabIndex = 3;
            this.lbl_wachtwoord.Text = "Wachtwoord";
            // 
            // txtb_gebruiker
            // 
            this.txtb_gebruiker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtb_gebruiker.Location = new System.Drawing.Point(819, 364);
            this.txtb_gebruiker.Name = "txtb_gebruiker";
            this.txtb_gebruiker.Size = new System.Drawing.Size(269, 38);
            this.txtb_gebruiker.TabIndex = 4;
            // 
            // txtb_wachtwoord
            // 
            this.txtb_wachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txtb_wachtwoord.Location = new System.Drawing.Point(819, 442);
            this.txtb_wachtwoord.Name = "txtb_wachtwoord";
            this.txtb_wachtwoord.Size = new System.Drawing.Size(269, 38);
            this.txtb_wachtwoord.TabIndex = 5;
            // 
            // lbl_geengegevens
            // 
            this.lbl_geengegevens.AutoSize = true;
            this.lbl_geengegevens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbl_geengegevens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_geengegevens.Location = new System.Drawing.Point(815, 487);
            this.lbl_geengegevens.Name = "lbl_geengegevens";
            this.lbl_geengegevens.Size = new System.Drawing.Size(0, 20);
            this.lbl_geengegevens.TabIndex = 10;
            // 
            // Btn_changeView
            // 
            this.Btn_changeView.Location = new System.Drawing.Point(1634, 935);
            this.Btn_changeView.Name = "Btn_changeView";
            this.Btn_changeView.Size = new System.Drawing.Size(252, 34);
            this.Btn_changeView.TabIndex = 11;
            this.Btn_changeView.Text = "Change View";
            this.Btn_changeView.UseVisualStyleBackColor = true;
            this.Btn_changeView.Click += new System.EventHandler(this.Btn_changeView_Click);
            // 
            // Cbox_showpassword
            // 
            this.Cbox_showpassword.AutoSize = true;
            this.Cbox_showpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.Cbox_showpassword.Location = new System.Drawing.Point(1110, 452);
            this.Cbox_showpassword.Name = "Cbox_showpassword";
            this.Cbox_showpassword.Size = new System.Drawing.Size(202, 26);
            this.Cbox_showpassword.TabIndex = 12;
            this.Cbox_showpassword.Text = "Laat wachtwoord zien";
            this.Cbox_showpassword.UseVisualStyleBackColor = true;
            this.Cbox_showpassword.CheckedChanged += new System.EventHandler(this.Cbox_showpassword_CheckedChanged);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.Cbox_showpassword);
            this.Controls.Add(this.Btn_changeView);
            this.Controls.Add(this.lbl_geengegevens);
            this.Controls.Add(this.txtb_wachtwoord);
            this.Controls.Add(this.txtb_gebruiker);
            this.Controls.Add(this.lbl_wachtwoord);
            this.Controls.Add(this.lbl_gebruiker);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.btn_login);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(1904, 982);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lbl_gebruiker;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.TextBox txtb_gebruiker;
        private System.Windows.Forms.TextBox txtb_wachtwoord;
        private System.Windows.Forms.Label lbl_geengegevens;
        private System.Windows.Forms.Button Btn_changeView;
        private System.Windows.Forms.CheckBox Cbox_showpassword;
    }
}
