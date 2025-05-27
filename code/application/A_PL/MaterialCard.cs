namespace application.A_PL
{
    internal class MaterialCard : Panel
    {
        public Label lbl_Name;
        public Label lbl_Brand;
        public Label lbl_Description;
        public PictureBox? Img = null;
        public int Margin = 10;

        public MaterialCard(string name, string brand, string description, string? imgFilepath)
        {
            this.BackColor = Color.RebeccaPurple;
            this.Size = new Size(930, 190);
            lbl_Name = new Label()
            {
                Size = new Size(232, 49),
                Text = name,
                Location = new Point(10, 0),
                BackColor = Color.Red,
            };
            lbl_Brand = new Label()
            {
                Size = new Size(57, 33),
                Text = brand,
                Location = new Point(10, 50),
                BackColor = Color.Green,
            };
            lbl_Description = new Label()
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
            this.Controls.Add(lbl_Name);
            this.Controls.Add(lbl_Brand);
            this.Controls.Add(lbl_Description);

        }


    }
}
