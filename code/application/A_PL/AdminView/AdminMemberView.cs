using application.A_PL.Cards;
using application.B_BL;

namespace application.A_PL.AdminView
{
    public partial class AdminMemberView : Form
    {
        public AdminMemberView()
        {
            InitializeComponent();

            InsertUsers();
            btn_save.Enabled = false;
        }

        public UserCard SelectedCard { get; set; }

        public void InsertUsers()
        {
            sct_members.Panel1.Controls.Clear();

            int yLastLocation = 0;
            List<Admin> admins = Admin.FromDatabase().OrderBy(ad => ad.Id).ToList();

            for (int i = 0; i < admins.Count; i++)
            {
                UserCard uc = new UserCard(admins[i])
                {
                    Location = new Point(
                        UserCard.MARGIN,
                        i * (UserCard.STANDARDHEIGHT + UserCard.MARGIN) + UserCard.MARGIN
                    ),
                };

                uc.Controls.OfType<Label>().ToList().ForEach(lbl => lbl.Click += MemberCard_Click);
                uc.Click += MemberCard_Click;
                sct_members.Panel1.Controls.Add(uc);

                yLastLocation = uc.Bottom;
            }

            List<Member> members = Member.FromDatabase().OrderBy(mem => mem.Id).ToList();

            for (int i = 0; i < members.Count; i++)
            {
                UserCard uc = new UserCard(members[i])
                {
                    Location = new Point(
                        UserCard.MARGIN,
                        yLastLocation + i * (UserCard.STANDARDHEIGHT + UserCard.MARGIN) + UserCard.MARGIN
                    ),
                };

                uc.Controls.OfType<Label>().ToList().ForEach(lbl => lbl.Click += MemberCard_Click);
                uc.Click += MemberCard_Click;
                sct_members.Panel1.Controls.Add(uc);
            }

        }

        private void MemberCard_Click(object? sender, EventArgs e)
        {
            btn_save.Enabled = true;

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
            SelectedCard = uc;

            lbl_memberHeading.Text = (uc.lbl_isAdmin.Text == "M" ? "Member" : "Admin") + " (Id: " + uc.lbl_userId.Text + ")";
            tbx_firstName.Text = uc.lbl_firstName.Text;
            tbx_lastName.Text = uc.lbl_lastName.Text;
            tbx_passKey.Text = uc.lbl_passKey.Text;
            tbx_email.Text  = uc.lbl_email.Text; // looks better :)
            tbx_phone.Text = uc.lbl_phone.Text;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbl_memberHeading.Text.Contains("Member"))
                {
                    Member mem = new(tbx_firstName.Text, tbx_lastName.Text, tbx_email.Text, tbx_phone.Text, Convert.ToInt32(tbx_passKey.Text));
                    mem.Id = ((Member)SelectedCard.OriginUser).Id;

                    mem.UpdateOnDatabase();
                    InsertUsers();

                }
                else
                {
                    Admin ad = new(tbx_firstName.Text, tbx_lastName.Text, tbx_email.Text, tbx_phone.Text, tbx_passKey.Text);
                    ad.Id = ((Admin)SelectedCard.OriginUser).Id;

                    ad.UpdateOnDatabase();
                    InsertUsers();  
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ungültige Eingabe.");
            }
        }

        private void btn_newMember_Click(object sender, EventArgs e)
        {
            
        }

    }
}
