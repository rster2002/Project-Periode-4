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
    }
}

