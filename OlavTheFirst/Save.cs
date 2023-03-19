namespace OlavTheFirst
{
    internal class Save
    {

        public Save(Player player)
        {
            string currentPath = Directory.GetCurrentDirectory();
            
            //@"C:\C#\OlavTheFirst\OlavTheFirst\OlavTheFirst\Texts\Save.txt"
            using (StreamWriter writer = new StreamWriter(currentPath + @"\Texts\Save.txt"))
            {

                
                writer.WriteLine(player.getName());
                writer.WriteLine(player.getClass());
                writer.WriteLine(player.getLvl());
                writer.WriteLine(player.getHealth());
                writer.WriteLine(player.getAtk());
                writer.WriteLine(player.getExp());
                writer.WriteLine(player.getMaxHealth());


            }
        }
    }
}
