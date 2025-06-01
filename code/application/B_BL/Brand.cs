using application.C_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.B_BL
{
    public class Brand : BrandData
    {
        public Brand(string name, int? id = null)
            : base(name, id)
        {
        }

        static new List<Brand> FromDatabase()
        {
            return BrandData.FromDatabase()
                .Select(x => new Brand(x.Name, x.Id))
                .ToList();
        }
    }
}
