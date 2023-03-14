using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlavTheFirst
{
    internal class Load
    {
        public Load(Player player) {
            //String text = System.IO.File.ReadAllText(@"C:\C#\OlavTheFirst\OlavTheFirst\OlavTheFirst\Texts\IntroText.txt");
            String[] lines = System.IO.File.ReadAllLines(@"C:\C#\OlavTheFirst\OlavTheFirst\OlavTheFirst\Texts\Save.txt");

            player.setName(lines[0]);
            player.setClass(lines[1]);
            
        }
    }
}
