namespace UI.DesktopViews {
    partial class OrderBarView {
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
            this.orderBarOverviewLayout = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderBarOverviewLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderBarOverviewLayout
            // 
            this.orderBarOverviewLayout.ColumnCount = 4;
            this.orderBarOverviewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.orderBarOverviewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.orderBarOverviewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.orderBarOverviewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.orderBarOverviewLayout.Controls.Add(this.groupBox1, 0, 0);
            this.orderBarOverviewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderBarOverviewLayout.Location = new System.Drawing.Point(0, 0);
            this.orderBarOverviewLayout.Name = "orderBarOverviewLayout";
            this.orderBarOverviewLayout.RowCount = 2;
            this.orderBarOverviewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.orderBarOverviewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.orderBarOverviewLayout.Size = new System.Drawing.Size(1904, 982);
            this.orderBarOverviewLayout.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // OrderBarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderBarOverviewLayout);
            this.Name = "OrderBarView";
            this.Size = new System.Drawing.Size(1904, 982);
            this.orderBarOverviewLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel orderBarOverviewLayout;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
