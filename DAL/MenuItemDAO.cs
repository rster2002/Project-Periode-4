﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class MenuItemDAO : SQLInterface<MenuItem> {

        public override List<MenuItem> GetAll() {
            Line("SELECT *");
            Line("FROM [MenuItem]");

            return Execute();
        }

        public override MenuItem GetById(int id) {
            Line("SELECT *");
            Line("FROM [MenuItem]");
            Line("WHERE [MenuItemId] = @id");

            Param("id", id);

            return Execute()[0];
        }

        public override MenuItem ProcessRecord(Record record) {
            return new MenuItem() {
                Id = (int) record["MenuItemId"],
                Name = (string) record["MenuItemName"],
                Price = (decimal) record["Price"],
                VAT = (int) record["VAT"],
                AmountInStock = (int) record["InStock"]
            };
        }
    }
}
