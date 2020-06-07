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
            this.tipNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startPaymentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentMethodDialog = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cashPaymentMethodButton = new System.Windows.Forms.Button();
            this.debitCardPaymentMethodButton = new System.Windows.Forms.Button();
            this.creditCardPaymentMethodButton = new System.Windows.Forms.Button();
            this.confirmPaymentButton = new System.Windows.Forms.Button();
            this.feedbackTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipNumericUpDown)).BeginInit();
            this.paymentMethodDialog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.VATListView.Location = new System.Drawing.Point(3, 344);
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
            this.label1.Location = new System.Drawing.Point(3, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "BTW-specificatie";
            // 
            // tipNumericUpDown
            // 
            this.tipNumericUpDown.DecimalPlaces = 2;
            this.tipNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipNumericUpDown.Location = new System.Drawing.Point(3, 579);
            this.tipNumericUpDown.Name = "tipNumericUpDown";
            this.tipNumericUpDown.Size = new System.Drawing.Size(392, 26);
            this.tipNumericUpDown.TabIndex = 4;
            this.tipNumericUpDown.ValueChanged += new System.EventHandler(this.TipNumericUpDownOnChange);
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
            this.label2.TabIndex = 9;
            this.label2.Text = "Fooi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(3, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Opmerking";
            // 
            // paymentMethodDialog
            // 
            this.paymentMethodDialog.Controls.Add(this.panel1);
            this.paymentMethodDialog.Location = new System.Drawing.Point(401, 3);
            this.paymentMethodDialog.Name = "paymentMethodDialog";
            this.paymentMethodDialog.Size = new System.Drawing.Size(398, 649);
            this.paymentMethodDialog.TabIndex = 7;
            this.paymentMethodDialog.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(76, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 217);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cashPaymentMethodButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.debitCardPaymentMethodButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.creditCardPaymentMethodButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.confirmPaymentButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 217);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cashPaymentMethodButton
            // 
            this.cashPaymentMethodButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashPaymentMethodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashPaymentMethodButton.Location = new System.Drawing.Point(3, 3);
            this.cashPaymentMethodButton.Name = "cashPaymentMethodButton";
            this.cashPaymentMethodButton.Size = new System.Drawing.Size(123, 102);
            this.cashPaymentMethodButton.TabIndex = 0;
            this.cashPaymentMethodButton.Text = "Contant";
            this.cashPaymentMethodButton.UseVisualStyleBackColor = true;
            this.cashPaymentMethodButton.Click += new System.EventHandler(this.CashPaymentMethodButtonOnClick);
            // 
            // debitCardPaymentMethodButton
            // 
            this.debitCardPaymentMethodButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debitCardPaymentMethodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitCardPaymentMethodButton.Location = new System.Drawing.Point(132, 3);
            this.debitCardPaymentMethodButton.Name = "debitCardPaymentMethodButton";
            this.debitCardPaymentMethodButton.Size = new System.Drawing.Size(124, 102);
            this.debitCardPaymentMethodButton.TabIndex = 1;
            this.debitCardPaymentMethodButton.Text = "Pin/debit kaart";
            this.debitCardPaymentMethodButton.UseVisualStyleBackColor = true;
            this.debitCardPaymentMethodButton.Click += new System.EventHandler(this.DebitCardPaymentMethodButtonOnClick);
            // 
            // creditCardPaymentMethodButton
            // 
            this.creditCardPaymentMethodButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditCardPaymentMethodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardPaymentMethodButton.Location = new System.Drawing.Point(3, 111);
            this.creditCardPaymentMethodButton.Name = "creditCardPaymentMethodButton";
            this.creditCardPaymentMethodButton.Size = new System.Drawing.Size(123, 103);
            this.creditCardPaymentMethodButton.TabIndex = 2;
            this.creditCardPaymentMethodButton.Text = "Credit card (VISA/ AMEX)";
            this.creditCardPaymentMethodButton.UseVisualStyleBackColor = true;
            this.creditCardPaymentMethodButton.Click += new System.EventHandler(this.CreditCardPaymentMethodButtonOnClick);
            // 
            // confirmPaymentButton
            // 
            this.confirmPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(6)))));
            this.confirmPaymentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmPaymentButton.Enabled = false;
            this.confirmPaymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPaymentButton.Location = new System.Drawing.Point(132, 111);
            this.confirmPaymentButton.Name = "confirmPaymentButton";
            this.confirmPaymentButton.Size = new System.Drawing.Size(124, 103);
            this.confirmPaymentButton.TabIndex = 3;
            this.confirmPaymentButton.Text = "Reken af";
            this.confirmPaymentButton.UseVisualStyleBackColor = false;
            this.confirmPaymentButton.Click += new System.EventHandler(this.ConfirmPaymentButtonOnClick);
            // 
            // feedbackTextbox
            // 
            this.feedbackTextbox.Location = new System.Drawing.Point(3, 493);
            this.feedbackTextbox.Multiline = true;
            this.feedbackTextbox.Name = "feedbackTextbox";
            this.feedbackTextbox.Size = new System.Drawing.Size(392, 60);
            this.feedbackTextbox.TabIndex = 8;
            // 
            // CheckoutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paymentMethodDialog);
            this.Controls.Add(this.feedbackTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startPaymentButton);
            this.Controls.Add(this.tipNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VATListView);
            this.Controls.Add(this.menuItemsList);
            this.Name = "CheckoutView";
            this.Size = new System.Drawing.Size(805, 649);
            ((System.ComponentModel.ISupportInitialize)(this.tipNumericUpDown)).EndInit();
            this.paymentMethodDialog.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.NumericUpDown tipNumericUpDown;
        private System.Windows.Forms.Button startPaymentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel paymentMethodDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cashPaymentMethodButton;
        private System.Windows.Forms.Button debitCardPaymentMethodButton;
        private System.Windows.Forms.Button creditCardPaymentMethodButton;
        private System.Windows.Forms.Button confirmPaymentButton;
        private System.Windows.Forms.TextBox feedbackTextbox;
        private System.Windows.Forms.Label label3;
    }
}
