// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using System;
using adventureGameproject.tets;
using adventureGameproject.CombatSystem;



namespace adventureGameproject
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteUtils.Write("enter a username", ConsoleColor.Cyan);

            
            WriteUtils write = new WriteUtils();
            Player player = new Player();
            Enemy enemy = new Enemy();
            LootTable table = new LootTable();
            Combat combat = new Combat();

            table.Item(table.Gamble());
            



            enemy.Level = 1f;
            enemy.Attack = 6f;
            enemy.Defense = 4f;
            enemy.Health = 50;


            Console.WriteLine(enemy.Attack);
            Console.WriteLine(enemy.Defense);
            Console.WriteLine(enemy.Health);


            write.Write("stats before schale", ConsoleColor.Green);
            write.Write("wasd", ConsoleColor.Green);

            player.Name = Console.ReadLine();
            player.Attack = 10;
            player.Health = 100;

            player.Health -= enemy.LocalSchale();
            Console.WriteLine("after schaleing");
            Console.WriteLine(enemy.Attack);
            Console.WriteLine(enemy.Defense);
            Console.WriteLine(enemy.Health);



            write.Write("welcome " + player.Name, ConsoleColor.Green);

            write.Write("starting in 1990",  ConsoleColor.Green);
            Console.WriteLine(enemy.Attack + " attk");

            combat.Start();

            //Schaling schaling = new Schaling(player.Attack, enemy.Attack);

            //enemy.Health = schaling.schale;
            Console.WriteLine("player health: " +  player.Health);

            Console.WriteLine("enemy health: " + enemy.Health);








        }
    }
}




    