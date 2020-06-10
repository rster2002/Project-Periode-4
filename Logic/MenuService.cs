using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class MenuService {
        MenuDAO menuDAO = new MenuDAO();

        #region Create
        public void AddMenu(int id, string menuName, TimeSpan startTime, TimeSpan endTime) => menuDAO.Insert(id, menuName, startTime, endTime);
        public void AddItemToMenu(int menuId, int menuItemId) => menuDAO.AddItemToMenu(menuId, menuItemId);
        #endregion Create

        #region Read
        public List<Menu> GetMenus() => menuDAO.GetAll();
        #endregion Read
    }
}
