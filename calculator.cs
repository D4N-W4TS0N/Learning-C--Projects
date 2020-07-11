using System;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            //This writes a line
            Console.WriteLine("Please type your username below");
            
            //"userName" variable is equal to the user input
            string userName = Console.ReadLine();
            
            //writes a line which also writes the "userName" variable
            Console.WriteLine("\nWelcome, " + userName + ". My name is MultiplicationBot");

            //number variables
            double num01;
            double num02;

            //writes a line
            Console.Write("\nInput a 1st number: ");
            //variable is equal to user input and converts user input to int(number)
            num01 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Input a 2nd number: ");
            num02 = Convert.ToDouble( Console.ReadLine() );
            
            //this multiplies the 2 variables
            double result01 = num01 * num02;

            Console.WriteLine("\nResult Is " + result01);
            
            double num03;
            double num04;
            double num05;

            Console.Write("\nI can also calulate average, Input a 1st number: ");
            num03 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("\nInput a 2nd number: ");
            num04 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("\nInput a 3rd number: ");
            num05 = Convert.ToDouble( Console.ReadLine() );

            double result02 = (num03 + num04 + num05) / 3;

            Console.WriteLine("\nResult Is " + result02);

            double num06;
            double num07;

            Console.Write("\nI can also calulate the percentage of a number, Input a 1st number: ");
            num06 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("\nInput a 2nd number: ");
            num07 = Convert.ToDouble( Console.ReadLine() );

            double result03 = (num06 / 100) * num07;

            Console.WriteLine("\nResult Is " + result03);

            //wait before closing
            Console.ReadKey();
        }
    }
}
