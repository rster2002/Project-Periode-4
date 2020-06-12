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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.splitOrderCheckbox = new System.Windows.Forms.CheckBox();
            this.confirmationDialog = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.backToTablesOverviewButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuItemTypeButtons.SuspendLayout();
            this.popupDialog.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemAmountNumberBox)).BeginInit();
            this.confirmationDialog.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.orderList.Location = new System.Drawing.Point(3, 32);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(392, 153);
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
            // columnHeader4
            // 
            this.columnHeader4.Text = "Opmerking";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Aantal";
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
            this.buttonConfirmOrder.Location = new System.Drawing.Point(150, 605);
            this.buttonConfirmOrder.Name = "buttonConfirmOrder";
            this.buttonConfirmOrder.Size = new System.Drawing.Size(245, 41);
            this.buttonConfirmOrder.TabIndex = 4;
            this.buttonConfirmOrder.Text = "Plaats bestelling";
            this.buttonConfirmOrder.UseVisualStyleBackColor = false;
            this.buttonConfirmOrder.Click += new System.EventHandler(this.PlaceOrderButtonOnClick);
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
            // splitOrderCheckbox
            // 
            this.splitOrderCheckbox.AutoSize = true;
            this.splitOrderCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitOrderCheckbox.Location = new System.Drawing.Point(6, 614);
            this.splitOrderCheckbox.Name = "splitOrderCheckbox";
            this.splitOrderCheckbox.Size = new System.Drawing.Size(138, 24);
            this.splitOrderCheckbox.TabIndex = 6;
            this.splitOrderCheckbox.Text = "Splits bestelling";
            this.splitOrderCheckbox.UseVisualStyleBackColor = true;
            // 
            // confirmationDialog
            // 
            this.confirmationDialog.BackColor = System.Drawing.Color.Transparent;
            this.confirmationDialog.Controls.Add(this.panel3);
            this.confirmationDialog.Location = new System.Drawing.Point(799, 3);
            this.confirmationDialog.Name = "confirmationDialog";
            this.confirmationDialog.Size = new System.Drawing.Size(392, 643);
            this.confirmationDialog.TabIndex = 6;
            this.confirmationDialog.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cancelOrderButton);
            this.panel3.Controls.Add(this.backToTablesOverviewButton);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(61, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 123);
            this.panel3.TabIndex = 0;
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelOrderButton.ForeColor = System.Drawing.Color.White;
            this.cancelOrderButton.Location = new System.Drawing.Point(18, 76);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(126, 40);
            this.cancelOrderButton.TabIndex = 7;
            this.cancelOrderButton.Text = "Terug naar bestelling";
            this.cancelOrderButton.UseVisualStyleBackColor = false;
            this.cancelOrderButton.Click += new System.EventHandler(this.CancelOrderButtonOnClick);
            // 
            // backToTablesOverviewButton
            // 
            this.backToTablesOverviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(6)))));
            this.backToTablesOverviewButton.Location = new System.Drawing.Point(150, 76);
            this.backToTablesOverviewButton.Name = "backToTablesOverviewButton";
            this.backToTablesOverviewButton.Size = new System.Drawing.Size(122, 40);
            this.backToTablesOverviewButton.TabIndex = 3;
            this.backToTablesOverviewButton.Text = "Plaats bestelling";
            this.backToTablesOverviewButton.UseVisualStyleBackColor = false;
            this.backToTablesOverviewButton.Click += new System.EventHandler(this.BackToTablesViewButton);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Plaats bestelling?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Druk op een rij om aan te passen:";
            // 
            // TakeOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmationDialog);
            this.Controls.Add(this.popupDialog);
            this.Controls.Add(this.buttonConfirmOrder);
            this.Controls.Add(this.menuItemList);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.menuItemTypeButtons);
            this.Controls.Add(this.splitOrderCheckbox);
            this.Controls.Add(this.orderList);
            this.Name = "TakeOrderView";
            this.Size = new System.Drawing.Size(1197, 649);
            this.menuItemTypeButtons.ResumeLayout(false);
            this.popupDialog.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuItemAmountNumberBox)).EndInit();
            this.confirmationDialog.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.CheckBox splitOrderCheckbox;
        private System.Windows.Forms.Panel confirmationDialog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button backToTablesOverviewButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Label label3;
    }
}
