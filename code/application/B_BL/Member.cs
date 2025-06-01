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
    }
}
