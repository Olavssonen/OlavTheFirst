namespace OlavTheFirst
{
    internal class Class
    {

        private String className;
        private int health;
        private int str;

        public Class(String newPlayerClass)
        {
            className = newPlayerClass;


            if (className == "Warrior")
            {

                setStats(0);

            }
            else if (className == "Ranger")
            {
                setStats(9);
            }

        }

        //Read the Classes.txt to get starting stats of different classes
        private void setStats(int line)
        {
            String[] lines = System.IO.File.ReadAllLines(@"C:\C#\OlavTheFirst\OlavTheFirst\OlavTheFirst\Texts\Classes.txt");

            health = Int16.Parse(lines[line + 1]);
            str = Int16.Parse(lines[line + 2]);
            

        }

        public String getPlayerClass()
        {
            return className;
        }

        public String setClass(String newPlayerClass)
        {
            className = newPlayerClass;
            return className;
        }

        public int getStartingHealth()
        {
            return health;
        }

        public int getStartingStr()
        {
            return str;
        }


    }
}
