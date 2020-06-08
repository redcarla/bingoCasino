using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CasinoGame2
{
    class BlackJackGame
    {
        public Deck deck = new Deck();
        private Dealer dealer = new Dealer();
        private BlackJackPlayer player;

        // ToDo : fix the inheriting between User and BlackJackPlayer
        public BlackJackGame(string name, double money) 
        {
            deck.randomizeShuffle();
            this.player=new BlackJackPlayer(name,money);
          
        }
        public void dealFirsRound()
        {
            deal();
            dealer.showHand().totalValueOfTheHand();
        }

        public void dealtheSecoundRound()
        {
            deal();
        }

        public void deal()
        {
            var numbersList = deck.deck.ToList();
            dealer.addOneCard(deck.deal());
            numbersList.RemoveAt(0);
            player.addOneCard(deck.deal());
            numbersList.RemoveAt(0);
        }

        public void stay()
        {
            player.stand();
            int theTotalValue = dealer.showHand().totalValueOfTheHand();
            if (theTotalValue < 16 )
            {
                var numbersList = deck.deck.ToList();
                dealer.addOneCard(deck.deal());
                numbersList.RemoveAt(0);
                stay();
            }
            else
            {
  //              Comparer(dealer.showHand().totalValueOfTheHand(), player.showHand().totalValueOfTheHand());
            }
        }








    }
}
