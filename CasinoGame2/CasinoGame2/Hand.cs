using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasinoGame2
{
    class Hand
    {
        private const int MaxHandSize = 14;
        private Card[] hand;
        private int total;
        private bool busted = false;
        private bool winner = false;

        public Hand()
        {
            hand = new Card[MaxHandSize];
        }


 //       public void addCards(Card[] cards)
 //       {
 //           for (int i = 0; i < hand.Length; i++)
 //               hand[i] = cards[i];
 //           sort();
 //           totalValueOfTheHand();
   //         checkIfBusted(totalValueOfTheHand());
  //      }

        public void addOneCard(Card card)
        {
            int handSize = hand.Length;
                hand[handSize+1] = card;
                sort();
 //               totalValueOfTheHand();
 //               checkIfBusted(totalValueOfTheHand());
        }
        public void sort()
        {
            hand = hand.OrderBy(card => (int)card.rank).ToArray();
        }

        public int totalValueOfTheHand()
        {
            int totalValue = 0;
            foreach (Card c in hand)
            {
                totalValue += (int)c.rank;
            }
            return totalValue;
        }
      
    }
}
