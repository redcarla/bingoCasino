using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoGame2
{
    class User
    {
        private string name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        private double money
        {
            get { return money; }   // get method
            set { money = value; }  // set method
        }

        public User(string name, double money)
        {
            this.name = name;
            this.money = money;
        }

        protected User()
        {
            throw new NotImplementedException();
        }
    }
}
