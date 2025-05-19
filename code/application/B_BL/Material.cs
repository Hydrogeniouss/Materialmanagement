using application.C_DAL;

namespace application.B_BL
{
    internal class Material : MaterialData
    {
        public Material(int id, string name, string description, int quantityTotal, int quantityAvailable, string brand, string type, string? img_filepath)
            : base(id, name, description, quantityTotal, quantityAvailable, brand, type, img_filepath)
        {
        }

        static new List<Material> FromDatabase()
        {
            return MaterialData.FromDatabase()
            .Select(x => new Material(x.Id, x.Name, x.Description, x.Amount_total, x.Amount_available, x.Brand, x.Type, x.ImageFilepath))
            .ToList();
        }
    }
}
