using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class MenuDAO : SQLInterface<Menu> {

        public List<Menu> getAll() {
            line("SELECT *");
            line("FROM [Menu]");

            return execute();
        }
        public Menu getById(int id) {
            line("SELECT *");
            line("FROM [Menu]");
            line("WHERE [MenuId] = @id");

            param("id", id);

            return execute()[0];
        }
        protected override Menu processRecord(Record record) {
            return new Menu() {
                id = (int) record["MenuId"],
                name = (string) record["MenuName"],
                startTime = (TimeSpan) record["MenuAvailableStartDateTime"],
                endTime = (TimeSpan) record["MenuAvailableEndDateTime"]
            };
        }
    }
}
