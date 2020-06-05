using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItemService
    {
        MenuItemDAO menuItemDAO = new MenuItemDAO();

        public List<MenuItem> GetMenuItems() => menuItemDAO.GetAll();
        public List<MenuItem> GetDrinks() => menuItemDAO.GetDrinks();
        public void UpdateStock(List<MenuItem> menuItems) => menuItemDAO.ApplyMenuItemsToStock(menuItems);
    }
}
