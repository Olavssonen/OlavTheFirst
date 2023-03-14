
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
            myPlayer.setFirstName();
            myPlayer.setFirstClass();
        }

        getFullRaport(myPlayer);
        menu(myPlayer);

    }

    public static void getFullRaport(Player myPlayer)
    {
        Console.WriteLine(getIntroText());
        Console.WriteLine(" ");
        Console.WriteLine("Name: " + myPlayer.getName());
        Console.WriteLine("Class: " + myPlayer.getClass());
        Console.WriteLine("HP: " + myPlayer.getHealth());

    }

    public static void menu(Player myPlayer)
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1. Battle");
        Console.WriteLine("2. Save");
        String input = Console.ReadLine();
        if (input == "1")
        {
            startBattle(myPlayer);
            menu(myPlayer);

        }
        else if(input == "2")
        {
            Save save = new Save(myPlayer);
            menu(myPlayer);

        }
        else
        {
            Console.WriteLine("Try again!");
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
