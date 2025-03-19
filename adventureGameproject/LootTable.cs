using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventureGameproject
{
     class LootTable
    {
        public void Gamble()
        {
            var rand = new Random();
            String[] loot = {"1", "1", "1", "1", "1", "1", "1", "1" , "1", "1", "1", "1"};
            Console.WriteLine();
            var index =  rand.Next(loot.Length);
            Console.WriteLine(index);

            
        }
    }
}
