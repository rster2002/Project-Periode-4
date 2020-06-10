namespace UI.DesktopViews {
    partial class TableView {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableView));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelTafel = new System.Windows.Forms.Panel();
            this.staffSelector = new System.Windows.Forms.ComboBox();
            this.btnStaffChange = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBediening = new System.Windows.Forms.Label();
            this.lblPlaatsen = new System.Windows.Forms.Label();
            this.lblNr = new System.Windows.Forms.Label();
            this.panelTafel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Table.png");
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(150, 50);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(1519, 424);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView1_DrawItem);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panelTafel
            // 
            this.panelTafel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelTafel.Controls.Add(this.staffSelector);
            this.panelTafel.Controls.Add(this.btnStaffChange);
            this.panelTafel.Controls.Add(this.lblStatus);
            this.panelTafel.Controls.Add(this.lblBediening);
            this.panelTafel.Controls.Add(this.lblPlaatsen);
            this.panelTafel.Controls.Add(this.lblNr);
            this.panelTafel.Location = new System.Drawing.Point(444, 500);
            this.panelTafel.Name = "panelTafel";
            this.panelTafel.Size = new System.Drawing.Size(1016, 313);
            this.panelTafel.TabIndex = 1;
            // 
            // staffSelector
            // 
            this.staffSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.staffSelector.FormattingEnabled = true;
            this.staffSelector.Location = new System.Drawing.Point(755, 77);
            this.staffSelector.Name = "staffSelector";
            this.staffSelector.Size = new System.Drawing.Size(243, 33);
            this.staffSelector.TabIndex = 7;
            // 
            // btnStaffChange
            // 
            this.btnStaffChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnStaffChange.Location = new System.Drawing.Point(755, 19);
            this.btnStaffChange.Name = "btnStaffChange";
            this.btnStaffChange.Size = new System.Drawing.Size(243, 62);
            this.btnStaffChange.TabIndex = 6;
            this.btnStaffChange.Text = "Toewijzen medewerker";
            this.btnStaffChange.UseVisualStyleBackColor = true;
            this.btnStaffChange.Click += new System.EventHandler(this.btnStaffChange_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(43, 91);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(155, 46);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status: ";
            // 
            // lblBediening
            // 
            this.lblBediening.AutoSize = true;
            this.lblBediening.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblBediening.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblBediening.ForeColor = System.Drawing.Color.White;
            this.lblBediening.Location = new System.Drawing.Point(43, 163);
            this.lblBediening.Name = "lblBediening";
            this.lblBediening.Size = new System.Drawing.Size(201, 46);
            this.lblBediening.TabIndex = 4;
            this.lblBediening.Text = "Bediener: ";
            // 
            // lblPlaatsen
            // 
            this.lblPlaatsen.AutoSize = true;
            this.lblPlaatsen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblPlaatsen.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblPlaatsen.ForeColor = System.Drawing.Color.White;
            this.lblPlaatsen.Location = new System.Drawing.Point(43, 236);
            this.lblPlaatsen.Name = "lblPlaatsen";
            this.lblPlaatsen.Size = new System.Drawing.Size(356, 46);
            this.lblPlaatsen.TabIndex = 3;
            this.lblPlaatsen.Text = "Aantal zitplaatsen: ";
            // 
            // lblNr
            // 
            this.lblNr.AutoSize = true;
            this.lblNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.lblNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblNr.ForeColor = System.Drawing.Color.White;
            this.lblNr.Location = new System.Drawing.Point(43, 19);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(275, 46);
            this.lblNr.TabIndex = 2;
            this.lblNr.Text = "Tafelnummer: ";
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.panelTafel);
            this.Controls.Add(this.listView1);
            this.Name = "TableView";
            this.Size = new System.Drawing.Size(1904, 982);
            this.panelTafel.ResumeLayout(false);
            this.panelTafel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panelTafel;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBediening;
        private System.Windows.Forms.Label lblPlaatsen;
        private System.Windows.Forms.Button btnStaffChange;
        private System.Windows.Forms.ComboBox staffSelector;
    }
}
