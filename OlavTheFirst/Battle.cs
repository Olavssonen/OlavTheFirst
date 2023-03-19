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
                
                battleMenu();
                round++;

            }
        }

        //Solves one round of battle
        private void aRound(Player player, Monster monster)
        {

            Console.WriteLine("Round " + round);
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

        private void battleMenu()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Abilities");
            Console.WriteLine("3. Items");
            Console.WriteLine("4. Run");
            String input = Console.ReadLine();
            Console.WriteLine();
            if (input == "1")
            {
                aRound(player, monster);
            }
            else if (input == "2")
            {
                Console.WriteLine("Not yet implemented :(");
                battleMenu();
            }
            else if (input == "3")
            {
                Console.WriteLine("Not yet implemented :(");
                battleMenu();
            }
            else if (input == "4")
            {
                Console.WriteLine("Not yet implemented :(");
                battleMenu();
            }
            else
            {
                battleMenu();
            }
        }
    }
}
