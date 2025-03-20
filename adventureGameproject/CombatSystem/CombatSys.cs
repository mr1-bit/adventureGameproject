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
        public int DamageCalc(int x = 0, int y =0)
        {
            //String[] data = { sender, Damage.ToString(), reciever };         
            return x + y;
        }
        public void Start() 
        {
            Console.WriteLine("entered combat");

        }
        public void Stop() 
        {
            Console.WriteLine("ended");
        }
    }
}
