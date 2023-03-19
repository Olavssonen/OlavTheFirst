using System.Linq.Expressions;

namespace OlavTheFirst
{
    internal class Player
    {
        private String name;
        private int health;
        private int maxHealth;
        private int atk;
        private String playerClass;
        private Class theClass;
        private int exp;
        private int lvl;
        private int skillpoints;
        private int expToNextLvl;
        private int maxLvl;
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
            maxHealth = theClass.getStartingHealth();
            atk = theClass.getStartingStr();
            exp = 0;
            lvl = 1;
            setNextExpLvl();
            
        }

        //Sets the next exp amount needed to lvl up
        public void setNextExpLvl()
        {
            string currentPath = Directory.GetCurrentDirectory();
            String[] lines = System.IO.File.ReadAllLines(currentPath + @"\Texts\Levels.txt");
            
            maxLvl = lines.Length;
            

            if(checkIfMaxLvl() == false)
            {
                expToNextLvl = +Int16.Parse(lines[lvl - 1]);
            }

            
        }


        //returns remainging exp needed to lvl up 
        public int getNextExpLvl()
        {
            
            return expToNextLvl-exp;
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
        public void checkIfLvlUp()
        {
            if (exp >= expToNextLvl)
            {
                if (checkIfMaxLvl() == false)
                {
                    lvlingUp();
                }
                else
                {
                    Console.WriteLine("You are MAX LVL! :(");
                }

            }

        }
        public Boolean checkIfMaxLvl()
        {
            if(lvl <= maxLvl)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void setName(String newName)
        {
            name = newName;
        }

        public void setMaxHealth(int newMaxHealth)
        {
            maxHealth = newMaxHealth;
        }

        public void getFullHealth()
        {
            health = maxHealth;
        }

        public int getMaxHealth() 
        { 
            return maxHealth;
        }

        public void recieveExp(int newExp)
        {
            //Console.WriteLine("EXP before " + exp);
            exp += newExp;
            //Console.WriteLine("EXP after " + exp);
        }

        public int getExp()
        {
            return exp;
        }

        public void setClass(String newClass)
        {
            //playerClass = theClass.setClass(newClass)
            theClass = new Class(newClass);
        }

        public void lvlingUp()
        {
            lvl++;
            LevelUp levelUp = new LevelUp(this);
            setNextExpLvl();
        }



        public void setLvl(int newLvl)
        {
            lvl = newLvl;
        }

        public void setExp(int newExp)
        {
            exp = newExp;
        }



        public int getLvl()
        {
            return lvl;
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

        public void setHealth(int newHealth)
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
