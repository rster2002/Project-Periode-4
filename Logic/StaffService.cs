using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic {
    public class StaffService {
        private StaffDAO staffDAO = new StaffDAO();

        public List<Staff> GetAllStaff() {
            try {
                List<Staff> staff = staffDAO.GetAll();
                return staff;
            } catch {
                List<Staff> staff = new List<Staff>();
                Staff staffMember = new Staff {
                    Id = 1,
                    Name = "Joe",
                    Role = "Kok",
                    Salt = 11
                };
                staff.Add(staffMember);
                return staff;
            }
        }
        public Staff GetStaffById(int staffId) {
            try {
                Staff staff = staffDAO.GetById(staffId);
                return staff;
            } catch {
                Staff staff = new Staff {
                    Id = 1,
                    Name = "Joe",
                    Role = "Kok",
                    Salt = 11
                };
                return staff;
            }
        }
        public List<Staff> GetStaffByRole(string role) {
            try {
                List<Staff> staff = staffDAO.GetStaffByRole(role);
                return staff;
            } catch {
                List<Staff> staff = new List<Staff>();
                Staff staffMember = new Staff {
                    Id = 1,
                    Name = "Joe",
                    Role = "Kok",
                    Salt = 11
                };
                staff.Add(staffMember);
                return staff;
            };
        }

    }
}

