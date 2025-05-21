using application.C_DAL;

namespace application.B_BL
{
    internal class Member : MemberData
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
    }
}
