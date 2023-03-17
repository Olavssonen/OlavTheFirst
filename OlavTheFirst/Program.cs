
using OlavTheFirst;
using System.Threading;

class Program
{

    Player myPlayer;

    static void Main()
    {

        Player myPlayer = new Player();

        if (File.Exists(@"C:\C#\OlavTheFirst\OlavTheFirst\OlavTheFirst\Texts\Save.txt"))
        {
            Load load = new Load(myPlayer);
        }
        else
        {
            Console.WriteLine(getIntroText());
            Console.WriteLine();
            myPlayer.setFirstName();
            myPlayer.setFirstClass(); 
        }

        getFullRaport(myPlayer);
        menu(myPlayer);

    }

    public static void getFullRaport(Player myPlayer)
    {
        
        Console.WriteLine("This is your character:");
        Console.WriteLine("Name: " + myPlayer.getName());
        Console.WriteLine("Class: " + myPlayer.getClass());
        Console.WriteLine("HP: " + myPlayer.getHealth());
        Console.WriteLine();

    }

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
            if(myPlayer.checkIfAlive() == false)
            {
                Console.WriteLine("Game Over! You are dead");
            }else
            Console.WriteLine();
            menu(myPlayer);

        }
        else if(input == "3")
        {
            Save save = new Save(myPlayer);
            Console.WriteLine();
            menu(myPlayer);

        }
        else if(input == "1")
        {
            getFullRaport(myPlayer);
            Console.WriteLine();
            menu(myPlayer);
        }
        else if(input == "4")
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

    public static String getIntroText()
    {
        String text = System.IO.File.ReadAllText(@"C:\C#\OlavTheFirst\OlavTheFirst\OlavTheFirst\Texts\IntroText.txt");
        return text;
    }

    public static void startBattle (Player myPlayer){
        Monster monster = new Monster();
        Battle battle = new Battle(myPlayer, monster);

    }


}
