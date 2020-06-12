using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace DAL {
    public class TableDAO: SQLInterface<Table> {
        private void BasicSelect() {
            Line("SELECT *, dbo.CheckTableAvailable([Table].[TableNumber]) AS Availability");
            Line("FROM [Table]");
            Line("JOIN [Staff] ON [Table].ServedBy = [Staff].StaffNumber");
        }

        public override List<Table> GetAll() {
            BasicSelect();

            return Execute();
        }

        public override Table GetById(int id) {
            BasicSelect();
            Line("WHERE [TableNumber] = @id");

            Param("id", id);

            return Execute()[0];
        }

        public List<Table> GetByStaff(int id) {
            BasicSelect();
            Line("WHERE [ServedBy] = @id");

            Param("id", id);

            return Execute();
        }

        public void ChangeServingStaff(int id, int tableToChangeNr) {
            Line("UPDATE [Table] SET [ServedBy] = @id WHERE [TableNumber] = @tableNr");

            Param("id", id);
            Param("tableNr", tableToChangeNr);

            ExecuteCommand();
        }

        public bool CheckOrderPresent(int tableNumber) {
            Query(@"SELECT *
            FROM [Order]
            JOIN [Reservation] ON [Order].ReservationId = [Reservation].ReservationId
            WHERE [Reservation].TableNumber = @id AND [Status] = 'open';");

            Param("id", tableNumber);

            List<Record> records = ExecuteUnprocessed();
            return records.Count > 0;
        }

        protected override Table ProcessRecord(Record record) {
            StaffDAO staffDAO = new StaffDAO();

            return new Table() {
                Number = (int) record["TableNumber"],
                NumberOfSeats = (int) record["TableSeats"],
                ServedBy = new Staff() {
                    Name = (string) record["StaffName"],
                    Salt = (int) record["StaffSalt"],
                    Role = (string) record["StaffRole"],
                    Id = (int) record["StaffNumber"],
                },
                Status = (string) record["Availability"],
            };
        }
    }
}
