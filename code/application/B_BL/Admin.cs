using application.C_DAL;

namespace application.B_BL
{
    internal class Admin : AdminData
    {
        public Admin(int id, string firstName, string lastName, string email, string phone, string password)
            : base(id, firstName, lastName, email, phone, password)
        {
        }

        static new List<Admin> FromDatabase()
        {
            return AdminData.FromDatabase()
            .Select(x => new Admin(x.Id, x.FirstName, x.LastName, x.Email, x.Phone, x.Password))
            .ToList();
        }
    }
}
