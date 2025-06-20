﻿using application.B_BL;
using application.C_DAL;
namespace application.A_PL.Cards
{
    public class RentCard : Card
    {
        public RentCard(Rent originRent)
        {
            OriginRent = originRent;
            OriginMaterial = Material.FromDatabase((int)originRent.MaterialId);
            OriginMember = Member.FromDatabase((int)originRent.UserId);
            Height = STANDARDHEIGHT;

            Controls.Add(lbl_dateOfAquisition = new Label()
            {
                AutoSize = true,
                Location = Location = new Point(PADDING, PADDING),
                Text = originRent.DateOfAquisition.ToString(),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.DarkSlateGray,

            });

            Controls.Add(lbl_count = new Label()
            {
                AutoSize = true,
                Location = new Point(lbl_dateOfAquisition.Right + PADDING * 3, PADDING),
                Text = originRent.Quantity.ToString(),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
            });

            Controls.Add(lbl_materialName = new Label()
            {
                AutoSize = true,
                Location = new Point(225 + PADDING * 3, PADDING),
                Text = OriginMaterial.Name,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            });

            Controls.Add(lbl_brand = new Label()
            {
                AutoSize = true,
                Location = new Point(lbl_materialName.Right + PADDING, PADDING),
                Text = OriginMaterial.Brand.Name,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            });

            Controls.Add(lbl_type = new Label()
            {
                AutoSize = true,
                Location = new Point(600 + PADDING, PADDING),
                Text = OriginMaterial.Type.Name,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            });

            Controls.Add(lbl_memberName = new Label()
            {
                AutoSize = true,
                Location = new Point(750, PADDING),
                Text = $"{OriginMember.FirstName} {OriginMember.LastName}",
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            });


        }

        public new const int STANDARDHEIGHT = 33;

        public Rent OriginRent { get; set; }
        public Material OriginMaterial { get; set; }
        public Member OriginMember { get; set; }

        public Label lbl_dateOfAquisition { get; }
        public Label lbl_count { get; }
        public Label lbl_materialName { get; }
        public Label lbl_brand { get; }
        public Label lbl_type { get; }
        public Label lbl_memberName { get; }

    }
}
