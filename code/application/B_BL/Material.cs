using application.C_DAL;

namespace application.B_BL
{
    internal class Material : MaterialData
    {
        public Material(string name, string description, int quantityTotal, int quantityAvailable, BrandData brand, TypeData type, string? img_filepath, int? id = null)
            : base(name, description, quantityTotal, quantityAvailable, brand, type, img_filepath, id)
        {

        }

        public static new List<Material> FromDatabase()
        {
            return MaterialData.FromDatabase()
            .Select(x => new Material(x.Name, x.Description, x.AmountTotal, x.AmountAvailable, x.Brand, x.Type, x.ImageFilepath, x.Id))
            .ToList();
        }



    }
}
