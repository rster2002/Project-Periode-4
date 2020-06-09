using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model {
    public class UserSession {
        private static UserSession instance;
        public Staff LoggedInStaff { get; private set; }

        private UserSession() {
            LoggedInStaff = new Staff() {
                Role = "unauthorized",
            };
        }

        public static UserSession GetInstance() {
            if (instance == null) instance = new UserSession();
            return instance;
        }

        public void SetLoggedInStaff(Staff staff) {
            LoggedInStaff = staff;
        }
    }
}
