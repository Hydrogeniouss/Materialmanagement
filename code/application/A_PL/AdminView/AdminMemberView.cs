using application.A_PL.Cards;
using application.B_BL;

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
            int yLastLocation = 0;
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
                memberCard.Controls.OfType<Label>().ToList().ForEach(lbl => lbl.Click += MemberCard_Click);
                memberCard.Click += MemberCard_Click;
                sct_members.Panel1.Controls.Add(memberCard);
            }

        }

        private void MemberCard_Click(object? sender, EventArgs e)
        {
            if (sender is UserCard uc)
            {
                LoadUserData(uc);
            }
            else if (sender is Label lbl)
            {
                uc = (UserCard)lbl.Parent!;
                LoadUserData(uc);
            }

        }

        private void LoadUserData(UserCard uc)
        {
            lbl_memberHeading.Text = (uc.lbl_isAdmin.Text == "M" ? "Member" : "Admin") + " (Id: " + uc.lbl_userId.Text + ")";
            tbx_firstName.Text = uc.lbl_firstName.Text;
            tbx_lastName.Text = uc.lbl_lastName.Text;
            tbx_passKey.Text = uc.lbl_passKey.Text;
            tbx_email.Text = uc.lbl_email.Text; // looks better :)
            tbx_phone.Text = uc.lbl_phone.Text;
        }

    }
}
