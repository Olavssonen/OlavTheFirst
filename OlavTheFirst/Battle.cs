using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlavTheFirst
{

    internal class Battle
    {

        Player player;
        Monster monster;
        int round;

        public Battle(Player newPlayer, Monster newMonster) {
            player = newPlayer;
            monster = newMonster;
            round = 1 ;
            battle();

        }

        private void battle() {

            Console.WriteLine("A battle start!");
            Console.WriteLine(player.getName() + " - VS - " + monster.getName());
            Console.WriteLine();

            while (monster.checkIfAlive() == true) {

                Console.WriteLine("Round " + round);
                Console.WriteLine(player.getName() + " attacks with " + player.getAtk());
                monster.loseHealth(player.getAtk());
                Console.WriteLine(monster.getName() + " have " + monster.getHealth() + " health left");
                Console.WriteLine();   
                round++;
            }
            Console.WriteLine("You killed the " + monster.getName() + "!");
        
        }
    }
}
