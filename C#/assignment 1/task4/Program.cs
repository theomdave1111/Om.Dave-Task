using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            4) Write a C# Sharp program to print the result of the specified
            //operations.
            //a) -10 + 4 + 16 + 19 * 6

            Console.WriteLine($"-10 + 4 + 16 + 19 * 6 =  { -10 + 4 + 16 + 19 * 6 }") ;
            //b) (40 + 5 + 10 - 55) % 10
            Console.WriteLine($"(40 + 5 + 10 - 55) % 10 = {(40 + 5 + 10 - 55) % 10}");
            //c) 146 + -67 * 67 / 22
            Console.WriteLine($"146 + -67 * 67 / 22 = {146 + -67 * 67 / 22}");
            //d) 222 + 1578 / 9 * 10 - 34 % 22
            Console.WriteLine($"222 + 1578 / 9 * 10 - 34 % 22 = {222 + 1578 / 9 * 10 - 34 % 22}");

            Console.ReadLine();

        }
    }
}
