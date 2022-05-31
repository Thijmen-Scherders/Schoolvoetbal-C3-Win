using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccDing
{
    public class Accounts
    {

        public void initialize()
        {
        }
        public string name { get; set; }
        public string password { get; set; }

        public string admin { get; set; }
        public string money { get; set; }
        public string email { get; set; }

        public Accounts()
        {
        }

        public Accounts (string name, string password, string admin, string money, string email)
        {
            this.name = name;
            this.password = password;
            this.admin = admin;
            this.money = money;
            this.email = email;
        }

    }
}
