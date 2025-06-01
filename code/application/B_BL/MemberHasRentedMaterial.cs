using application.C_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace application.B_BL
{
    public class MemberHasRentedMaterial : MemberHasRentedMaterialData
    {
        public MemberHasRentedMaterial(int quantity, DateTime dateOfAquisition, DateTime? dateOfRetunal = null, int? userId = null, int? materialId = null)
            :base  (quantity, dateOfAquisition, dateOfRetunal, userId, materialId)
        {
        }

        public new static List<MemberHasRentedMaterial> FromDatabase(bool isOnlyRented = false)
        {
            return MemberHasRentedMaterialData.FromDatabase(isOnlyRented)
                .Select(x => new MemberHasRentedMaterial(x.Quantity, x.DateOfAquisition, x.DateOfReturnal, x.UserId, x.MaterialId))
                .ToList();
        }

    }
}
