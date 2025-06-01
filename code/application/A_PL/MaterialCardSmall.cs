using application.B_BL;

namespace application.A_PL
{
    internal class MaterialCardSmall : Card
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="origin"></param>
        /// whose contents are the basis for this
        public MaterialCardSmall(MaterialCardLarge origin)
            :base() 
        {
            Origin = origin;

            this.Controls.Add(btn_Delete = new Button()
            {
                Location = new Point(0, 0),
                Height = this.Height,
                Width = this.Height,
                Text = "X",
                BackColor = Color.Red,
            });

            this.Controls.Add(lbl_Brand = new Label()
            {
                AutoSize = true,
                Height = this.Height - PADDING * 2,
                Location = new Point(btn_Delete.Right + PADDING, PADDING),
                Text = Origin.lbl_Brand.Text,
            });

            this.Controls.Add(lbl_Name = new Label()
            {
                AutoSize = true,
                Height = this.Height - PADDING * 2,
                Location = new Point(lbl_Brand.Right + PADDING, PADDING),
                Text = Origin.lbl_Name.Text,
            });

            

        }

        

        public new const int STANDARDHEIGHT = 50;

        public int Count { get; set; }
        
        public MaterialCardLarge? Origin { get; set; }
        public Label lbl_Name { get; set; }
        public Label lbl_Brand { get; set; }
        public Button btn_Delete { get; set; }

    }
}
