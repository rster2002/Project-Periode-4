using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class MenuItemDAO : SQLInterface<MenuItem> {

        public List<MenuItem> getAll() {
            line("SELECT *");
            line("FROM [MenuItem]");

            return execute();
        }
        public MenuItem getById(int id) {
            line("SELECT *");
            line("FROM [MenuItem]");
            line("WHERE [MenuItemId] = @id");

            param("id", id);

            return execute()[0];
        }
        protected override MenuItem processRecord(Record record) {
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
