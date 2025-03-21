using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adventureGameproject;


namespace adventureGameproject.CombatSystem
{
    
    public class Combat
    {
        public Combat() { 

        }
        public void Start() 
        {
            Console.WriteLine("entered combat");

        }
        public int TakeDamage(int Health, int takenDamage)
        {
            return Health -= takenDamage;
        }
        public void Stop() 
        {
            Console.WriteLine("ended");
        }
    }
}
