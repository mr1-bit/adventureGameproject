using System;
using adventureGameproject.CombatSystem;


namespace adventureGameproject.tets
{
    class Enemy : Combat
    {
        public float scaleValue {  get; set; }       
        public int damage { get; set; }


        public int LocalSchale()
        {
            // maby do this in combat class and just return float local schale
            scaleValue = (Health + Attack + Defense) / 8 / 10f;
            Console.WriteLine("schale " + scaleValue);

            Attack *= scaleValue;
            Health = (int) Math.Ceiling((Health * scaleValue));
            Defense *= scaleValue;
            Console.WriteLine(Attack + " attk");
            var damage = Math.Ceiling(Attack);
           
            Console.WriteLine(damage + " damage rounded");

            return (int) damage;
        }

      

       

    } 


}
 
    
    
