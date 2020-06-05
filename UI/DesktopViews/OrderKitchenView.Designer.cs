namespace UI.DesktopViews {
    partial class OrderKitchenView {
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
            this.orderKitchenOverviewLayout = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderKitchenOverviewLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderKitchenOverviewLayout
            // 
            this.orderKitchenOverviewLayout.ColumnCount = 4;
            this.orderKitchenOverviewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.orderKitchenOverviewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.orderKitchenOverviewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.orderKitchenOverviewLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.orderKitchenOverviewLayout.Controls.Add(this.groupBox1, 0, 0);
            this.orderKitchenOverviewLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderKitchenOverviewLayout.Location = new System.Drawing.Point(0, 0);
            this.orderKitchenOverviewLayout.Name = "orderKitchenOverviewLayout";
            this.orderKitchenOverviewLayout.RowCount = 4;
            this.orderKitchenOverviewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.orderKitchenOverviewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.orderKitchenOverviewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.orderKitchenOverviewLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.orderKitchenOverviewLayout.Size = new System.Drawing.Size(1904, 982);
            this.orderKitchenOverviewLayout.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 465);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // OrderKitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderKitchenOverviewLayout);
            this.Name = "OrderKitchenView";
            this.Size = new System.Drawing.Size(1904, 982);
            this.orderKitchenOverviewLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel orderKitchenOverviewLayout;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
