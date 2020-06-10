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

        #region Create
        public void Insert(string name, decimal price, int VAT, int inStock, string type, string subtype) {
            Line("INSERT INTO [MenuItem]");
            Line("VALUES (@name, @price, @VAT, @inStock, @type, @subtype)");

            Param("name", name);
            Param("inStock", inStock);
            Param("price", price);
            Param("VAT", VAT);
            Param("type", type);
            Param("subtype", subtype);

            Execute();
        }
        #endregion Create

        #region Read
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

        public List<MenuItem> OrderByStock() {
            BasicSelect();
            Line("ORDER BY InStock");

            return Execute();
        }
        #endregion Read

        #region Update
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
        #endregion Update

        protected override MenuItem ProcessRecord(Record record) {
            MenuItem item = new MenuItem() {
                Id = (int) record["MenuItemId"],
                Name = (string) record["MenuItemName"],
                Price = (decimal) record["Price"],
                VAT = (int) record["VAT"],
                AmountInStock = (int) record["InStock"],
                Type = (string) record["Type"],
                Subtype = (string) record["SubType"],
                Comment = null,
            };

            if (record.ContainsKey("Comment")) {
                item.Comment = record["Comment"] != DBNull.Value ? (string) record["Comment"] : null;
            }

            return item;
        }
    }
}
