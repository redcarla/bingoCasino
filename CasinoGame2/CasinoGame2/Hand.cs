using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoGame2
{
    class Hand
    {
        private const int MaxHandSize = 14;
        private Card[] hand;
        private int total;

        public Hand()
        {
            hand = new Card[MaxHandSize];
        }

        public int Size
        {
            get
            {
                return hand.Length;
            }
        }

        public void addCards(Card[] cards)
        {
            for (int i = 0; i < hand.Length; i++)
                hand[i] = cards[i];

        }




    }
}
