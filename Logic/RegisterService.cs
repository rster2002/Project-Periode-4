using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace Logic {
    public class RegisterService {

        RegisterDAO registerDAO = new RegisterDAO();

        public List<Register> GetAllRegisters() => registerDAO.GetAll();
        public Register GetRegisterById(int id) => registerDAO.GetById(id);
    }
}
