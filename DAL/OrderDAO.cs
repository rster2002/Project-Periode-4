using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public class OrderDAO:SQLInterface<Order> {
        protected override Order processRecord(Record record) {
            return new Order() {
                id = (int) record["OrderId"],
            };
        }
    }
}
