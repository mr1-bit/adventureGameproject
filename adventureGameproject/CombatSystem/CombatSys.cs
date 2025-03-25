using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adventureGameproject;
using adventureGameproject.tets;


namespace adventureGameproject.CombatSystem
{
    
    public class Combat
    {
        public Combat() { 

        }
        public void Start(string name) 
        {
            Console.WriteLine("entered combat");
            Console.WriteLine("a " + name + " has appeared");

        }
        public int TakeDamage(int Health, int takenDamage)
        {
            return Health -= takenDamage;
        }
        public int DealDamage(int Health, int DamageDealt)
        {
            return Health -= DamageDealt;
        }


        public void Stop(string name) 
        {
            Console.WriteLine("you defeated " + name);
        }
    }
}
