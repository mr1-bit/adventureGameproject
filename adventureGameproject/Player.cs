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
            public int ExperienceNeeded;

            public int Damage;

            public int statPoints;

            public int Experiance;     

        public void LevelCalc (int ExperianceGained)
        {
            Experiance += ExperianceGained;

            if (Level == 0) {ExperienceNeeded = 100;}

            else
            {
                if(Experiance >= ExperienceNeeded) {Level += 1; ExperienceNeeded += 100; statPoints += 1;} else return;
            }
            
        }
        public override void Construct(string name, int age, int health, float attack, float defense, int speed)
        {
            base.Construct(name, age, health, attack, defense, speed);
            Health = health;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            Damage = (int)Math.Ceiling(Attack);

        }

    }
} 

