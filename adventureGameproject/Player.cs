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
            public int ExperienceNeeded { get; set; }
            public int Damage { get; set; }
            public int statPoints { get; set; }

        
        public void DealDamage(int AttackValue = 1)
        {
            Console.WriteLine(AttackValue);
           
        }

        public void levelCalc (int lvl, int Experiance)
        {
            if (Level == 1) {ExperienceNeeded = 100;}
            else if (Level == 2) {ExperienceNeeded += 50; statPoints += 1;}
            else if (Level == 3) { }
            else if (Level == 4) { }
            else if (Level == 5) { }

        }

    }
} 

