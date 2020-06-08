using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoGame2
{
    class Dealer
    {
        public bool busted { get; set; }
        private Hand hand;
        public Dealer()
        {
            busted = false;
        }

        public Hand showHand()
        {
            return this.hand;
        }
        public void addOneCard(Card card)
        {
            hand.addOneCard(card);

            checkifBusted();
        }
        public void hit(Card card)
        {
            hand.addOneCard(card);
        }

        protected bool checkifBusted()
        {
            busted = hand.checkIfBusted(hand.totalValueOfTheHand());
            return busted;
        }

    }
}
