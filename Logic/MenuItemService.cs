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
                    id = 1,
                    name = "Patat",
                    price = 2.50m,
                    VAT = 9,
                    amountInStock = 26
                };
                MenuItem menuItem2 = new MenuItem() {
                    id = 2,
                    name = "pizza",
                    price = 13.75m,
                    VAT = 9,
                    amountInStock = 19
                };
                menuItems.AddRange(new MenuItem[] { menuItem1, menuItem2 });
                return menuItems;
            }
        }
    }
}
