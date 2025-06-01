using application.C_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.B_BL
{
    public class Type : TypeData
    {
        public Type(string name, int? id = null)
            : base(name, id)
        {
        }

        static new List<Type> FromDatabase()
        {
            return TypeData.FromDatabase()
                .Select(x => new Type(x.Name, x.Id))
                .ToList();
        }
    }
}
