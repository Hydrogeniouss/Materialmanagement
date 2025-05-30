﻿using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.A_PL
{
    internal abstract class Card : Panel
    {
        public Card()
        {
            this.BackColor = STANDARDBACKCOLOR;
            this.Size = new Size(STANDARDWIDTH, STANDARDHEIGHT);
        }

        public const int STANDARDWIDTH = 930;
        public const int STANDARDHEIGHT = 50;
        public static readonly Color STANDARDBACKCOLOR = Color.RebeccaPurple; // const not working
        public const int MARGIN = 10;
        public const int PADDING = 5;
        

    }
}
