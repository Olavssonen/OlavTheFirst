namespace OlavTheFirst
{
    internal class Load
    {
        public Load(Player player)
        {
            //String text = System.IO.File.ReadAllText(@"C:\C#\OlavTheFirst\OlavTheFirst\OlavTheFirst\Texts\IntroText.txt");

            string currentPath = Directory.GetCurrentDirectory();
            
            String[] lines = System.IO.File.ReadAllLines(currentPath + @"\Texts\Save.txt");
            

            player.setName(lines[0]);
            player.setClass(lines[1]);
            player.setLvl(Int16.Parse(lines[2]));
            player.setHealth(Int16.Parse(lines[3]));
            player.setAtk(Int16.Parse(lines[4]));
            player.setExp(Int16.Parse(lines[5]));
            player.setMaxHealth(Int16.Parse(lines[6]));

            player.setNextExpLvl();


        }
    }
}
