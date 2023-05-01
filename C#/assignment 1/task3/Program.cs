using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            3) Write a C# Sharp program to print on screen the output of adding,
            //subtracting, multiplying and dividing of two numbers which will be
            //entered by the user.
            int a, b;
            Console.Write("Enter the value A : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value B : ");
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("What you want to do ");
            Console.Write("For \n Addition a and b press 1 \n Multiply a and b press 2 \n Subtraction a and b press 3 \n Division a and b press 4 : ");
            var x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine(a * b);
                    break;
                case 3:
                    Console.WriteLine(a - b);
                    break;
                case 4:
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Enter valid input from 1,2,3,4");
                    break;
            }

            Console.ReadLine();

        }
    }
}
