using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace DAL {
    public class tableDAO:SQLInterface<Table> {
        protected override Table processRecord(Record record) {
            return new Table() {
                number = (int) record["TableNumber"],
                numberOfSeats = (int) record["TableSeats"],
                servedBy = (Staff) record["ServedBy"]
            };
        }
        public List<Table> GetAll() {
            line("SELECT TableNumber, TableSeats, ServedBy");
            line("FROM [Table]");

            return execute();
        }
        public Table GetById(int id) {
            line("SELECT TableNumber, TableSeats, ServedBy");
            line("FROM [Table]");
            line("WHERE [TableNumber] = @id");

            param("id", id);

            return execute()[0];
        }
        public List<Table> GetByStaff(int id) {
            line("SELECT TableNumber, TableSeats, ServedBy");
            line("FROM [Table]");
            line("WHERE [ServedBy] = @id");

            param("id", id);

            return execute();
        }
    }
}
