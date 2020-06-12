namespace UI.DesktopViews {
    partial class PrepareOrderForm {
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnGereed = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weet je het zeker?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Je gaat de bestelling gereedmelden\r\nen dit kan niet ongedaan worden gemaakt\r\n\r\n";
            // 
            // btnGereed
            // 
            this.btnGereed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(6)))));
            this.btnGereed.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGereed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGereed.Location = new System.Drawing.Point(382, 248);
            this.btnGereed.Name = "btnGereed";
            this.btnGereed.Size = new System.Drawing.Size(135, 43);
            this.btnGereed.TabIndex = 2;
            this.btnGereed.Text = "Gereed";
            this.btnGereed.UseVisualStyleBackColor = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(122, 248);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(135, 43);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "Ga terug";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // PrepareOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 325);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnGereed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PrepareOrderForm";
            this.Text = "PrepareOrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGereed;
        private System.Windows.Forms.Button btnNo;
    }
}