using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoGame2
{
    class BlackJackPlayer : User
    {
        public bool busted { get; set; }
        private Hand hand;
        private string name;
        public double money;
        public double moneyBet = 0;
        public bool stay = false;

        public BlackJackPlayer(string name, double money)
        {
            this.money = money;
            this.name = name;
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

        public bool stand()
        {
            stay = true;

            return stay;
        }

        public void hit(Card card)
        {
            hand.addOneCard(card);
        }

        protected bool checkifBusted()
        {
            busted = hand.checkIfBusted(hand.totalValueOfTheHand());
            if (busted == true)
            {
                money -= moneyBet;
            }
            return busted;
        }

        public void betMoney(double betMoney)
        {
            if (checkIfYouHaveMoney(betMoney) == true)
            {
                moneyBet = betMoney;
            }
            else
            {
                Console.WriteLine("you don't have enough money");
            }
        }
        private bool checkIfYouHaveMoney(double betMoney)
        {
            bool moneyHas = false;
            money -= betMoney;
            if (money < 0)
            {
                moneyHas = false;
            }
            else
            {
                moneyHas = true;
            }
            return moneyHas;
        }


    }
}
