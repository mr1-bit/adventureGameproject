using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace adventureGameproject
{
    class Enemy : Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }
        public float schaleValue {  get; set; }


        public void Schale()
        {
       
            schaleValue = ((((Health + Attack + Defense) / 8) / 10f));
            Console.WriteLine("schale " + schaleValue);
        }

       

    } 


}
 
    
    
