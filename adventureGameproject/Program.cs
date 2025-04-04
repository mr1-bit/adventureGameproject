// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using System;
using adventureGameproject.tets;
using adventureGameproject.CombatSystem;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;



namespace adventureGameproject
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteUtils.Write("enter a username", ConsoleColor.Cyan);

            
            WriteUtils wr = new WriteUtils();
            Player player = new Player();
            Enemy enemy = new Enemy();
            LootTable table = new LootTable();
            Combat combat = new Combat();
            table.Item(table.Gamble());

            enemy.Construct("testE", 1, 50, 6f, 4f, 10);


            Console.WriteLine(enemy.Attack);
            Console.WriteLine(enemy.Defense);
            Console.WriteLine(enemy.Health);


            wr.Write("stats before schale", ConsoleColor.Green);
            wr.Write("wasd", ConsoleColor.Green);

            String NamePlayer = Console.ReadLine();
            player.Construct(NamePlayer, 20, 100, 10f, 15f, 10);
            //player.Construct(player.Name, player.Age, player.Health, player.Attack, player.Defense, player.Speed);

            player.Health -= enemy.LocalSchale();
            Console.WriteLine("after schaleing");
            Console.WriteLine(enemy.Attack);
            Console.WriteLine(enemy.Defense);
            Console.WriteLine(enemy.Health);

            bool playerTurn = false;



            wr.Write("welcome " + player.Name, ConsoleColor.Green);
            // tower escape dungeon lvl story
            wr.Write("starting in 1990",  ConsoleColor.Green);
            wr.Write("you are a " + player.Name, ConsoleColor.Green);
            wr.Write("you are " + player.Age + " years old", ConsoleColor.Green);
            wr.Write("you find yourself in a tower", ConsoleColor.DarkMagenta);
            wr.Write("Use your skills to escape", ConsoleColor.Green);
            wr.Write("Good luck", ConsoleColor.Red);
            wr.Write("difficulty: easy", ConsoleColor.Green);
            wr.Write("start");
            Console.WriteLine(enemy.Attack + " attk");
            wr.Write("encounter an enemy", ConsoleColor.Red);
            combat.Start(enemy.Name);


            if (player.Speed < enemy.Speed)
            { 
                playerTurn = false;             
            }
            else if (player.Speed > enemy.Speed)
            {
               playerTurn = true;         
            }

            if (playerTurn) {
                wr.Write("type a to acctak");
                string attackUsed = Console.ReadLine();
                if (attackUsed == "a")
                {
                    enemy.Health -= (int) player.Attack;
                }
                else
                {
                    return;
                }
            }
            else
            {
                player.Health -= enemy.damage;
            }





                //Schaling schaling = new Schaling(player.Attack, enemy.Attack);

                //enemy.Health = schaling.schale;
                Console.WriteLine("player health: " + player.Health);

            Console.WriteLine("enemy health: " + enemy.Health);
            combat.Stop(name: enemy.Name);








        }
    }
}




    