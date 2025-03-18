// See https://aka.ms/new-console-template for more information

// changes the color of the console text
using System.Security.Cryptography.X509Certificates;
using System;


namespace adventureGameproject
{
    class Program
    {
        public static class WriteUtils
        {
            public static void Write(string text, ConsoleColor color)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ForegroundColor = ConsoleColor.White;
            }
            public static void ClearConsole()
            {
                Console.Clear();

            }
        }



        static void Main(string[] args)
        {
            WriteUtils.Write("enter a username", ConsoleColor.Cyan);

            

            Player player = new Player();
            Enemy enemy = new Enemy();
            

            player.Name = Console.ReadLine();
            player.Attack = 10;
            enemy.Attack = 12;

            WriteUtils.Write("welcome " + player.Name, ConsoleColor.Green);

            WriteUtils.Write("starting in 1990",  ConsoleColor.Green);

            player.DealDamage(player.Attack);

            enemy.DealDamage(enemy.Attack);
            Schaling schaling = new Schaling(player.Attack, enemy.Attack);

            enemy.Health = schaling.schale;
            Console.WriteLine("enemy health: " + enemy.Health);








        }
    }
}




    