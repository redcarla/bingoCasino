using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace CasinoGame2
{
    class BlackJackPlayer : User
    {
        public bool busted { get; set; }
        public Hand hand;
       // private string name;
       // public double money;
        public double moneyBet { get; set; }
        public bool stay = false;

        public BlackJackPlayer(string name, double money)
        {
            base.name = name;
            base.money = money;
            busted = false;
        }

        public Hand showHand()
        {
            return this.hand;
        }
        public void addOneCard(Card card)
        {
            hand.addOneCard(card);
        }

        public void hit(Card card)
        {
            hand.addOneCard(card);
        }


        public bool stand()
        {
            stay = true;

            return stay;
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
