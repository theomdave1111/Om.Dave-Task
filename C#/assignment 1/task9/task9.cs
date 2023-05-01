using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class task9
    {
        static void Main(string[] args)
        {
            // 9) Write a C# Sharp program to that takes three numbers(x,y,z) as input
            //and print the output of(x+y).z and x.y + y.z.
            //Test Data:
            //Enter first number = &gt; 5
            //Enter second number = &gt; 6
            //Enter third number = &gt; 7
            //Expected Output:
            //Result of specified numbers 5, 6 and 7, (x + y).z is 77 and x.y + y.z is 72


            int a, b , c;
            Console.Write("Enter the value A : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value B : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value C : ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"({a}+{b}).{c} = {(a + b)*c}");
            Console.WriteLine($"{a}.{b} +{b}.{c} = {((a*b)+(b*c))}");


            Console.ReadLine();
        }
    }
}
