using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class RegisterDAO : SQLInterface<Register>{

        public List<Register> GetAllRegisters(){

            Line("SELECT *");
            Line("FROM [REGISTER]");

            return Execute();
        }

        public Register GetRegisterById(int id) {

            Line("SELECT *");
            Line("FROM [REGISTER]");
            Line("WHERE RegisterId = @id");

            Param("id", id);

            return Execute()[0];
        }

        protected override Register ProcessRecord(Record record) {
           
            return new Register() {

                Id = (int)record["RegisterId"],
                Name = (string)record["RegisterName"],
                CashBalance = (decimal)record["CashBalance"]
            };
        }
    }
}
