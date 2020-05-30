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
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuItemTypeButtons = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(392, 182);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuItemTypeButtons
            // 
            this.menuItemTypeButtons.AutoScroll = true;
            this.menuItemTypeButtons.ColumnCount = 3;
            this.menuItemTypeButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuItemTypeButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuItemTypeButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.menuItemTypeButtons.Location = new System.Drawing.Point(3, 191);
            this.menuItemTypeButtons.Name = "menuItemTypeButtons";
            this.menuItemTypeButtons.RowCount = 2;
            this.menuItemTypeButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuItemTypeButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menuItemTypeButtons.Size = new System.Drawing.Size(392, 193);
            this.menuItemTypeButtons.TabIndex = 1;
            // 
            // TakeOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuItemTypeButtons);
            this.Controls.Add(this.listView1);
            this.Name = "TakeOrderView";
            this.Size = new System.Drawing.Size(398, 649);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TableLayoutPanel menuItemTypeButtons;
    }
}
