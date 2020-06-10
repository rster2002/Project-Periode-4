namespace UI.DesktopViews {
    partial class AddMenuForm {
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
            this.LblStartTime = new System.Windows.Forms.Label();
            this.LblEndTime = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.TimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.BtnAddMenu = new System.Windows.Forms.Button();
            this.LblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(182, 47);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(64, 25);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Naam";
            // 
            // LblStartTime
            // 
            this.LblStartTime.AutoSize = true;
            this.LblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartTime.Location = new System.Drawing.Point(73, 114);
            this.LblStartTime.Name = "LblStartTime";
            this.LblStartTime.Size = new System.Drawing.Size(173, 25);
            this.LblStartTime.TabIndex = 1;
            this.LblStartTime.Text = "Beschikbaar vanaf";
            // 
            // LblEndTime
            // 
            this.LblEndTime.AutoSize = true;
            this.LblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndTime.Location = new System.Drawing.Point(100, 183);
            this.LblEndTime.Name = "LblEndTime";
            this.LblEndTime.Size = new System.Drawing.Size(146, 25);
            this.LblEndTime.TabIndex = 2;
            this.LblEndTime.Text = "Beschikbaar tot";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(304, 52);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(205, 20);
            this.TextBoxName.TabIndex = 3;
            // 
            // TimePickerStart
            // 
            this.TimePickerStart.CustomFormat = "";
            this.TimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerStart.Location = new System.Drawing.Point(304, 118);
            this.TimePickerStart.Name = "TimePickerStart";
            this.TimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.TimePickerStart.TabIndex = 4;
            // 
            // TimePickerEnd
            // 
            this.TimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerEnd.Location = new System.Drawing.Point(304, 187);
            this.TimePickerEnd.Name = "TimePickerEnd";
            this.TimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.TimePickerEnd.TabIndex = 5;
            // 
            // BtnAddMenu
            // 
            this.BtnAddMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(6)))));
            this.BtnAddMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddMenu.Location = new System.Drawing.Point(148, 278);
            this.BtnAddMenu.Name = "BtnAddMenu";
            this.BtnAddMenu.Size = new System.Drawing.Size(371, 40);
            this.BtnAddMenu.TabIndex = 6;
            this.BtnAddMenu.Text = "Toevoegen menu";
            this.BtnAddMenu.UseVisualStyleBackColor = false;
            this.BtnAddMenu.Click += new System.EventHandler(this.BtnAddMenu_Click);
            // 
            // LblWarning
            // 
            this.LblWarning.AutoSize = true;
            this.LblWarning.ForeColor = System.Drawing.Color.Red;
            this.LblWarning.Location = new System.Drawing.Point(145, 248);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Size = new System.Drawing.Size(0, 13);
            this.LblWarning.TabIndex = 7;
            // 
            // AddMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 351);
            this.Controls.Add(this.LblWarning);
            this.Controls.Add(this.BtnAddMenu);
            this.Controls.Add(this.TimePickerEnd);
            this.Controls.Add(this.TimePickerStart);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LblEndTime);
            this.Controls.Add(this.LblStartTime);
            this.Controls.Add(this.LblName);
            this.Name = "AddMenuForm";
            this.Text = "AddMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblStartTime;
        private System.Windows.Forms.Label LblEndTime;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.DateTimePicker TimePickerStart;
        private System.Windows.Forms.DateTimePicker TimePickerEnd;
        private System.Windows.Forms.Button BtnAddMenu;
        private System.Windows.Forms.Label LblWarning;
    }
}