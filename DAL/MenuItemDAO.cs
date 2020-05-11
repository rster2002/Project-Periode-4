using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class MenuItemDAO : SQLInterface<MenuItem> {

        public List<MenuItem> getAll() {
            Line("SELECT *");
            Line("FROM [MenuItem]");

            return Execute();
        }
        public MenuItem getById(int id) {
            Line("SELECT *");
            Line("FROM [MenuItem]");
            Line("WHERE [MenuItemId] = @id");

            Param("id", id);

            return Execute()[0];
        }
        protected override MenuItem ProcessRecord(Record record) {
            return new MenuItem() {
                id = (int) record["MenuItemId"],
                name = (string) record["MenuItemName"],
                price = (decimal) record["price"],
                VAT = (int) record["VAT"],
                amountInStock = (int) record["InStock"]
            };
        }
    }
}
