using application.B_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.A_PL.Cards
{
    internal class MemberCard : Card
    {
        public MemberCard(Member originMember)
        {
            Height = STANDARDHEIGHT;

            Controls.Add(lbl_memberId = new Label()
            {
                AutoSize = true,
                Location = Location = new Point(PADDING, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.DarkSlateGray,
                Text = originMember.Id.ToString(),

            });

            Controls.Add(lbl_firstName = new Label()
            {
                AutoSize = true,
                Location = new Point(lbl_memberId.Right + PADDING * 3, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originMember.FirstName,
            });

            Controls.Add(lbl_lastName = new Label()
            {
                AutoSize = true,
                Location = new Point(225 + PADDING * 3, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originMember.LastName,
            });

            Controls.Add(lbl_pin = new Label()
            {
                AutoSize = true,
                Location = new Point(750, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originMember.Pin.ToString(),       
            });

            Controls.Add(lbl_email = new Label()
            {
                AutoSize = true,
                Location = new Point(lbl_lastName.Right + PADDING, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originMember.Email,
            });

            Controls.Add(lbl_phone = new Label()
            {
                AutoSize = true,
                Location = new Point(600 + PADDING, PADDING),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Text = originMember.Phone,
            });

        }

        public new const int STANDARDHEIGHT = 33;

        public Label lbl_memberId { get; set; }
        public Label lbl_firstName { get; set; }
        public Label lbl_lastName { get; set; }
        public Label lbl_pin { get; set; }
        public Label lbl_email { get; set; }
        public Label lbl_phone { get; set; }

    }
}
