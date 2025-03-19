using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace adventureGameproject.tets
{
    class Enemy
    {
        public string Name { get; set; }
        public float Age { get; set; }
        public float Health { get; set; }
        public float Attack { get; set; }
        public float Defense { get; set; }
        public float Speed { get; set; }
        public float Level { get; set; }
        public float scaleValue {  get; set; }


        public float LocalSchale()
        {
       
            scaleValue = (Health + Attack + Defense) / 8 / 10f;
            Console.WriteLine("schale " + scaleValue);

            Attack *= scaleValue;
            Health *= scaleValue;
            Defense *= scaleValue;
            Console.WriteLine(Attack + " attk");

            return Attack;
        }

       

    } 


}
 
    
    
