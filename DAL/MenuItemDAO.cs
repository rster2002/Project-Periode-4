using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL {
    public class MenuItemDAO: SQLInterface<MenuItem> {
        private void BasicSelect() {
            Line("SELECT *");
            Line("FROM [MenuItem]");
        }

        public override List<MenuItem> GetAll() {
            BasicSelect();

            return Execute();
        }

        public override MenuItem GetById(int id) {
            BasicSelect();
            Line("WHERE [MenuItemId] = @id");

            Param("id", id);

            return Execute()[0];
        }

        public List<MenuItem> GetDrinks() {
            BasicSelect();
            Line("WHERE [Type] = 'drink'");

            return Execute();
        }

        public void ApplyMenuItemsToStock(List<MenuItem> menuItems) {
            Line("UPDATE [MenuItem]");
            Line("SET [InStock] = CASE");

            for (int i = 0; i < menuItems.Count; i++) {
                MenuItem currentItem = menuItems[i];
                Line($"WHEN [MenuItemId] = @menuItemId{i} THEN [InStock] - @stockChange{i}");

                Param("menuItemId" + i, currentItem.Id);
                Param("stockChange" + i, currentItem.Amount);
            }

            Line("ELSE [InStock] END");

            Execute();
        }

        protected override MenuItem ProcessRecord(Record record) {
            return new MenuItem() {
                Id = (int) record["MenuItemId"],
                Name = (string) record["MenuItemName"],
                Price = (decimal) record["Price"],
                VAT = (int) record["VAT"],
                AmountInStock = (int) record["InStock"],
                Type = (string) record["Type"],
                Subtype = (string) record["SubType"],
                Comment = record["Comment"] != DBNull.Value ? (string) record["Comment"] : null,
            };
        }
    }
}
