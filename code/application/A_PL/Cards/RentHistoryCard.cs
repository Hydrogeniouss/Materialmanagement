using application.B_BL;

namespace application.A_PL.Cards
{
    public class RentHistoryCard : Card
    {
        public RentHistoryCard(Material originMaterial, Member originMember, Rent originRent)
            : base()
        {

            Height = STANDARDHEIGHT;
            OriginRent = originRent;

            ParentChanged += UpdateBackColor;

            Controls.Add(lbl_dateOfAquisition = new Label()
            {
                AutoSize = true,
                Location = Location = new Point(PADDING, PADDING),
                Text = DateOnly.FromDateTime(originRent.DateOfAquisition).ToString(),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.DarkSlateGray,
            });

            if (originRent.DateOfReturnal != null)
            {

                Controls.Add(lbl_dateOfRetrunal = new Label()
                {
                    AutoSize = true,
                    Location = Location = new Point(lbl_dateOfAquisition.Right + MARGIN, PADDING),
                    Text = DateOnly.FromDateTime((DateTime)originRent.DateOfReturnal).ToString(),
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                    ForeColor = Color.DarkSlateGray
                });
            }
            else
            {
                Controls.Add(lbl_dateOfRetrunal = new Label()
                {
                    AutoSize = true,
                    Location = Location = new Point(lbl_dateOfAquisition.Right + MARGIN, PADDING),
                    Text = "-",
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                    ForeColor = Color.DarkSlateGray
                });
            }

            //MessageBox.Show(lbl_dateOfRetrunal.Right.ToString() + "|" +lbl_dateOfRetrunal.Text);

            Controls.Add(lbl_count = new Label()
            {
                AutoSize = true,
                Location = new Point(187 + MARGIN, PADDING), //187 is the largest possible lbl_dateOfReturnal.Right (tested)
                Text = originRent.Quantity.ToString(),
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
            });

            Controls.Add(lbl_materialName = new Label()
            {
                AutoSize = true,
                Location = new Point(230 + MARGIN, PADDING), // 230 is a good spacing to Count (lbl_count)
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

        public new const int STANDARDHEIGHT = 24;
        public new const int MARGIN = 10;
        public new const int PADDING = 1;

        public Label lbl_dateOfRetrunal { get; }
        public Label lbl_dateOfAquisition { get; }
        public Label lbl_count { get; }
        public Label lbl_materialName { get; }
        public Label lbl_brand { get; }
        public Label lbl_type { get; }
        public Label lbl_memberName { get; }

        public Rent OriginRent { get; }


        public void UpdateBackColor(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                BackColor = Parent.BackColor;
                if (OriginRent.DateOfReturnal != null)
                {
                    BackColor = Parent.BackColor != UIConfig.GREEN ? UIConfig.GREEN : UIConfig.RED;
                }
            }
        }
    }
}
