using application.C_DAL;

namespace application.B_BL
{
    internal class Member : MemberData
    {
        public Member(int id, string firstName, string lastName, string email, string phone, int pin)
            : base(id, firstName, lastName, email, phone, pin)
        {
        }

        public static new List<Member> FromDatabase()
        {
            return MemberData.FromDatabase()
                .Select(x => new Member(x.Id, x.FirstName, x.LastName, x.Email, x.Phone, x.Pin))
                .ToList();
        }
    }
}
