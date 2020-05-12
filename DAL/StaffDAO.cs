using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class StaffDAO : SQLInterface<Staff> {
        public List<Staff> GetAllStaff() {
            line("SELECT *");
            line("FROM [STAFF]");

            return execute();
        }

        public Staff GetStaffById(int id) {
            line("SELECT *");
            line("FROM [STAFF]");
            line("WHERE StaffNumber = @id");

            param("id", id);

            return execute()[0];
        }

        public List<Staff> GetStaffByRole(string role) {
            line("SELECT *");
            line("FROM [STAFF]");
            line("WHERE StaffRole IS @role");

            param("role", role);

            return execute();
        }

        protected override Staff processRecord(Record record) {
            return new Staff() {
                name = (string) record["StaffName"],
                salt = (int) record["StaffSalt"],
                role = (string) record["StaffRole"],
                id = (int) record["StaffNumber"]
            };
        }
        
    }
}
