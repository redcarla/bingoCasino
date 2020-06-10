using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoGame2
{
    class User
    {
        protected string name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        public double money
        {
            get { return money; }   // get method
            set { money = value; }  // set method
        }

        public User(string name, double money)
        {
            this.name = name;
            this.money = money;
        }

        public Hand showHand()
        {
            return null;
        }
        public void addOneCard(Card card)
        {
            
        }

        public void hit(Card card)
        {
          
        }

        public bool stand()
        {
            return false;
        }

        public void betMoney(double betMoney)
        {
         
        }
        private bool checkIfYouHaveMoney(double betMoney)
        {
            return false;
        }
        protected User()
        {
            throw new NotImplementedException();
        }
    }
}
