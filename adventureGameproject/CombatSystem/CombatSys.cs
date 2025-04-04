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

        WriteUtils wr = new WriteUtils();

        public string Name;
        public int Age;

        public int Health;
        public float Attack;
        public float Defense;
        public int Speed;

        public int Level;

        public virtual void Construct(string name, int age, int health, float attack, float defense, int speed)
        {
            Name = name;
            Age = age;
            Health = health;
            Attack = attack;
            Defense = defense;
            Speed = speed;
        }

        public void Start(string name) 
        {
            wr.Write("entered combat");
            wr.Write("a " + name + " has appeared");

        }
        public int TakeDamage(int Health, int takenDamage)
        {
            return Health -= takenDamage;
        }
        public int DealDamage(int EHealth, int DamageDealt)
        {
            return EHealth -= DamageDealt;
        }


        public void Stop(string name, string action = "defeat") 
        {
            if (action == "run")
            {
                wr.Write("you ran away from " + name);
            }
            else wr.Write("you defeated " + name, ConsoleColor.Green);
        }

        public void SpeedCheck(int playerSpeed, int enemySpeed)
        {
            if (playerSpeed > enemySpeed)
            {
                wr.Write("you attack first");
            }
            else
            {
                wr.Write("enemy attacks first");
            }
        }
    }
}
