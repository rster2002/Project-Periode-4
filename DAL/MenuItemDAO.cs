using Model;
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

        public void InsertMultiple(List<MenuItem> menuItems) {

        }

        protected override MenuItem ProcessRecord(Record record) {
            return new MenuItem() {
                Id = (int) record["MenuItemId"],
                Name = (string) record["MenuItemName"],
                Price = (decimal) record["Price"],
                VAT = (int) record["VAT"],
                AmountInStock = (int) record["InStock"],
                Type = (string) record["Type"],
                Subtype = (string) record["SubType"]
            };
        }

        public override List<MenuItem> ProcessRecords(List<Record> records) {
            Dictionary<int, MenuItem> menuItemMap = new Dictionary<int, MenuItem>();

            foreach (Record record in records) {

                int menuItemId = (int) record["MenuItemId"];

                if (!menuItemMap.ContainsKey(menuItemId)) {
                    MenuItem menuItem = ProcessRecord(record);

                    menuItemMap[menuItemId] = menuItem;
                }
            }

            return menuItemMap.Values.ToList();
        }
    }
}
