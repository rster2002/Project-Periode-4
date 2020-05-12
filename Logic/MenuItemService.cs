using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MenuItemService
    {
        MenuItemDAO menuItemDAO = new MenuItemDAO();

        public List<MenuItem> GetMenuItems() {
            try {
                List<MenuItem> menuItems = menuItemDAO.getAll();
                return menuItems;
            }
            catch(Exception) {
                List<MenuItem> menuItems = new List<MenuItem>();
                MenuItem menuItem1 = new MenuItem() {
                    Id = 1,
                    Name = "Patat",
                    Price = 2.50m,
                    VAT = 9,
                    AmountInStock = 26
                };
                MenuItem menuItem2 = new MenuItem() {
                    Id = 2,
                    Name = "pizza",
                    Price = 13.75m,
                    VAT = 9,
                    AmountInStock = 19
                };
                menuItems.AddRange(new MenuItem[] { menuItem1, menuItem2 });
                return menuItems;
            }
        }
    }
}
