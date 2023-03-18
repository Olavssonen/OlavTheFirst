namespace OlavTheFirst
{

    internal class Battle
    {

        Player player;
        Monster monster;
        int round;
        Boolean someoneDead;

        public Battle(Player newPlayer, Monster newMonster)
        {
            player = newPlayer;
            monster = newMonster;
            round = 1;
            battle();

        }

        //Solves the battle
        private void battle()
        {

            Console.WriteLine("A battle start!");
            Console.WriteLine(player.getName() + " - VS - " + monster.getName());
            Console.WriteLine();

            while (checkIfSomeoneDead() == false)
            {


                Console.WriteLine("Round " + round);
                aRound(player, monster);
                round++;

            }
        }

        //Solves one round of battle
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

        //Checks if someone in the battle is dead. Returns true if someone is dead.
        private Boolean checkIfSomeoneDead()
        {
            if (monster.checkIfAlive() == false)
            {
                Console.WriteLine("You killed the " + monster.getName() + "!");
                player.recieveExp(monster.getExp());
                player.checkIfLvlUp();
                return true;
            }
            else if (player.checkIfAlive() == false)
            {

                return true;
            }
            return false;

        }
    }
}
