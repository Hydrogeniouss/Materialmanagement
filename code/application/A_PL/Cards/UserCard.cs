﻿using application.B_BL;

namespace application.A_PL.Cards
{
    internal class UserCard : Card
    {
        public UserCard(Member originMember)
        {

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
            Height = STANDARDHEIGHT;
            BackColor = PLHelper.GREEN; //For visual difference between Admins and Members
            
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
                Text = "M",
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

        public new const int STANDARDHEIGHT = 33;

        public Label lbl_userId { get; set; }
        public Label lbl_isAdmin { get; set; }
        public Label lbl_firstName { get; set; }
        public Label lbl_lastName { get; set; }
        public Label lbl_passKey { get; set; }
        public Label lbl_email { get; set; }
        public Label lbl_phone { get; set; }




    }
}
