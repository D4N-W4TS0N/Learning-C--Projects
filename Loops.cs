using System;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
           Random numberGen = new Random();
            
           int roll1 = 0;
           int roll2 = 1;
           int attempts = 0;

           Console.WriteLine("Press ENTER to roll the dice");

           while (roll1 != roll2)
           {
               Console.ReadKey();

               roll1 = numberGen.Next(1, 7);
               roll2 = numberGen.Next(1, 7);

               Console.WriteLine("You rolled: " + roll1);
               Console.WriteLine("You rolled: " + roll2 + "\n");
               attempts++;
           }

           Console.WriteLine("It took you " + attempts + " attempts to roll a two-of-a-kind");

           Console.ReadKey();

        }
    }
}
