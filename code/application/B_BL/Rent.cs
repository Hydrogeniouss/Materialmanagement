using application.C_DAL;

namespace application.B_BL
{
    public class Rent : RentData
    {
        public Rent(int quantity, DateTime dateOfAquisition, DateTime? dateOfRetunal = null, int? userId = null, int? materialId = null)
            : base(quantity, dateOfAquisition, dateOfRetunal, userId, materialId)
        {
        }

        public static new List<Rent> FromDatabase(bool isOnlyRented = false)
        {
            return RentData.FromDatabase(isOnlyRented)
                .Select(x => new Rent(x.Quantity, x.DateOfAquisition, x.DateOfReturnal, x.UserId, x.MaterialId))
                .ToList();
        }
        public static new List<Rent> FromDatabase(bool isOnlyRented = false, int? memberID = null)
        {
            return RentData.FromDatabase(isOnlyRented, memberID)
                .Select(x => new Rent(x.Quantity, x.DateOfAquisition, x.DateOfReturnal, x.UserId, x.MaterialId))
                .ToList();
        }
        public void Return()
        {
            this.DateOfReturnal = DateTime.Now;
            UpdateOnDatabase();
        }
    }
}
