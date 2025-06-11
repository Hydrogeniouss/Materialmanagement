using application.C_DAL;

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
        public override string ToString() => this.Name;

    }
}
