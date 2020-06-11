namespace UI.DesktopViews {
    partial class StockManagementPopup {
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblItemNaam = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAanpassing = new System.Windows.Forms.Label();
            this.amountSelector = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amountSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(486, 189);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRemove.Size = new System.Drawing.Size(135, 35);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Verwijderen";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // lblItemNaam
            // 
            this.lblItemNaam.AutoSize = true;
            this.lblItemNaam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblItemNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblItemNaam.ForeColor = System.Drawing.Color.White;
            this.lblItemNaam.Location = new System.Drawing.Point(42, 26);
            this.lblItemNaam.Name = "lblItemNaam";
            this.lblItemNaam.Size = new System.Drawing.Size(60, 25);
            this.lblItemNaam.TabIndex = 8;
            this.lblItemNaam.Text = "ITEM";
            this.lblItemNaam.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(178, 76);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(389, 35);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Aantal in voorraad: ";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(6)))));
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(121, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(135, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lblAanpassing
            // 
            this.lblAanpassing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblAanpassing.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAanpassing.ForeColor = System.Drawing.Color.White;
            this.lblAanpassing.Location = new System.Drawing.Point(178, 122);
            this.lblAanpassing.Name = "lblAanpassing";
            this.lblAanpassing.Size = new System.Drawing.Size(389, 35);
            this.lblAanpassing.TabIndex = 13;
            this.lblAanpassing.Text = "Aantal aan te passen:";
            this.lblAanpassing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amountSelector
            // 
            this.amountSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.amountSelector.Location = new System.Drawing.Point(518, 125);
            this.amountSelector.Name = "amountSelector";
            this.amountSelector.Size = new System.Drawing.Size(49, 30);
            this.amountSelector.TabIndex = 14;
            this.amountSelector.ValueChanged += new System.EventHandler(this.amountSelector_ValueChanged);
            // 
            // StockManagementPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(727, 241);
            this.Controls.Add(this.amountSelector);
            this.Controls.Add(this.lblAanpassing);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblItemNaam);
            this.Name = "StockManagementPopup";
            this.Text = "StockManagementPopup";
            ((System.ComponentModel.ISupportInitialize)(this.amountSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblItemNaam;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAanpassing;
        private System.Windows.Forms.NumericUpDown amountSelector;
    }
}