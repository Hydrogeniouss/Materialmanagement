using application.C_DAL;

namespace application.B_BL
{
    public class Admin : AdminData
    {
        public Admin(string firstName, string lastName, string email, string phone, string password, int? id = null)
            : base(firstName, lastName, email, phone, password, id)
        {
        }

        public static new List<Admin> FromDatabase()
        {
            return AdminData.FromDatabase()
                .Select(x => new Admin(x.FirstName, x.LastName, x.Email, x.Phone, x.Password, x.Id))
                .ToList();
        }
    }
}
