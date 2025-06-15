using application.B_BL;
using application.C_DAL;
using Microsoft.VisualBasic.ApplicationServices;

namespace application.A_PL.Cards
{
    public class UserCard : Card
    {
        public UserCard(Member originMember)
        {
            OriginUser = originMember;

            Height = STANDARDHEIGHT;

            Controls.Add(lbl_userId = new Label()
            {
                AutoSize = true,
                Location = new Point(PADDING, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.DarkSlateGray,
                Text = originMember.Id.ToString(),
            });
            //MessageBox.Show(lbl_userId.Right.ToString() + "|"+ lbl_userId.Left.ToString()); // (24 - 5) * 3 = 57 + 5 = 62 

            Controls.Add(lbl_isAdmin = new Label()
            {
                AutoSize = true,
                Location = new Point(62, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = "M",
            });

            Controls.Add(lbl_firstName = new Label()
            {
                AutoSize = true,
                Location = new Point(lbl_isAdmin.Right + PADDING, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originMember.FirstName,
            });

            Controls.Add(lbl_lastName = new Label()
            {
                AutoSize = true,
                Location = new Point(180 + MARGIN, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originMember.LastName,
            });

            Controls.Add(lbl_passKey = new Label()
            {
                AutoSize = true,
                Location = new Point(310, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originMember.Pin.ToString(),
            });

            Controls.Add(lbl_email = new Label()
            {
                AutoSize = true,
                Location = new Point(450, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originMember.Email,
            });

            Controls.Add(lbl_phone = new Label()
            {
                AutoSize = true,
                Location = new Point(750 + PADDING, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originMember.Phone,
            });


        }

        public UserCard(Admin originalAdmin)
        {
            OriginUser = originalAdmin;

            Height = STANDARDHEIGHT;
            BackColor = UIConfig.GREEN; //For visual difference between Admins and Members

            Controls.Add(lbl_userId = new Label()
            {
                AutoSize = true,
                Location = new Point(PADDING, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.DarkSlateGray,
                Text = originalAdmin.Id.ToString(),
            });
            //MessageBox.Show(lbl_userId.Right.ToString() + "|"+ lbl_userId.Left.ToString()); // (24 - 5) * 3 = 57 + 5 = 62 

            Controls.Add(lbl_isAdmin = new Label()
            {
                AutoSize = true,
                Location = new Point(62, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = "A",
            });

            Controls.Add(lbl_firstName = new Label()
            {
                AutoSize = true,
                Location = new Point(lbl_isAdmin.Right + PADDING, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originalAdmin.FirstName,
            });

            Controls.Add(lbl_lastName = new Label()
            {
                AutoSize = true,
                Location = new Point(180 + MARGIN, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originalAdmin.LastName,
            });

            Controls.Add(lbl_passKey = new Label()
            {
                AutoSize = true,
                Location = new Point(310, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originalAdmin.Password,
            });

            Controls.Add(lbl_email = new Label()
            {
                AutoSize = true,
                Location = new Point(450, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originalAdmin.Email,
            });

            Controls.Add(lbl_phone = new Label()
            {
                AutoSize = true,
                Location = new Point(750 + PADDING, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originalAdmin.Phone,
            });

        }

        // Public because is needed in eg. AdminMemberView when filling in information for selected user.

        public new const int STANDARDHEIGHT = 33;
        
        public Label lbl_userId { get; }
        public Label lbl_isAdmin { get; }
        public Label lbl_firstName { get; }
        public Label lbl_lastName { get; }
        public Label lbl_passKey { get; }
        public Label lbl_email { get; }
        public Label lbl_phone { get; }

        public UserData OriginUser { get; }


    }
}
