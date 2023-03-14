using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int getAtk() {
            return atk;        
        }

        public Boolean checkIfAlive()
        {
            if (health > 0) { 
                return true; 
            }

            else return false; 
        }

    }
}
