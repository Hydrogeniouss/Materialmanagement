namespace application.A_PL.Cards
{
    public abstract class Card : Panel
    {
        public Card()
        {
            BackColor = STANDARDBACKCOLOR;
            Size = new Size(STANDARDWIDTH, STANDARDHEIGHT);
        }

        public const int STANDARDWIDTH = 930;
        public const int STANDARDHEIGHT = 50;

        public static readonly Color STANDARDBACKCOLOR = Color.LightGray; // const not working
        public const int MARGIN = 10;
        public const int PADDING = 5;


    }
}
