using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using adventureGameproject.CombatSystem;

namespace adventureGameproject
{
    class Player : Combat
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
            public int Experiance { get; set; }     

        public void LevelCalc (int ExperianceGained)
        {
            Experiance += ExperianceGained;

            if (Level == 0) {ExperienceNeeded = 100;}

            else
            {
                if(Experiance >= ExperienceNeeded) {Level += 1; ExperienceNeeded += 100; statPoints += 1;} else return;
            }
            
        }

    }
} 

