using System;
using System.Collections.Generic;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Input the number of students: ");

           int studentCount = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("\nInput the names of the students: ");

           string[] students = new string[studentCount];

           for (int i = 0; i < studentCount; i++)
           {
               students[i] = Console.ReadLine();
           }

           Console.WriteLine("--------------------");

           Array.Sort(students);

           Console.WriteLine("Here they are alphabetically: ");

           for (int i = 0; i < studentCount; i++)
           {
               Console.WriteLine(students[i]);
           }

           Console.ReadKey();

        }
    }
}
