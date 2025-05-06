using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.C_DAL
{
    public class UserData
    {
        public UserData(int id, string firstName, string lastName, string email, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        public int Id { get; }
        public string FirstName { get; } = string.Empty;
        public string LastName { get; } = string.Empty;
        public string Email { get; } = string.Empty;
        public string Phone { get; } = string.Empty;

    }
}
