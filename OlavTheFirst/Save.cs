using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OlavTheFirst
{
    internal class Save
    {

        public Save (Player player) {

            using (StreamWriter writer = new StreamWriter(@"C:\C#\OlavTheFirst\OlavTheFirst\OlavTheFirst\Texts\Save.txt"))
            {
                writer.WriteLine(player.getName());
                writer.WriteLine(player.getClass());
                writer.WriteLine(player.getHealth());
                writer.WriteLine(player.getAtk());
                 

            }

        }
    }
}
