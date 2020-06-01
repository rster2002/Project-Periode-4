namespace UI {
    partial class PersoneelView {
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
            this.labelNaam = new System.Windows.Forms.Label();
            this.labelFunctie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNaam
            // 
            this.labelNaam.AutoSize = true;
            this.labelNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelNaam.Location = new System.Drawing.Point(150, 68);
            this.labelNaam.Name = "labelNaam";
            this.labelNaam.Size = new System.Drawing.Size(171, 63);
            this.labelNaam.TabIndex = 0;
            this.labelNaam.Text = "Naam";
            // 
            // labelFunctie
            // 
            this.labelFunctie.AutoSize = true;
            this.labelFunctie.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelFunctie.Location = new System.Drawing.Point(1536, 68);
            this.labelFunctie.Name = "labelFunctie";
            this.labelFunctie.Size = new System.Drawing.Size(205, 63);
            this.labelFunctie.TabIndex = 1;
            this.labelFunctie.Text = "Functie";
            // 
            // PersoneelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.labelFunctie);
            this.Controls.Add(this.labelNaam);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PersoneelView";
            this.Size = new System.Drawing.Size(1904, 982);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaam;
        private System.Windows.Forms.Label labelFunctie;
    }
}
