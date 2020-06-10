﻿using DAL;
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

        #region Create
        public void AddMenuItem(int id, string menuItemName, decimal price, int VAT, int inStock, string type, string subtype) => menuItemDAO.Insert(id, menuItemName, price, VAT, inStock, type, subtype);
        #endregion Create

        #region Read
        public List<MenuItem> GetMenuItems() => menuItemDAO.GetAll();
        public List<MenuItem> GetDrinks() => menuItemDAO.GetDrinks();
        public void UpdateStock(List<MenuItem> menuItems) => menuItemDAO.ApplyMenuItemsToStock(menuItems);
        public List<MenuItem> OrderByStock() => menuItemDAO.OrderByStock();
        #endregion Read

        #region Delete
        public void DeleteMenuItem(int id) => menuItemDAO.DeleteById(id);
        #endregion Delete
    }
}
