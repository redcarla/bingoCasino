using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoGame2
{
    class Card
    {
        public Rank rank { get; private set; }
        public Suit suit { get; private set; }
        private String avatar;

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
            this.avatar = suit.ToString() + rank.ToString();


        }

    }
}
