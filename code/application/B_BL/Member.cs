using application.C_DAL;

namespace application.B_BL
{
    public class Member : MemberData
    {
        public Member(string firstName, string lastName, string email, string phone, int pin, int? id = null)
            : base(firstName, lastName, email, phone, pin, id)
        {
        }

        public static new List<Member> FromDatabase()
        {
            return MemberData.FromDatabase()
                .Select(x => new Member(x.FirstName, x.LastName, x.Email, x.Phone, x.Pin, x.Id))
                .ToList();
        }

        public static new Member FromDatabase(int id)
        {
            MemberData mem = MemberData.FromDatabase(id);
            return new Member(mem.FirstName, mem.LastName, mem.Email, mem.Phone, mem.Pin, mem.Id);
        }

        public static new Member FromDatabase(string firstName, string lastName)
        {
            MemberData mem = MemberData.FromDatabase(firstName, lastName);
            return new Member(mem.FirstName, mem.LastName, mem.Email, mem.Phone, mem.Pin, mem.Id);
        }

        public bool CheckForeignKeyRelation()
        {
            return Rent.CheckForeignKeyRelationForUser(Convert.ToInt32(Id));
        }

        /// <summary>
        /// Checks if an userId is used
        /// </summary>
        /// <param name="id">userId to check</param>
        /// <returns>Returns `true` when the given Id is used in member_has_rented_material, else `false` table</returns>
        public static bool CheckForeignKeyRelation(int id)
        {
            return Rent.CheckForeignKeyRelationForUser(id);
        }


    }

}
