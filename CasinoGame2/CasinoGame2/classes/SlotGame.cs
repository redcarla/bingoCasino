using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoGame2
{
    class SlotGame
    {
        private BlackJackPlayer player;
        public int bet { get; set; }

        public SlotGame(string name, double money)
        {
            this.player = new BlackJackPlayer(name, money);
        }
        public void play(int bet)
        {

        }
    }
}
