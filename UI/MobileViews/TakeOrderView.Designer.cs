namespace UI.MobileViews {
    partial class TakeOrderView {
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
            this.orderList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuItemTypeButtons = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.menuItemList = new System.Windows.Forms.TableLayoutPanel();
            this.buttonConfirmOrder = new System.Windows.Forms.Button();
            this.popupDialog = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuItemAmountNumberBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dialogConfirmButton = new System.Windows.Forms.Button();
            this.dialogRemoveButton = new System.Windows.Forms.Button();
            this.commentTextbox = new System.Windows.Forms.TextBox();
            this.dialogTitleLbl = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuItemTypeButtons.SuspendLayout();
            this.popupDialog.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemAmountNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // orderList
            // 
            this.orderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5});
            this.orderList.FullRowSelect = true;
            this.orderList.HideSelection = false;
            this.orderList.Location = new System.Drawing.Point(3, 3);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(392, 182);
            this.orderList.TabIndex = 0;
            this.orderList.UseCompatibleStateImageBehavior = false;
            this.orderList.View = System.Windows.Forms.View.Details;
            this.orderList.SelectedIndexChanged += new System.EventHandler(this.OrderListOnEntrySelect);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gerecht";
            this.columnHeader1.Width = 227;
            // 
            // menuItemTypeButtons
            // 
            this.menuItemTypeButtons.AutoScroll = true;
            this.menuItemTypeButtons.ColumnCount = 3;
            this.menuItemTypeButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuItemTypeButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuItemTypeButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuItemTypeButtons.Controls.Add(this.button1, 0, 0);
            this.menuItemTypeButtons.Location = new System.Drawing.Point(3, 191);
            this.menuItemTypeButtons.Name = "menuItemTypeButtons";
            this.menuItemTypeButtons.RowCount = 2;
            this.menuItemTypeButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuItemTypeButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuItemTypeButtons.Size = new System.Drawing.Size(392, 193);
            this.menuItemTypeButtons.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.White;
            this.categoryLabel.Location = new System.Drawing.Point(2, 397);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(51, 20);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "label1";
            this.categoryLabel.Visible = false;
            // 
            // menuItemList
            // 
            this.menuItemList.ColumnCount = 4;
            this.menuItemList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuItemList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuItemList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuItemList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuItemList.Location = new System.Drawing.Point(6, 429);
            this.menuItemList.Name = "menuItemList";
            this.menuItemList.RowCount = 2;
            this.menuItemList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuItemList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuItemList.Size = new System.Drawing.Size(389, 170);
            this.menuItemList.TabIndex = 3;
            // 
            // buttonConfirmOrder
            // 
            this.buttonConfirmOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(6)))));
            this.buttonConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmOrder.Location = new System.Drawing.Point(6, 605);
            this.buttonConfirmOrder.Name = "buttonConfirmOrder";
            this.buttonConfirmOrder.Size = new System.Drawing.Size(389, 41);
            this.buttonConfirmOrder.TabIndex = 4;
            this.buttonConfirmOrder.Text = "Plaats bestelling";
            this.buttonConfirmOrder.UseVisualStyleBackColor = false;
            this.buttonConfirmOrder.Click += new System.EventHandler(this.ConfirmOrderButtonOnClick);
            // 
            // popupDialog
            // 
            this.popupDialog.BackColor = System.Drawing.Color.Transparent;
            this.popupDialog.Controls.Add(this.panel2);
            this.popupDialog.Location = new System.Drawing.Point(401, 3);
            this.popupDialog.Name = "popupDialog";
            this.popupDialog.Size = new System.Drawing.Size(392, 643);
            this.popupDialog.TabIndex = 5;
            this.popupDialog.Visible = false;
            this.popupDialog.Click += new System.EventHandler(this.PopupDialogOnClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.menuItemAmountNumberBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dialogConfirmButton);
            this.panel2.Controls.Add(this.dialogRemoveButton);
            this.panel2.Controls.Add(this.commentTextbox);
            this.panel2.Controls.Add(this.dialogTitleLbl);
            this.panel2.Location = new System.Drawing.Point(56, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 301);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aantal";
            // 
            // menuItemAmountNumberBox
            // 
            this.menuItemAmountNumberBox.Location = new System.Drawing.Point(18, 65);
            this.menuItemAmountNumberBox.Name = "menuItemAmountNumberBox";
            this.menuItemAmountNumberBox.Size = new System.Drawing.Size(254, 20);
            this.menuItemAmountNumberBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Opmerking";
            // 
            // dialogConfirmButton
            // 
            this.dialogConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(6)))));
            this.dialogConfirmButton.Location = new System.Drawing.Point(150, 251);
            this.dialogConfirmButton.Name = "dialogConfirmButton";
            this.dialogConfirmButton.Size = new System.Drawing.Size(122, 40);
            this.dialogConfirmButton.TabIndex = 3;
            this.dialogConfirmButton.Text = "Sla opmerking op";
            this.dialogConfirmButton.UseVisualStyleBackColor = false;
            this.dialogConfirmButton.Click += new System.EventHandler(this.DialogConfirmButtonOnClick);
            // 
            // dialogRemoveButton
            // 
            this.dialogRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dialogRemoveButton.ForeColor = System.Drawing.Color.White;
            this.dialogRemoveButton.Location = new System.Drawing.Point(18, 251);
            this.dialogRemoveButton.Name = "dialogRemoveButton";
            this.dialogRemoveButton.Size = new System.Drawing.Size(126, 40);
            this.dialogRemoveButton.TabIndex = 2;
            this.dialogRemoveButton.Text = "Verwijder van bestelling";
            this.dialogRemoveButton.UseVisualStyleBackColor = false;
            this.dialogRemoveButton.Click += new System.EventHandler(this.DialogRemoveButtonOnClick);
            // 
            // commentTextbox
            // 
            this.commentTextbox.Location = new System.Drawing.Point(18, 108);
            this.commentTextbox.Multiline = true;
            this.commentTextbox.Name = "commentTextbox";
            this.commentTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.commentTextbox.Size = new System.Drawing.Size(254, 137);
            this.commentTextbox.TabIndex = 1;
            // 
            // dialogTitleLbl
            // 
            this.dialogTitleLbl.AutoSize = true;
            this.dialogTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialogTitleLbl.Location = new System.Drawing.Point(14, 13);
            this.dialogTitleLbl.Name = "dialogTitleLbl";
            this.dialogTitleLbl.Size = new System.Drawing.Size(60, 24);
            this.dialogTitleLbl.TabIndex = 0;
            this.dialogTitleLbl.Text = "label1";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Opmerking";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Aantal";
            // 
            // TakeOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.popupDialog);
            this.Controls.Add(this.buttonConfirmOrder);
            this.Controls.Add(this.menuItemList);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.menuItemTypeButtons);
            this.Controls.Add(this.orderList);
            this.Name = "TakeOrderView";
            this.Size = new System.Drawing.Size(799, 649);
            this.menuItemTypeButtons.ResumeLayout(false);
            this.popupDialog.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemAmountNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView orderList;
        private System.Windows.Forms.TableLayoutPanel menuItemTypeButtons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TableLayoutPanel menuItemList;
        private System.Windows.Forms.Button buttonConfirmOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel popupDialog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dialogTitleLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dialogConfirmButton;
        private System.Windows.Forms.Button dialogRemoveButton;
        private System.Windows.Forms.TextBox commentTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown menuItemAmountNumberBox;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}
