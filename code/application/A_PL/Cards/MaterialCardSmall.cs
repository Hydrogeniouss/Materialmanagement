using application.B_BL;

namespace application.A_PL.Cards
{
    public class MaterialCardSmall : Card
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

            Controls.Add(btn_Delete = new Button()
            {
                Location = new Point(0, 0),
                Height = Height,
                Width = Height,
                Text = "X",
                BackColor = Color.Red,
            });

            Controls.Add(lbl_Brand = new Label()
            {
                AutoSize = true,
                Height = Height - PADDING * 2,
                Location = new Point(btn_Delete.Right + PADDING, PADDING),
                Text = Origin.lbl_Brand.Text,
            });

            Controls.Add(lbl_Name = new Label()
            {
                AutoSize = true,
                Height = Height - PADDING * 2,
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
