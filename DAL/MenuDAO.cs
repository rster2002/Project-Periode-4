using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class MenuDAO: SQLInterface<Menu> {
        private void BasicSelect() {
            Query(@"SELECT *
            FROM[Menu]
            OUTER APPLY(
                SELECT[MenuItem].MenuItemId, MenuItemName, Price, VAT, InStock, [Type], SubType
                FROM[ItemOnMenu]
                JOIN[MenuItem] ON[ItemOnMenu].MenuItemId = [MenuItem].MenuItemId
                WHERE[ItemOnMenu].MenuId = [Menu].MenuId
            ) AS MenuItemSelect");
        }

        #region Create
        public void Insert(int id, string menuName, TimeSpan startTime, TimeSpan endTime) {
            DateTime startDateTime = new DateTime(1990, 1, 1) + startTime;
            DateTime endDateTime = new DateTime(1990, 1, 1) + endTime;

            Line("INSERT INTO [Menu]");
            Line("VALUES (@id, @menuName, @startDateTime, @endDateTime)");

            Param("id", id);
            Param("menuName", menuName);
            Param("startDateTime", startDateTime);
            Param("endDateTime", endDateTime);

            Execute();
        }

        public void AddItemsToMenu(int menuId, List<MenuItem> menuItems) {
            List<string> values = new List<string>();

            for (int i = 0; i < menuItems.Count; i++) {
                MenuItem menuItem = menuItems[i];
                values.Add($"(@menuId, @menuItemId{i})");

                Param("menuItemId" + i, menuItem.Id);
            }

            Line("INSERT INTO [ItemOnMenu]");
            Line($"VALUES {String.Join(", ", values)}");

            Param("menuId", menuId);

            Execute();
        }
        #endregion Create

        #region Read
        public override List<Menu> GetAll() {
            BasicSelect();
            return Execute();
        }

        public override Menu GetById(int id) {
            BasicSelect();
            Line("WHERE [MenuId] = @id");

            Param("id", id);

            return Execute()[0];
        }
        #endregion Read

        #region Delete
        public void DeleteById(int id) {
            Line("DELETE [Menu]");
            Line("WHERE [MenuId] = @id");

            Param("id", id);

            Execute();
        }
        #endregion Delete

        protected override Menu ProcessRecord(Record record) {
            return new Menu() {
                Id = (int) record["MenuId"],
                Name = (string) record["MenuName"],
                StartTime = ((DateTime) record["MenuAvailableStartDateTime"]).TimeOfDay,
                EndTime = ((DateTime) record["MenuAvailableEndDateTime"]).TimeOfDay
            };
        }

        public override List<Menu> ProcessRecords(List<Record> records) {
            Dictionary<int, Menu> menuMap = new Dictionary<int, Menu>();
            MenuItemDAO menuItemDAO = new MenuItemDAO();

            foreach (Record record in records) {
                int menuId = (int) record["MenuId"];

                // Check whether or not menu has been processed yet
                if (!menuMap.ContainsKey(menuId)) {
                    Menu menu = ProcessRecord(record);

                    if (record["MenuItemId"] == DBNull.Value) {
                        menu.Items = new List<MenuItem>();
                    } else {
                        // Because 'ProcessRecords' is public, we can ask other DAO's to process certain records for us
                        menu.Items = menuItemDAO.ProcessRecords(
                            // We only want to process the records that apply to the current menu, so we filter out any that don't
                            // match the current menu id
                            records
                                .Where(r => (int) r["MenuId"] == menuId)
                                .ToList()
                        );
                    }
                    
                    menuMap[menuId] = menu;
                }
            }

            return menuMap.Values.ToList();
        }
    }
}
