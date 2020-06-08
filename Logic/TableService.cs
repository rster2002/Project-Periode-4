using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Model {
    public class TableService {

        private TableDAO tableDAO = new TableDAO();

        public List<Table> GetAllTables() {
            return tableDAO.GetAll();
        }
        public Table GetTableById(int tableId) {
            return tableDAO.GetById(tableId);
        }
        public List<Table> GetTablesByStaff(int staffId) {
            return tableDAO.GetByStaff(staffId);
        }
    }
}
