using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Model {
    public class StaffService {
        private StaffDAO staffDAO = new StaffDAO();

        public List<Staff> GetAllStaff() => staffDAO.GetAll();
        public Staff GetStaffById(int staffId) => staffDAO.GetById(staffId);
        public List<Staff> GetStaffByRole(string role) => staffDAO.GetStaffByRole(role);

        public bool DeleteStaffById(int id) {
            try {
                staffDAO.RemoveStaffById(id);
                return true;
            } catch {
                return false;
            }

        }

        public bool AddStaffMember(string name, string role, int salt, string pass) {
            try {
                staffDAO.AddStaffMember(name, role, salt, pass);
                return true;
            } catch (Exception e) {
                return false;
            }
        }
    }
}

