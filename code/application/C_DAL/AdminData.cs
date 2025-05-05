using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.C_DAL
{
    internal class AdminData : UserData
    {
        public AdminData(int id, string firstName, string lastName, string email, string phone, string password) : base(id, firstName, lastName, email, phone)
        {
            Password = password;
        }

        public string Password { get; } = string.Empty;
    }
}
