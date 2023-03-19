
using OlavTheFirst;

class Program
{

    Player myPlayer;

    static void Main()
    {

        Player myPlayer = new Player();

        string currentPath = Directory.GetCurrentDirectory();
        
        //@"C:\C#\OlavTheFirst\OlavTheFirst\OlavTheFirst\Texts\Save.txt"

        if (File.Exists(currentPath + @"\Texts\Save.txt"))
        {
            Load load = new Load(myPlayer);
            Console.WriteLine("Welcome back, " + myPlayer.getName());
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine(currentPath + @"\Texts");
            Console.WriteLine(getIntroText());
            Console.WriteLine();
            myPlayer.setFirstName();
            myPlayer.setFirstClass();
        }

        getFullRaport(myPlayer);
        menu(myPlayer);

    }

    //Writes a status report of your character to console
    public static void getFullRaport(Player myPlayer)
    {

        Console.WriteLine("This is your character:");
        Console.WriteLine("Name: " + myPlayer.getName());
        Console.WriteLine("Class: " + myPlayer.getClass());
        Console.WriteLine("Level: " + myPlayer.getLvl());
        Console.WriteLine("HP: " + myPlayer.getHealth());
        Console.WriteLine("Attack: " + myPlayer.getAtk());
        Console.WriteLine("Experience: " + myPlayer.getExp());

        if(myPlayer.checkIfMaxLvl() == true)
        {
            Console.WriteLine("Experience to next level: You are MAX level");
        }
        else
        {
            Console.WriteLine("Experience to next level: " + myPlayer.getNextExpLvl());
        }
        
        Console.WriteLine();

    }

    //Starts the menu with choices of actions for the character
    public static void menu(Player myPlayer)
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1. Status");
        Console.WriteLine("2. Battle");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Quit");
        String input = Console.ReadLine();
        Console.WriteLine();
        if (input == "2")
        {
            startBattle(myPlayer);
            if (myPlayer.checkIfAlive() == false)
            {
                Console.WriteLine("Game Over! You are dead");
            }
            else
            {
                Console.WriteLine();
                menu(myPlayer);
            }

        }
        else if (input == "3")
        {
            Save save = new Save(myPlayer);
            Console.WriteLine();
            menu(myPlayer);

        }
        else if (input == "1")
        {
            getFullRaport(myPlayer);
            Console.WriteLine();
            menu(myPlayer);
        }
        else if (input == "4")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Try again!");
            Console.WriteLine();
            menu(myPlayer);
        }
    }

    //Reads the IntroText.txt file for the intro text for new games
    public static String getIntroText()
    {
        String text = System.IO.File.ReadAllText(@"C:\C#\OlavTheFirst\OlavTheFirst\OlavTheFirst\Texts\IntroText.txt");
        return text;
    }

    //Creates a new battle class and a new monster class and starts a new battle
    public static void startBattle(Player myPlayer)
    {
        Monster monster = new Monster();
        Battle battle = new Battle(myPlayer, monster);

    }


}
