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
            try {
                List<Table> tables = tableDAO.GetAll();
                return tables;
            }
            catch {
                List<Table> tables = new List<Table>();
                Table table = new Table {
                    number = 200,
                    numberOfSeats = 10,
                    servedBy = new Staff {
                        id = 200,
                        name = "StaffTester"
                    }
                };
                tables.Add(table);
                return tables;
            }
        }
        public Table GetTableById(int tableId) {
            try {
                Table table = tableDAO.GetById(tableId);
                return table;
            }
            catch {
                Table table = new Table {
                    number = 200,
                    numberOfSeats = 10,
                    servedBy = new Staff {
                        id = 200,
                        name = "StaffTester"
                    }
                };
                return table;
            }
        }
        public List<Table> GetTablesByStaff(int staffId) {
            try {
                List<Table> tables = tableDAO.GetByStaff(staffId);
                return tables;
            }
            catch {
                List<Table> tables = new List<Table>();
                Table table = new Table {
                    number = 200,
                    numberOfSeats = 10,
                    servedBy = new Staff {
                        id = 200,
                        name = "StaffTester"
                    }
                };
                tables.Add(table);
                return tables;
            }
            
        }
    }
}
