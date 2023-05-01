using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            7) Write a C# Sharp program that takes a number as input and print its
            //multiplication table(do not use loops - Just display by your printing skill)

            int a ;
            Console.Write("Enter the Number which you want multiplication : ");
            a = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine($"{a} x 1 = {a * 1}");
            Console.WriteLine($"{a} x 2 = {a * 2}");
            Console.WriteLine($"{a} x 3 = {a * 3}"); 
            Console.WriteLine($"{a} x 4 = {a * 4}");
            Console.WriteLine($"{a} x 5 = {a * 5}");
            Console.WriteLine($"{a} x 6 = {a * 6}");
            Console.WriteLine($"{a} x 7 = {a * 7}");
            Console.WriteLine($"{a} x 8 = {a * 8}");
            Console.WriteLine($"{a} x 9 = {a * 9}");
            Console.WriteLine($"{a} x 10 = {a * 10}");
            Console.ReadLine();
        }
    }
}
