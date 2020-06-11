﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Model {
    public class TableService {
        private TableDAO tableDAO = new TableDAO();
      
        public List<Table> GetAllTables() => tableDAO.GetAll();
        public Table GetTableById(int tableId) => tableDAO.GetById(tableId);
<<<<<<< HEAD
        public List<Table> GetTablesByStaff(int staffId) => tableDAO.GetByStaff(staffId);
        public void ChangeServerOfTable(int serverId, int tableToChangeNr) => tableDAO.ChangeServingStaff(serverId, tableToChangeNr);
=======
        public List<Table> GetTablesByStaff(int staffId) => tableDAO.GetByStaff(staffId);
        public bool CheckOrderPresent(int tableNumber) => tableDAO.CheckOrderPresent(tableNumber);
>>>>>>> Niek
    }
}
