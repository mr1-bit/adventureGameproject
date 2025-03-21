using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace adventureGameproject.CombatSystem
{
    public class Combat
    {
        public Combat() { 

        }
        //public int DamageCalc(int x = 0, int y =0)
        //{
        
        //    return x - y;
        //}
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
