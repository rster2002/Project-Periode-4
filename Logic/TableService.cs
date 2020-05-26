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
            try {
                List<Table> tables = tableDAO.GetAll();
                return tables;
            }
            catch {
                List<Table> tables = new List<Table>();
                Table table = new Table {
                    Number = 200,
                    NumberOfSeats = 10,
                    ServedBy = new Staff {
                        Id = 200,
                        Name = "StaffTester"
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
                    Number = 200,
                    NumberOfSeats = 10,
                    ServedBy = new Staff {
                        Id = 200,
                        Name = "StaffTester"
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
                    Number = 200,
                    NumberOfSeats = 10,
                    ServedBy = new Staff {
                        Id = 200,
                        Name = "StaffTester"
                    }
                };
                tables.Add(table);
                return tables;
            }
            
        }
    }
}
