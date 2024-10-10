using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace PSR_GAME
{
    enum VARIANTS
    {
        ROCK,
        PAPER,
        SCISSORTS
    }
    internal class Player
    {
        public string name { get; set; }
        public VARIANTS choice { get; set; }
        List<VARIANTS> Variants=new List<VARIANTS>() { VARIANTS.ROCK,VARIANTS.PAPER,VARIANTS.SCISSORTS};
        public Player(string name = "bot")
        {
            Random random = new Random();
            int min = 0;
            int max = 2;
            this.name = name;
            int randomRSP = random.Next(min, max);
            choice = Variants[randomRSP];
        }
        public Player(VARIANTS choice, string name)
        {
            
            this.name=name;
            this.choice= choice;

        }
        public void whoWins(Player bot, Player player) 
        {
            if (bot.choice==VARIANTS.ROCK && player.choice==VARIANTS.SCISSORTS || bot.choice == VARIANTS.PAPER && player.choice == VARIANTS.ROCK || bot.choice == VARIANTS.SCISSORTS && player.choice == VARIANTS.PAPER ) 
            {
                Console.WriteLine("Bot WIN!!!");
            }
            else if(bot.choice == player.choice)
            {
                Console.WriteLine("Draw");
            }
            else
            {
                Console.WriteLine("Player WIN!!!");
            }
        }
    }
}
