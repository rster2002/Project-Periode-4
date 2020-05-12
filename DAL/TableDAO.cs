using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace DAL {
    public class TableDAO: SQLInterface<Table> {
        protected override Table ProcessRecord(Record record) {
            return new Table() {
                Number = (int) record["TableNumber"],
                NumberOfSeats = (int) record["TableSeats"],
                ServedBy = (Staff) record["ServedBy"]
            };
        }
        public override List<Table> GetAll() {
            Line("SELECT TableNumber, TableSeats, ServedBy");
            Line("FROM [Table]");

            return Execute();
        }
        public override Table GetById(int id) {
            Line("SELECT TableNumber, TableSeats, ServedBy");
            Line("FROM [Table]");
            Line("WHERE [TableNumber] = @id");

            Param("id", id);

            return Execute()[0];
        }
        public List<Table> GetByStaff(int id) {
            Line("SELECT TableNumber, TableSeats, ServedBy");
            Line("FROM [Table]");
            Line("WHERE [ServedBy] = @id");

            Param("id", id);

            return Execute();
        }
    }
}
