namespace OlavTheFirst
{
    internal class Player
    {
        private String name;
        private int health;
        private int atk;
        private String playerClass;

        public Player()
        {

            //setFirstName();
            //setFirstClass();
            health = 10;
            atk = 2;
             

        }


        public Player(String newName, String newPlayerClass)
        {
            name = newName;
            playerClass = newPlayerClass;
        }


        public String getName()
        {
            return name;
        }

        public void setFirstName()
        {
            Console.WriteLine("What is your name?");
            String input = Console.ReadLine();
            if (input != null)
            {
                name = input;
            }
            else
            {

                Console.WriteLine("Try again!");
                setFirstClass();
            }

        }

        public void setName(String newName)
        {

        }

        public void setClass(String newClass)
        {
            playerClass = newClass;
        }

        public void setFirstClass()
        {
            Console.WriteLine("What is your class?");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Ranger");
            String input = Console.ReadLine();
            if (input == "1")
            {
                playerClass = "Warrior";
            }
            else if (input == "2")
            {
                playerClass = "Ranger";
            }
            else
            {
                Console.WriteLine("Write correct number");
                setFirstClass();
            }

        }

        public int getHealth()
        {
            return health;
        }

        public int getAtk()
        {
            return atk;
        }
        public void sethealth(int newHealth)
        {
            health = newHealth;
        }

        public String getClass()
        {
            return playerClass;
        }


    }
}
