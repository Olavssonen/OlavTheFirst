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
        Boolean someoneDead;

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
            


            while (checkIfSomeoneDead() == false) {

                 
                Console.WriteLine("Round " + round);
                aRound(player, monster);
                round++;
                
            }

            
            
        
        }

        private void aRound(Player player, Monster monster)
        {
            Console.WriteLine(player.getName() + " attacks with " + player.getAtk());
            monster.loseHealth(player.getAtk());
            Console.WriteLine(monster.getName() + " have " + monster.getHealth() + " health left");

            Console.WriteLine();

            Console.WriteLine(monster.getName() + " attacks with " + monster.getAtk());
            player.loseHealth(monster.getAtk());
            Console.WriteLine(player.getName() + " have " + player.getHealth() + " health left");

            Console.WriteLine();
        }

        private Boolean checkIfSomeoneDead()
        {
            if (monster.checkIfAlive() == false) {
                Console.WriteLine("You killed the " + monster.getName() + "!");
                return true;
            }else if (player.checkIfAlive() == false)
            {
                
                return true;
            }return false;

        }
    }
}
