using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CasinoGame2
{
    class BlackJackGame
    {
        public Deck deck = new Deck();
        private Dealer dealer = new Dealer();
        private BlackJackPlayer player;

        
        public BlackJackGame(string name, double money) 
        {
           
            this.player=new BlackJackPlayer(name,money);
          
        }
        public void startFirsRound(int betMoney)
        {
            player.betMoney(betMoney);
            deal();
            dealer.showHand().totalValueOfTheHand();
        }

    //    public void dealtheSecoundRound()
  //      {
   //         deal();
   //     }

        public void deal()
        {
            var numbersList = deck.deck.ToList();
            dealer.addOneCard(deck.deal());
            numbersList.RemoveAt(0);
            player.addOneCard(deck.deal());
            numbersList.RemoveAt(0);
            checkIfBusted(player.showHand().totalValueOfTheHand());
        }
        public bool checkIfBusted(int value)
        {
            var bustted = false;
            if (value > 21)
            {
                player.money -= player.moneyBet;
                Console.WriteLine("you have more than 21");
                return bustted;
            }
            if (value == 21)
            {
                player.money = player.moneyBet*2;
                checkIfWin();
            }
            return bustted;
            }

        public bool checkIfWin()
        {
            var winner = true;
            return winner;
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
                if (checkIfBusted(dealer.showHand().totalValueOfTheHand()))
                {
                    Compare(dealer.showHand().totalValueOfTheHand(), player.showHand().totalValueOfTheHand());
                }
                else
                {
                    player.money += player.moneyBet * 1.5;
                }

            }
        }

        public void Compare(int x, int y)
        {
            //returns 0 if equal
            //returns 1 if x > y
            //returns -1 if x < y
            int temp = ((x - y) >> 0x1F) | (int) ((uint) (-(x - y)) >> 0x1F);
            switch (temp)
            {
                case 1:
                    player.money -= player.moneyBet;
                    break;
                case -1:
                    player.money += player.moneyBet*1.5;
                    break;
            }
                
        }










    }
}
