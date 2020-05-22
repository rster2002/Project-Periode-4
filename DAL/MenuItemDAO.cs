using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class MenuItemDAO : SQLInterface<MenuItem> {

        public override List<MenuItem> GetAll() {
            Line("SELECT *");
            Line("FROM [MenuItem]");

            return Execute();
        }

        public override MenuItem GetById(int id) {
            Line("SELECT *");
            Line("FROM [MenuItem]");
            Line("WHERE [MenuItemId] = @id");

            Param("id", id);

            return Execute()[0];
        }

        protected override MenuItem ProcessRecord(Record record) {
            return new MenuItem() {
                Id = (int) record["MenuItemId"],
                Name = (string) record["MenuItemName"],
                Price = (decimal) record["Price"],
                VAT = (int) record["VAT"],
                AmountInStock = (int) record["InStock"]
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
