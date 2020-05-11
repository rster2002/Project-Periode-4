using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class RegisterDAO : SQLInterface<Register>{

        public List<Register> GetAllRegisters(){

            line("SELECT *");
            line("FROM [REGISTER]");

            return execute();
        }

        public Register GetRegisterById(int id) {

            line("SELECT *");
            line("FROM [REGISTER]");
            line("WHERE RegisterId = @id");

            param("id", id);

            return execute()[0];
        }

        protected override Register processRecord(Record record) {
           
            return new Register() {

                id = (int)record["RegisterId"],
                name = (string)record["RegisterName"],
                cashBalance = (decimal)record["CashBalance"]
            };
        }
    }
}
