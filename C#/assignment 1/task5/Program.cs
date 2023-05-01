using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Write a C# Sharp program to swap two numbers (Custom Numbers).

            int x = 10 , y = 20 ; 

            Console.WriteLine(" Value of A : " + x);
            Console.WriteLine(" Value of B : " + y);

            x = x + y;
            y = x - y;
            x = x - y;

            Console.Write("Now \n A = " + x + "\n & \n B = " + y );
            Console.ReadLine();
        }
    }
}
