using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasinoGame2
{
    class Deck
    {
        static Random random = new Random();

        private const int MaxDeckSize = 52;
        public Card[] deck;

        public Deck()
        {
            this.deck = GetDeck();
        }
        private Card[] GetDeck()
        {
            Card[] temp = new Card[MaxDeckSize];
            int index = 0;

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))

                    //  insertTheAvatar(suit,rank);
                    temp[index++] = new Card(suit, rank);
            }

            return temp;
        }


        public Card[] randomizeShuffle()
        {
            Card[] myArray = GetDeck();

            Card[] myRandomArray = myArray.OrderBy(x => random.Next()).ToArray();

            return myRandomArray;
        }

        public Card deal()
        {
           //int index = random.Next(0, MaxDeckSize - 1);
            return deck[0];
        }

    }
}
