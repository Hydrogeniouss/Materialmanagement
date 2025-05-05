using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.C_DAL
{
    internal class MemberData : UserData
    {
        public MemberData(int id, string firstName, string lastName, string email, string phone, int pin) : base(id, firstName, lastName, email, phone)
        {
            Pin = pin;
        }

        public int Pin { get; }
    }
}
