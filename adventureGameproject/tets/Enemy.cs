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
        public int Health { get; set; }
        public float Attack { get; set; }
        public float Defense { get; set; }
        public float Speed { get; set; }
        public float Level { get; set; }
        public float scaleValue {  get; set; }       
        public int damage { get; set; }


        public int LocalSchale()
        {
            // maby do this in combat class and just return float local schale
            scaleValue = (Health + Attack + Defense) / 8 / 10f;
            Console.WriteLine("schale " + scaleValue);

            Attack *= scaleValue;
            Health = (int) Math.Ceiling((Health * scaleValue));
            Defense *= scaleValue;
            Console.WriteLine(Attack + " attk");
            var damage = Math.Ceiling(Attack);
           
            Console.WriteLine(damage + " damage rounded");

            return (int) damage;
        }

       

    } 


}
 
    
    
