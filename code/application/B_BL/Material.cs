using application.C_DAL;

namespace application.B_BL
{
    public class Material : MaterialData
    {
        public Material(string name, string description, int amountTotal, int amountAvailable, BrandData brand, TypeData type, string? imageFilepath, int? id = null)
            : base(name, description, amountTotal, amountAvailable, brand, type, imageFilepath, id)
        {

        }

        public static new List<Material> FromDatabase(MaterialFilterData? filter = null)
        {
            return MaterialData.FromDatabase(filter)
            .Select(x => new Material(x.Name, x.Description, x.AmountTotal, x.AmountAvailable, x.Brand, x.Type, x.ImageFilepath, x.Id))
            .ToList();
        }

        public static new Material FromDatabase(int id)
        {
            MaterialData md = MaterialData.FromDatabase(id);
            return new Material(md.Name, md.Description, md.AmountTotal, md.AmountAvailable, md.Brand, md.Type, md.ImageFilepath, md.Id);
        }



    }
}
