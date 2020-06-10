namespace UI.DesktopViews {
    partial class AddMenuItemForm {
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
            this.LblName = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblVAT = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxBTW = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.LblWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(196, 50);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(64, 25);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Naam";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(202, 104);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(49, 25);
            this.LblPrice.TabIndex = 1;
            this.LblPrice.Text = "Prijs";
            // 
            // LblVAT
            // 
            this.LblVAT.AutoSize = true;
            this.LblVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVAT.Location = new System.Drawing.Point(128, 187);
            this.LblVAT.Name = "LblVAT";
            this.LblVAT.Size = new System.Drawing.Size(132, 25);
            this.LblVAT.TabIndex = 2;
            this.LblVAT.Text = "Bevat Alcohol";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.Location = new System.Drawing.Point(83, 243);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(177, 25);
            this.LblStock.TabIndex = 3;
            this.LblStock.Text = "Aantal op voorraad";
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.Location = new System.Drawing.Point(203, 311);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(57, 25);
            this.LblType.TabIndex = 4;
            this.LblType.Text = "Type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBoxBTW
            // 
            this.comboBoxBTW.FormattingEnabled = true;
            this.comboBoxBTW.Items.AddRange(new object[] {
            "Ja",
            "Nee"});
            this.comboBoxBTW.Location = new System.Drawing.Point(348, 187);
            this.comboBoxBTW.Name = "comboBoxBTW";
            this.comboBoxBTW.Size = new System.Drawing.Size(193, 21);
            this.comboBoxBTW.TabIndex = 8;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Hoofdgerecht",
            "Nagerecht",
            "Tussengerecht",
            "Voorgerecht"});
            this.comboBoxType.Location = new System.Drawing.Point(348, 314);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(193, 21);
            this.comboBoxType.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(348, 104);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(193, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Euro";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(348, 247);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(193, 20);
            this.numericUpDown3.TabIndex = 15;
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(6)))));
            this.BtnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddItem.Location = new System.Drawing.Point(234, 398);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(385, 40);
            this.BtnAddItem.TabIndex = 16;
            this.BtnAddItem.Text = "Toevoegen item";
            this.BtnAddItem.UseVisualStyleBackColor = false;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddDish_Click);
            // 
            // LblWarning
            // 
            this.LblWarning.AutoSize = true;
            this.LblWarning.ForeColor = System.Drawing.Color.Red;
            this.LblWarning.Location = new System.Drawing.Point(231, 364);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Size = new System.Drawing.Size(0, 13);
            this.LblWarning.TabIndex = 17;
            // 
            // AddMenuItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblWarning);
            this.Controls.Add(this.BtnAddItem);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxBTW);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.LblVAT);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblName);
            this.Name = "AddMenuItemForm";
            this.Text = "Toevoegen menu item";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblVAT;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxBTW;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.Label LblWarning;
    }
}