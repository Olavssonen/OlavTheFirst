using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OlavTheFirst
{

    

    internal class LevelUp
    {
        int skillpoints;
        Player player;

        public LevelUp(Player newPlayer) {

            skillpoints = 2;
            player = newPlayer;
            Console.WriteLine("You have " + skillpoints + " skillpoints left");
            Console.WriteLine("You reached a new level!");
            Console.WriteLine("You are now level: " + player.getLvl());
            Console.WriteLine("You recieved: " + player.getLvl() + " skillpoints");
            while (skillpoints > 0)
            {
                Console.WriteLine("Test " + skillpoints + " skillpoints left");
                //skillpoints--;
                
                useSkillpoint();
            }
        }

        private void useSkillpoint()
        {
            
            Console.WriteLine("Spend your skillpoints to lvl up: ");
            Console.WriteLine();

            Console.WriteLine("1. Health " + player.getHealth() + " (+ 5)");
            Console.WriteLine("2. Attack " + player.getAtk() + " (+ 1)");

            String input = Console.ReadLine();

            if (input == "1") {

                lvlUPHealth();
                skillpoints--;

            }
            else if (input == "2")
            {
                lvlUpAtk();
                skillpoints--;
            }
            else {
                useSkillpoint();
            }

            
        }

        public void lvlUpAtk()
        {
            player.setAtk(player.getAtk() + 1);
        }

        public void lvlUPHealth()
        {
            player.setHealth(player.getHealth() + 5);
        }
    }
}
