namespace application.A_PL
{
    internal class MaterialCard : Panel
    {
        public Label lblName;
        public Label lblBrand;
        public Label lblDescription;
        public PictureBox? Img = null;
        public MaterialCard(string name, string brand, string description, string? imgFilepath)
        {
            this.BackColor = Color.RebeccaPurple;
            this.Size = new Size(930, 190);
            lblName = new Label()
            {
                Size = new Size(232, 49),
                Text = name,
                Location = new Point(10, 0),
                BackColor = Color.Red,
            };
            lblBrand = new Label()
            {
                Size = new Size(57, 33),
                Text = brand,
                Location = new Point(10, 50),
                BackColor = Color.Green,
            };
            lblDescription = new Label()
            {
                Size = new Size(731,86),
                Text = $"Description:\n{description}",
                Location = new Point(10, 90),
                BackColor = Color.Blue,
            };
            if (imgFilepath != null)
            {
                Img = new PictureBox()
                {
                    Size = new Size(157, 157),
                    Image = Image.FromFile(imgFilepath),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                this.Controls.Add(Img);
            }
            this.Controls.Add(lblName);
            this.Controls.Add(lblBrand);
            this.Controls.Add(lblDescription);

        }


    }
}
