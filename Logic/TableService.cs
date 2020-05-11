using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic {
    public class TableService {

        private tableDAO tableDAO = new tableDAO();

        public List<Table> GetAllTables() {
            List<Table> tables = tableDAO.GetAll();
            return tables;
        }
        public Table GetTableById(int tableId) {
            Table table = tableDAO.GetById(tableId);
            return table;
        }
        public List<Table> GetTablesByStaff(int staffId) {
            List<Table> tables = tableDAO.GetByStaff(staffId);
            return tables;
        }
    }
}
