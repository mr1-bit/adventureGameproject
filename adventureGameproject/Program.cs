// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using System;


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

            table.Item(table.Gamble());



            enemy.Level = 1f;
            enemy.Attack = 6f;
            enemy.Defense = 4f;
            enemy.Health = 50f;

            enemy.LocalSchale();


            write.Write("wasd", ConsoleColor.Green);

            player.Name = Console.ReadLine();
            player.Attack = 10;
           

            write.Write("welcome " + player.Name, ConsoleColor.Green);

            write.Write("starting in 1990",  ConsoleColor.Green);
            Console.WriteLine(enemy.Attack + " attk");

            player.DealDamage(player.Attack);

            //Schaling schaling = new Schaling(player.Attack, enemy.Attack);

            //enemy.Health = schaling.schale;
            Console.WriteLine("enemy health: " + enemy.Health);








        }
    }
}




    