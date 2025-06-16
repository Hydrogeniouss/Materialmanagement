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

        public static new Admin FromDatabase(string firstName, string lastName)
        {
            AdminData ad = AdminData.FromDatabase(firstName, lastName);
            return new Admin(ad.FirstName, ad.LastName, ad.Email, ad.Phone, ad.Password, ad.Id);
        }

        public static long InsertIntoDatabase(Admin ad)
        {
            return ad.InsertIntoDatabase();
        }
    }
}
