using application.C_DAL;

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
