﻿using System;
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

        public void Start(string name) 
        {
            wr.Write("entered combat");
            wr.Write("a " + name + " has appeared");

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
            wr.Write("you defeated " + name, ConsoleColor.Green);
        }
    }
}
