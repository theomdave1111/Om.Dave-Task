using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;
            Console.Write("Enter the value A : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value B : ");
            b = Convert.ToInt32(Console.ReadLine());

            x = a;
            a = b;
            b = x;
            Console.Write("Now \n A = " + a + "\n & \n B = " + b);
            Console.ReadLine();
        }
    }
}
