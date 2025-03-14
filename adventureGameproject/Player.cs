using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventureGameproject
{
    class Player
    {
            public string Name { get; set; }
            public int Age { get; set; }
            public int Health { get; set; }
            public int Attack { get; set; }
            public int Defense { get; set; }
            public int Speed { get; set; }
            public int Level { get; set; }
            public int Experience { get; set; }
            public int Damage { get; set; }

        
        public void DealDamage(int AttackValue = 1)
        {
            Console.WriteLine(AttackValue);
           
        }

    }
} 

