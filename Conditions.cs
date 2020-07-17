using System;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
           int answer1;
           int answer2;
           int answer3;

           Console.WriteLine("Hello, and welcome to maths");
           Console.WriteLine("What is 3 + 4 x 6?");

           Console.WriteLine("Your answer:");
           answer1 = Convert.ToInt32(Console.ReadLine());

           if (answer1 == 27)
           {
               Console.WriteLine("\nCorrect");
           }
           else
           {
               Console.WriteLine("\nWrong");
           }






           Console.WriteLine("Hello, and welcome to maths");
           Console.WriteLine("What is 8 x 3 divided by 6?");

           Console.WriteLine("Your answer:");
           answer2 = Convert.ToInt32(Console.ReadLine());

           if (answer2 == 4)
           {
               Console.WriteLine("\nCorrect");
           }
           else
           {
               Console.WriteLine("\nWrong");
           }






           Console.WriteLine("Hello, and welcome to maths");
           Console.WriteLine("What is 9 x 7 divided by 3?");

           Console.WriteLine("Your answer:");
           answer3 = Convert.ToInt32(Console.ReadLine());

           if (answer3 == 21)
           {
               Console.WriteLine("\nCorrect");
           }
           else
           {
               Console.WriteLine("\nWrong");
           }

           Console.ReadKey();

        }
    }
}
