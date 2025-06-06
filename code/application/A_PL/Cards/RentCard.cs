﻿using application.B_BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace application.A_PL.Cards
{
    public class RentCard : Card
    {
        public RentCard (Material originMaterial, Member originMember, Rent originRent)
        {
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
                Text = originMaterial.Name,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            });

            Controls.Add(lbl_brand = new Label()
            {
                AutoSize = true,
                Location = new Point(lbl_materialName.Right + PADDING, PADDING),
                Text = originMaterial.Brand.Name,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            });

            Controls.Add(lbl_type = new Label()
            {
                AutoSize = true,
                Location = new Point(600 + PADDING, PADDING),
                Text = originMaterial.Type.Name,
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            });

            Controls.Add(lbl_memberName = new Label()
            {
                AutoSize = true,
                Location = new Point(750, PADDING),
                Text = $"{originMember.FirstName} {originMember.LastName}",
                Font = new Font("Segoe UI", 12, FontStyle.Regular)
            });


        }

        public new const int STANDARDHEIGHT =   33;
        
        public Label lbl_dateOfAquisition{ get; set; }
        public Label lbl_count { get; set; }
        public Label lbl_materialName { get; set; }
        public Label lbl_brand { get; set; }
        public Label lbl_type { get; set; }
        public Label lbl_memberName { get; set; }

    }
}
