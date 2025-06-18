using application.B_BL;

namespace application.A_PL.Cards
{
    public class MaterialCardLarge : Card
    {
        public MaterialCardLarge(Material material)
        {

            Height = STANDARDHEIGHT;
            originMaterial = material;

            lbl_Name = new Label()
            {
                Size = new Size(232, 49),
                Text = material.Name,
                Location = new Point(10, 0),
                BackColor = Color.Red,
            };
            lbl_Brand = new Label()
            {
                Size = new Size(57, 33),
                Text = material.Brand.Name,
                Location = new Point(10, 50),
                BackColor = Color.Green,
            };
            lbl_Description = new Label()
            {
                Size = new Size(731, 86),
                Text = $"Description:\n{material.Description}",
                Location = new Point(10, 90),
                BackColor = Color.Blue,
            };
            if (material.ImageFilepath != null && File.Exists(material.ImageFilepath))
            {
                Img = new PictureBox()
                {
                    Size = new Size(157, 157),
                    Image = Image.FromFile(material.ImageFilepath),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                Controls.Add(Img);
            }
            if (material.AmountAvailable == 0)
            {
                BackColor = Card.STANDARTUNAVAILABLECOLOR;
                lbl_Name.BackColor = Card.STANDARTUNAVAILABLECOLOR;
                lbl_Brand.BackColor = Card.STANDARTUNAVAILABLECOLOR;
                lbl_Description.BackColor = Card.STANDARTUNAVAILABLECOLOR;
            }
            Controls.Add(lbl_Name);
            Controls.Add(lbl_Brand);
            Controls.Add(lbl_Description);

        }

        public new const int STANDARDHEIGHT = 190;

        public Material originMaterial { get; set; }

        public Label lbl_Name { get; }
        public Label lbl_Brand { get; }
        public Label lbl_Description { get; }

        public PictureBox? Img = null;


    }
}
