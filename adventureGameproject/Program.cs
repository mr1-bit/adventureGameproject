// See https://aka.ms/new-console-template for more information

// changes the color of the console text
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

            write.Write("asd", ConsoleColor.Green);

            player.Name = Console.ReadLine();
            player.Attack = 10;
            enemy.Attack = 12;

            write.Write("welcome " + player.Name, ConsoleColor.Green);

            write.Write("starting in 1990",  ConsoleColor.Green);

            player.DealDamage(player.Attack);

            enemy.DealDamage(enemy.Attack);
            Schaling schaling = new Schaling(player.Attack, enemy.Attack);

            enemy.Health = schaling.schale;
            Console.WriteLine("enemy health: " + enemy.Health);








        }
    }
}




    