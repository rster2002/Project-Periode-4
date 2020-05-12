﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL {
    public class MenuDAO : SQLInterface<Menu> {

        public List<Menu> getAll() {
            Line("SELECT *");
            Line("FROM [Menu]");

            return Execute();
        }
        public Menu getById(int id) {
            Line("SELECT *");
            Line("FROM [Menu]");
            Line("WHERE [MenuId] = @id");

            Param("id", id);

            return Execute()[0];
        }
        protected override Menu ProcessRecord(Record record) {
            return new Menu() {
                Id = (int) record["MenuId"],
                Name = (string) record["MenuName"],
                StartTime = (TimeSpan) record["MenuAvailableStartDateTime"],
                EndTime = (TimeSpan) record["MenuAvailableEndDateTime"]
            };
        }
    }
}
