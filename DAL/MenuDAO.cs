using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class MenuDAO : SQLInterface<Menu> {

        public override List<Menu> GetAll() {
            Line("SELECT *");
            Line("FROM [Menu]");

            return Execute();
        }
        public override Menu GetById(int id) {
            Line("SELECT *");
            Line("FROM [Menu]");
            Line("WHERE [MenuId] = @id");

            Param("id", id);

            return Execute()[0];
        }
        protected override Menu ProcessRecord(Record record) {
            return new Menu() {
                Id = (int) record["MenuId"],
                Name = (string) record["MenuName"],
                StartTime = (TimeSpan) record["MenuAvailableStartDateTime"],
                EndTime = (TimeSpan) record["MenuAvailableEndDateTime"]
            };
        }
        public override List<Menu> ProcessRecords(List<Record> records) {
            Dictionary<int, Menu> menuMap = new Dictionary<int, Menu>();
            MenuItemDAO menuItemDAO = new MenuItemDAO();

            foreach (Record record in records) {
                int menuId = (int) record["MenuId"];

                // Check whether or not reservation has been processed yet
                if (!menuMap.ContainsKey(menuId)) {
                    Menu menu = ProcessRecord(record);

                    // Because 'ProcessRecords' is public, we can ask other DAO's to process certain records for us
                    menu.Items = menuItemDAO.ProcessRecords(
                        // We only want to process the records that apply to the current rmenu, so we filter out any that don't
                        // match the current menu id
                        records
                            .Where(r => (int) r["MenuId"] == menuId)
                            .ToList()
                    );

                    menuMap[menuId] = menu;
                }
            }

            return menuMap.Values.ToList();
        }
    }
}
