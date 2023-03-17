namespace OlavTheFirst
{


    internal class Monster
    {

        string name;
        int health;
        int atk;
        Boolean alive;

        public Monster()
        {
            name = "The Blob";
            health = 6;
            atk = 1;
            alive = true;
        }

        public String getName()
        {
            return name;
        }

        public void loseHealth(int dmg)
        {
            health -= dmg;
        }

        public int getHealth()
        {
            return health;
        }
        public int getAtk()
        {
            return atk;
        }

        //Checks if the monster is alive. Returns false if dead
        public Boolean checkIfAlive()
        {
            if (health > 0)
            {
                return true;
            }

            else return false;
        }

    }
}
