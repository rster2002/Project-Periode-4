namespace UI.MobileViews {
    partial class CheckoutView {
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
            this.menuItemsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VATListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.startPaymentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentMethodDialog = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItemsList
            // 
            this.menuItemsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.menuItemsList.HideSelection = false;
            this.menuItemsList.Location = new System.Drawing.Point(3, 3);
            this.menuItemsList.Name = "menuItemsList";
            this.menuItemsList.Size = new System.Drawing.Size(392, 307);
            this.menuItemsList.TabIndex = 0;
            this.menuItemsList.UseCompatibleStateImageBehavior = false;
            this.menuItemsList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gerecht";
            this.columnHeader1.Width = 233;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aantal";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prijs";
            // 
            // VATListView
            // 
            this.VATListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6});
            this.VATListView.HideSelection = false;
            this.VATListView.Location = new System.Drawing.Point(3, 430);
            this.VATListView.Name = "VATListView";
            this.VATListView.Size = new System.Drawing.Size(392, 107);
            this.VATListView.TabIndex = 1;
            this.VATListView.UseCompatibleStateImageBehavior = false;
            this.VATListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            this.columnHeader4.Width = 283;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "";
            this.columnHeader6.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "BTW-specificatie";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(3, 579);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(392, 26);
            this.numericUpDown1.TabIndex = 4;
            // 
            // startPaymentButton
            // 
            this.startPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(6)))));
            this.startPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startPaymentButton.Location = new System.Drawing.Point(3, 611);
            this.startPaymentButton.Name = "startPaymentButton";
            this.startPaymentButton.Size = new System.Drawing.Size(392, 35);
            this.startPaymentButton.TabIndex = 5;
            this.startPaymentButton.Text = "Betaal";
            this.startPaymentButton.UseVisualStyleBackColor = false;
            this.startPaymentButton.Click += new System.EventHandler(this.StartPaymentButtonOnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fooi";
            // 
            // paymentMethodDialog
            // 
            this.paymentMethodDialog.Location = new System.Drawing.Point(401, 3);
            this.paymentMethodDialog.Name = "paymentMethodDialog";
            this.paymentMethodDialog.Size = new System.Drawing.Size(398, 649);
            this.paymentMethodDialog.TabIndex = 7;
            this.paymentMethodDialog.Visible = false;
            // 
            // CheckoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paymentMethodDialog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startPaymentButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VATListView);
            this.Controls.Add(this.menuItemsList);
            this.Name = "CheckoutView";
            this.Size = new System.Drawing.Size(805, 649);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView menuItemsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView VATListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button startPaymentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel paymentMethodDialog;
    }
}
