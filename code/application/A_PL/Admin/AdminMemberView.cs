using application.B_BL;
using application.A_PL.Cards;

namespace application.A_PL.Admin
{
    public partial class AdminMemberView : Form
    {
        public AdminMemberView()
        {
            InitializeComponent();

            FillInMembers();
        }

        public void FillInMembers()
        {
            List<Member> members = Member.FromDatabase();

            for (int i = 0; i < members.Count; i++)
            {
                MemberCard memberCard = new MemberCard(members[i])
                {
                    Location = new Point(
                        MemberCard.MARGIN,
                        i * (MemberCard.STANDARDHEIGHT + MemberCard.MARGIN) + MemberCard.MARGIN
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
