using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Security.Cryptography;

namespace DAL {
    public class StaffDAO : SQLInterface<Staff> {
        SHA256 sha = SHA256.Create();
        Encoding enc = Encoding.UTF8;

        public string HashString(string toHash) {
            StringBuilder stringBuilder = new StringBuilder();
            Byte[] result = sha.ComputeHash(enc.GetBytes(toHash));
            foreach (Byte bt in result) {
                stringBuilder.Append(bt.ToString("x2"));
            }
            return stringBuilder.ToString();
        }
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

            List<Staff> staffList = Execute();
            return staffList.Count > 0 ? staffList[0] : null;
        }

        public List<Staff> GetStaffByRole(string role) {
            Line("SELECT *");
            Line("FROM [STAFF]");
            Line("WHERE StaffRole IS @role");

            Param("role", role);

            return Execute();
        }

        public void RemoveStaffById(int id) {
            Line("DELETE FROM Staff");
            Line("WHERE StaffNumber = @id");
            
            Param("id", id);

            ExecuteCommand();
        }

        public void AddStaffMember(string name, string role, int salt, string pass) {
            Line("INSERT INTO Staff (StaffName, StaffRole, StaffSalt, StaffHash)");
            Line("VALUES (@name, @role, @salt, @hash)");

            Param("name", name);
            Param("role", role);
            Param("salt", salt);
            Param("hash", HashString(pass + salt.ToString()));

            ExecuteCommand();
        }

        protected override Staff ProcessRecord(Record record) {
            return new Staff() {
                Name = (string) record["StaffName"],
                Salt = (int) record["StaffSalt"],
                Role = (string) record["StaffRole"],
                Id = (int) record["StaffNumber"],
                Hash = (string) record["StaffHash"]
            };
        }
    }
}
