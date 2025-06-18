using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.A_PL.Cards
{
    internal class RentCardSmall : Card
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="origin"></param>
        /// whose contents are the basis for this
        public RentCardSmall(RentCard origin)
            : base()
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
                Text = Origin.lbl_brand.Text,
            });

            Controls.Add(lbl_Name = new Label()
            {
                AutoSize = true,
                Height = Height - PADDING * 2,
                Location = new Point(lbl_Brand.Right + PADDING, PADDING),
                Text = Origin.lbl_materialName.Text,
            });


        }



        public new const int STANDARDHEIGHT = 50;

        public int Count { get; set; }

        public RentCard Origin { get; }
        public Label lbl_Name { get; }
        public Label lbl_Brand { get; }
        public Button btn_Delete { get; }


    }
}
