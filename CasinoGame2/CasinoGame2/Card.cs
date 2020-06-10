using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoGame2
{
    class Card
    {
        public Rank rank { get; private set; }
        public Suit suit { get; private set; }
        public String avatar { get; set; }

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
            this.avatar = suit.ToString() + rank.ToString();
        }
    }
}
