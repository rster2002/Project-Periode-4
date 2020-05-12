using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic {
    public class MenuService {

        MenuDAO menuDAO = new MenuDAO();

        public List<Menu> GetMenus() {
            try {
                List<Menu> menus = menuDAO.getAll();
                return menus;
            }

            catch(Exception) {
                List<Menu> menus = new List<Menu>();

                Menu menu1 = new Menu() {
                    Id = 1,
                    Name = "Special Menu",
                    StartTime = new TimeSpan(12, 0, 0),
                    EndTime = new TimeSpan(22,30,0)
                };
                Menu menu2 = new Menu() {
                    Id = 2,
                    Name = "Party Menu",
                    StartTime = new TimeSpan(9, 30, 0),
                    EndTime = new TimeSpan(22, 15, 0)
                };
                menus.AddRange(new Menu[] { menu1, menu2 });
                return menus;
            }
        }
    }
}
