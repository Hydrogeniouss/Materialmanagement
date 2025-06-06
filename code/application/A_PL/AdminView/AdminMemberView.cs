using application.B_BL;
using application.A_PL.Cards;
using System.Security.Cryptography.X509Certificates;

namespace application.A_PL.AdminView
{
    public partial class AdminMemberView : Form
    {
        public AdminMemberView()
        {
            InitializeComponent();

            FillInUsers();
        }

        public void FillInUsers()
        {
            int yLastLocation= 0;
            List<Admin> admins = Admin.FromDatabase().OrderBy(ad => ad.Id).ToList();
            
            for (int i = 0; i < admins.Count; i++)
            {
                UserCard userCard = new UserCard(admins[i])
                {
                    Location = new Point(
                        UserCard.MARGIN,
                        i * (UserCard.STANDARDHEIGHT + UserCard.MARGIN) + UserCard.MARGIN
                    ),
                };
                userCard.Click += MemberCard_Click;
                sct_members.Panel1.Controls.Add(userCard);

                yLastLocation = userCard.Bottom;
            }

            List<Member> members = Member.FromDatabase().OrderBy(mem => mem.Id).ToList();

            for (int i = 0; i < members.Count; i++)
            {
                UserCard memberCard = new UserCard(members[i])
                {
                    Location = new Point(
                        UserCard.MARGIN,
                        yLastLocation + i * (UserCard.STANDARDHEIGHT + UserCard.MARGIN) + UserCard.MARGIN
                    ),
                };
                memberCard.Click += MemberCard_Click;

                sct_members.Panel1.Controls.Add(memberCard);
            }

        }

        private void MemberCard_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {

        }
    }
}
