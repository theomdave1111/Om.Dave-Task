using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8) Write a C# Sharp program that takes four numbers as input from user
            //to calculate and print the average.
            int a, b , c,d ,e;
            Console.Write("Enter the value A : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value B : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value C : ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value D : ");
            d = Convert.ToInt32(Console.ReadLine());

            e = (a+b+c+d)/4;
            Console.Write("The average of all the number is : " + e);

            Console.ReadKey();
        }
    }
}
