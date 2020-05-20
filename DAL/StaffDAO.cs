using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class StaffDAO : SQLInterface<Staff> {
        public override List<Staff> GetAll() {
            Line("SELECT *");
            Line("FROM [STAFF]");

            return Execute();
        }

        public override Staff GetById(int id) {
            Line("SELECT *");
            Line("FROM [STAFF]");
            Line("WHERE StaffNumber = @id");

            Param("id", id);

            return Execute()[0];
        }

        public List<Staff> GetStaffByRole(string role) {
            Line("SELECT *");
            Line("FROM [STAFF]");
            Line("WHERE StaffRole IS @role");

            Param("role", role);

            return Execute();
        }

        public override Staff ProcessRecord(Record record) {
            return new Staff() {
                Name = (string) record["StaffName"],
                Salt = (int) record["StaffSalt"],
                Role = (string) record["StaffRole"],
                Id = (int) record["StaffNumber"]
            };
        }
    }
}
