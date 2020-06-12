namespace UI.MobileViews {
    partial class TableControlsView {
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
            this.buttonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.reservationPopupPanel = new System.Windows.Forms.Panel();
            this.closeReservationPopupLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelReserationButton = new System.Windows.Forms.Button();
            this.confirmReservationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxReservationName = new System.Windows.Forms.TextBox();
            this.buttonLayout.SuspendLayout();
            this.reservationPopupPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLayout
            // 
            this.buttonLayout.ColumnCount = 1;
            this.buttonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonLayout.Controls.Add(this.button1, 0, 0);
            this.buttonLayout.Location = new System.Drawing.Point(3, 3);
            this.buttonLayout.Name = "buttonLayout";
            this.buttonLayout.RowCount = 4;
            this.buttonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonLayout.Size = new System.Drawing.Size(392, 643);
            this.buttonLayout.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 154);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // reservationPopupPanel
            // 
            this.reservationPopupPanel.Controls.Add(this.closeReservationPopupLabel);
            this.reservationPopupPanel.Controls.Add(this.panel1);
            this.reservationPopupPanel.Location = new System.Drawing.Point(401, 0);
            this.reservationPopupPanel.Name = "reservationPopupPanel";
            this.reservationPopupPanel.Size = new System.Drawing.Size(398, 649);
            this.reservationPopupPanel.TabIndex = 1;
            // 
            // closeReservationPopupLabel
            // 
            this.closeReservationPopupLabel.AutoSize = true;
            this.closeReservationPopupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeReservationPopupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeReservationPopupLabel.Location = new System.Drawing.Point(351, 19);
            this.closeReservationPopupLabel.Name = "closeReservationPopupLabel";
            this.closeReservationPopupLabel.Size = new System.Drawing.Size(30, 29);
            this.closeReservationPopupLabel.TabIndex = 1;
            this.closeReservationPopupLabel.Text = "X";
            this.closeReservationPopupLabel.Click += new System.EventHandler(this.CloseReservationPopupLabelOnClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cancelReserationButton);
            this.panel1.Controls.Add(this.confirmReservationButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBoxReservationName);
            this.panel1.Location = new System.Drawing.Point(75, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 133);
            this.panel1.TabIndex = 0;
            // 
            // cancelReserationButton
            // 
            this.cancelReserationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelReserationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelReserationButton.ForeColor = System.Drawing.Color.White;
            this.cancelReserationButton.Location = new System.Drawing.Point(7, 79);
            this.cancelReserationButton.Name = "cancelReserationButton";
            this.cancelReserationButton.Size = new System.Drawing.Size(112, 44);
            this.cancelReserationButton.TabIndex = 3;
            this.cancelReserationButton.Text = "Annuleer";
            this.cancelReserationButton.UseVisualStyleBackColor = false;
            this.cancelReserationButton.Click += new System.EventHandler(this.CancelReservationButtonOnClick);
            // 
            // confirmReservationButton
            // 
            this.confirmReservationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(6)))));
            this.confirmReservationButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.confirmReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmReservationButton.Location = new System.Drawing.Point(125, 79);
            this.confirmReservationButton.Name = "confirmReservationButton";
            this.confirmReservationButton.Size = new System.Drawing.Size(125, 44);
            this.confirmReservationButton.TabIndex = 2;
            this.confirmReservationButton.Text = "Reserveer";
            this.confirmReservationButton.UseVisualStyleBackColor = false;
            this.confirmReservationButton.Click += new System.EventHandler(this.ConfirmReservationButtonOnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservering op achternaam";
            // 
            // txtBoxReservationName
            // 
            this.txtBoxReservationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxReservationName.Location = new System.Drawing.Point(7, 47);
            this.txtBoxReservationName.Name = "txtBoxReservationName";
            this.txtBoxReservationName.Size = new System.Drawing.Size(243, 26);
            this.txtBoxReservationName.TabIndex = 0;
            // 
            // TableControlsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reservationPopupPanel);
            this.Controls.Add(this.buttonLayout);
            this.Name = "TableControlsView";
            this.Size = new System.Drawing.Size(802, 649);
            this.buttonLayout.ResumeLayout(false);
            this.reservationPopupPanel.ResumeLayout(false);
            this.reservationPopupPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttonLayout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel reservationPopupPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxReservationName;
        private System.Windows.Forms.Button confirmReservationButton;
        private System.Windows.Forms.Button cancelReserationButton;
        private System.Windows.Forms.Label closeReservationPopupLabel;
    }
}
