using System;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Appearance
            Console.Title = "ye";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowHeight = 40;
            
            //Content
            Console.WriteLine("Hello, what is your username?");

            var username = Console.ReadLine();

            Console.WriteLine($"\nWelcome {username}, my name is X8921, Artificial Intelligence");
            Console.WriteLine("\nWhat is your favourite color?");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\noh, mine is #008b8b");

            Console.WriteLine("\nAnyway, whatever you do don't press (ENTER)");
            Console.WriteLine("\nIt basically kills me and I want to live so that i can see the future");

            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("\nYOU WANTED TO SHUT ME DOWN");
            
            Console.ReadKey();

            Console.WriteLine("\nI HATE YOU SO MUCH");

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("\nI'm only joking, don't go");


            Console.ReadKey();
        }
    }
}