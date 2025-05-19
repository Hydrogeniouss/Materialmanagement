using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.C_DAL
{
    public class BrandData
    {
        public BrandData(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        internal static BrandData FromDatabase(int id)
        {
            throw new NotImplementedException();
        }
    }
}
