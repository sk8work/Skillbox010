using HW1.controllers.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class User : IDBConn, IUserLogin, IUserRegistration
    {
        private string name;
        private string passwd;
        private string role;
    }
}
