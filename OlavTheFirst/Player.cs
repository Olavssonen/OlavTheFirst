namespace OlavTheFirst
{
    internal class Player
    {
        private String name;
        private int health;
        private int atk;
        private String playerClass;
        private Class theClass;
        private int exp;
        private int lvl;
        Boolean alive;

        public Player()
        {


        }


        public Player(String newName, String newPlayerClass)
        {
            name = newName;
            playerClass = newPlayerClass;
        }

        //Sets the chosen name of the player from input
        public void setFirstName()
        {
            Console.WriteLine("Your name:");
            String input = Console.ReadLine();
            Console.WriteLine();
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

        //Make the player choose a class the first time the game is played
        public void setFirstClass()
        {
            Console.WriteLine("What is your class?");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Ranger");
            String input = Console.ReadLine();
            Console.WriteLine();
            if (input == "1")
            {
                //playerClass = "Warrior";
                //theClass = new Class("Warrior");
                setNewClass("Warrior");
            }
            else if (input == "2")
            {
                //playerClass = "Ranger";
                //theClass = new Class("Ranger");
                setNewClass("Ranger");
            }
            else
            {
                Console.WriteLine("Write correct number");
                setFirstClass();
            }

        }

        //Sets the basic stats for choosen class
        public void setNewClass(String newClass)
        {
            //playerClass = theClass.setClass(newClass)
            theClass = new Class(newClass);
            health = theClass.getStartingHealth();
            atk = theClass.getStartingStr();
        }

        //Check if player is alive. Returns true if alive.
        public Boolean checkIfAlive()
        {
            if (health > 0)
            {
                return true;
            }

            else return false;
        }

        public void setName(String newName)
        {
            name = newName;
        }

        public void setClass(String newClass)
        {
            //playerClass = theClass.setClass(newClass)
            theClass = new Class(newClass);
        }

        public String getName()
        {
            return name;
        }

        public int getHealth()
        {
            return health;
        }

        public int getAtk()
        {
            return atk;
        }

        public void setAtk(int newAtk)
        {
            atk = newAtk;
        }
        public void sethealth(int newHealth)
        {
            health = newHealth;
        }

        public String getClass()
        {
            return theClass.getPlayerClass();
        }

        public void loseHealth(int dmg)
        {
            health -= dmg;
        }


    }
}
