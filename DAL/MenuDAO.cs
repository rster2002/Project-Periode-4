using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class MenuDAO : SQLInterface<Menu> {

        public List<Menu> getAll() {
            Line("SELECT *");
            Line("FROM [Menu]");

            return Execute();
        }
        public Menu getById(int id) {
            Line("SELECT *");
            Line("FROM [Menu]");
            Line("WHERE [MenuId] = @id");

            Param("id", id);

            return Execute()[0];
        }
        protected override Menu ProcessRecord(Record record) {
            return new Menu() {
                id = (int) record["MenuId"],
                name = (string) record["MenuName"],
                startTime = (TimeSpan) record["MenuAvailableStartDateTime"],
                endTime = (TimeSpan) record["MenuAvailableEndDateTime"]
            };
        }
    }
}
