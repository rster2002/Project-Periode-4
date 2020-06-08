using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.Runtime.InteropServices.WindowsRuntime;

namespace UI.DesktopViews {
    public partial class SalesView: UserControl {
        private ReceiptService receiptSercice = new ReceiptService();

        // Set some global styling
        Font font = new Font(FontFamily.GenericSansSerif, 14f, FontStyle.Regular);
        Font columnLabelFont = new Font(FontFamily.GenericSansSerif, 18f, FontStyle.Regular);
        Color textColor = Color.White;
        Color rowBackgroundColor = Color.FromArgb(33, 33, 33);

        // Initialize global numbers
        private int panelLeftOffset;
        private int columnLabelsY;
        private int rowWidth;
        private int rowHeight;
        private int margin;
        private int receiptLabelX;
        private int tipLabelX;
        private int totalPriceLabelX;

        public SalesView() {
            InitializeComponent();

            // Used later when generating the rows and column labels
            panelLeftOffset = salesListPanel.Location.X;
            columnLabelsY = salesListPanel.Location.Y - 50;
            rowWidth = salesListPanel.Size.Width;
            rowHeight = 45;
            margin = 32;
            receiptLabelX = 16;
            tipLabelX = rowWidth - 300;
            totalPriceLabelX = rowWidth - 200;

            PopulateColumnLabels();
            PopulateReceiptList();
        }

        private void DateTimePickerStartOnChange(object sender, EventArgs e) {
            PopulateReceiptList();
        }

        private void DateTimePickerEndOnChange(object sender, EventArgs e) {
            PopulateReceiptList();
        }

        private void PopulateColumnLabels() {
            Label receiptIdLabel = GenerateColumnLabel("Bon Nummer", panelLeftOffset + receiptLabelX);
            Label tipLabel = GenerateColumnLabel("Fooi", panelLeftOffset + tipLabelX);
            Label totalPriceLabel = GenerateColumnLabel("Totaal prijs", panelLeftOffset + totalPriceLabelX);

            Controls.Add(receiptIdLabel);
            Controls.Add(tipLabel);
            Controls.Add(totalPriceLabel);
        }

        private Label GenerateColumnLabel(string text, int xPosition) {
            return new Label() {
                Location = new Point(xPosition, columnLabelsY),
                ForeColor = rowBackgroundColor,
                Font = columnLabelFont,
                AutoSize = true,
                Text = text,
            };
        }

        private void PopulateReceiptList() {
            List<Receipt> receipts = receiptSercice.GetAllReceipts();
            receipts = FilterReceipts(receipts);
            salesListPanel.Controls.Clear();

            for (int i = 0; i < receipts.Count; i++) {
                Receipt receipt = receipts[i];

                salesListPanel.Controls.Add(GenerateReceiptRow(receipt, i));
            }

            decimal totalRevenue = receipts.Sum(receipt => {
                return receipt.Orders.Sum(order => {
                    return order.MenuItems.Sum(menuItem => menuItem.Price);
                });
            });

            totalRevenueLabel.Text = "€ " + totalRevenue.ToString("0.00");
        }

        private List<Receipt> FilterReceipts(List<Receipt> receipts) {
            DateTime minDateTime = dateTimePickerStart.Value;
            DateTime maxDateTime = dateTimePickerEnd.Value;

            return receipts.
                Where(receipt => {
                    return receipt.Orders.All(order => {
                        return order.PlacedAt >= minDateTime && order.PlacedAt <= maxDateTime;
                    });
                })
                .ToList();
        }

        private Panel GenerateReceiptRow(Receipt receipt, int index) {
            int relativeY = index * (rowHeight + margin);

            decimal totalPrice = receipt.Orders.Sum(order => {
                return order.MenuItems.Sum(menuItem => menuItem.Price);
            });

            Panel panel = new Panel() {
                Size = new Size(rowWidth, rowHeight),
                Location = new Point(0, relativeY),
                BackColor = rowBackgroundColor,
            };

            panel.Click += (s, e) => {
                SalePopup salePopup = new SalePopup(receipt);
                salePopup.ShowDialog();
            };

            Label receiptIdLabel = GenerateRowLabel(receipt.Id.ToString(), receiptLabelX);
            Label tipLabel = GenerateRowLabel("€ " + receipt.Tip.ToString("0.00"), tipLabelX);
            Label totalPriceLabel = GenerateRowLabel("€ " + totalPrice.ToString("0.00"), totalPriceLabelX);

            panel.Controls.Add(receiptIdLabel);
            panel.Controls.Add(tipLabel);
            panel.Controls.Add(totalPriceLabel);

            return panel;
        }

        private Label GenerateRowLabel(string text, int xPosition) {
            return new Label() {
                Location = new Point(xPosition, 12),
                ForeColor = textColor,
                Font = font,
                Text = text,
            };
        }
    }
}
