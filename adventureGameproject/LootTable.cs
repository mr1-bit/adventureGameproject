using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace adventureGameproject
{
     class LootTable
    {
        WriteUtils write = new WriteUtils();
        public string result { get; set; }
        public string returnItem { get; set; }
        public string Gamble()
        {

            var rand = new Random();
            
            String[] loot = {"basic", "basic", "basic", "basic", "basic", "basic", "basic", "basic", "basic", "basic", "basic", "basic", 
                "basic", "basic", "basic", "basic", "basic", "basic", "basic", "basic", "basic", "basic", "basic", "basic",  "basic", "basic", "basic",
                "rare", "rare" , "rare", "rare", "rare", "rare", "rare" , "rare", "rare", "rare", "rare", "rare","rare", "rare","ultraRare", "ultraRare", "ultraRare", "legendary"};
            Console.WriteLine();

            var index =  rand.Next(loot.Length);
            // maby switch case?? idk yet tho
            if (loot[index] == "basic")
            {
                write.Write(loot[index], ConsoleColor.DarkGray);

            }
            else if (loot[index] == "rare")
            {
                write.Write(loot[index], ConsoleColor.Cyan);
            }
            else if(loot[index] == "ultraRare") {

                write.Write(loot[index], ConsoleColor.DarkMagenta);
            }
            else if (loot[index] == "legendary")
            {
                write.Write(loot[index], ConsoleColor.Yellow);
            }

             return result = loot[index];
        }

        public string Item(string result = null)
        {
            // add more loot
            //var rand = new Random();
            String[] lootItem = {"Sword"};
           
             string returnItem = result + " " +  lootItem[0];
            if (result == null)
            {
                return "";
            }
            else
            {
                if (result == "basic")
                {
                    write.Write(returnItem, ConsoleColor.DarkGray);

                }
                else if (result == "rare")
                {
                    write.Write(returnItem, ConsoleColor.Cyan);

                }
                else if (result == "ultraRare")
                {
                    write.Write(returnItem, ConsoleColor.DarkMagenta);

                }
                else if (result == "legendary") 
                {
                    write.Write(returnItem, ConsoleColor.Yellow);
                }
                 
            }
               
                return returnItem;
            }
        }
        
    }

