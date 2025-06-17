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
            btn_delete.Enabled = false;

        }

        public UserCard? SelectedCard { get; set; }

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
            btn_delete.Enabled = true;

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
            tbx_email.Text = uc.lbl_email.Text;
            tbx_phone.Text = uc.lbl_phone.Text;
        }

        private void ClearUserInfo()
        {
            lbl_memberHeading.Text = "[Mitgliedernummer]";
            tbx_firstName.Text = null;
            tbx_lastName.Text = null;
            tbx_passKey.Text = null;
            tbx_email.Text = null;
            tbx_phone.Text = null;

            btn_delete.Enabled = false;
            btn_save.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbl_memberHeading.Text.Contains("Member"))
                {
                    Member mem = new(tbx_firstName.Text, tbx_lastName.Text, tbx_email.Text, tbx_phone.Text, Convert.ToInt32(tbx_passKey.Text));
                    mem.Id = ((Member)SelectedCard!.OriginUser).Id; // Button only enabled while card is selected.

                    mem.UpdateOnDatabase();
                    InsertUsers();

                }
                else
                {
                    Admin ad = new(tbx_firstName.Text, tbx_lastName.Text, tbx_email.Text, tbx_phone.Text, tbx_passKey.Text);
                    ad.Id = ((Admin)SelectedCard!.OriginUser).Id; // Button only enabled while card is selected.

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
            DialogResult result = new AdminNewMember().ShowDialog(); // ShowDialog bc we need return value

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Erfolgreich angelegt");

                InsertUsers();
            }
            else
            {
                MessageBox.Show("Es ist ein fehler beim Speichern passiert.");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Wollen sie diesen Benutzer wirklich löschen?", null, MessageBoxButtons.YesNo))
            {
                if (lbl_memberHeading.Text.Contains("Member"))
                {
                    int userId = Convert.ToInt32(((Member)SelectedCard!.OriginUser).Id);
                    if (Member.CheckForeignKeyRelation(userId))
                    {
                        Member.DeleteOnDatabase(Convert.ToInt32(userId)); // Button only enabled while card is selected.
                        ClearUserInfo();
                        InsertUsers();
                    }
                    else
                    {
                        MessageBox.Show("Dieses Mitglied kann nicht gelöscht werden. Es ist relevant für die Verleihhistorie.");
                    }

                }
                else
                {
                    int userId = Convert.ToInt32(((Admin)SelectedCard!.OriginUser).Id);
                    Admin.DeleteOnDatabase(userId); // Button only enabled while card is selected.

                    ClearUserInfo();
                    InsertUsers();
                }


            }
        }

        private void lbl_Lager_Click(object sender, EventArgs e)
        {
            new AdminStoragaeView().Show();
            Close();
        }

        private void AdminMemberView_ForeColorChanged(object sender, EventArgs e)
        {
            if (!UiHelper.ProgramaticallyClosing)
            {
                UiHelper.ProxyExit();
            }
            else
            {
                UiHelper.ProgramaticallyClosing = false; // Reset for next use
            }

        }
    }
}