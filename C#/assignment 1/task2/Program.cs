using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Write a C# Sharp program to print the Addition, Subtraction, Division and Multiplication of 5 numbers. (Custom Numbers)

            int a = 40 , b = 20 ;
            Console.WriteLine("The value A : " + a);
            Console.WriteLine("The value B : " + b);
         
            
            Console.WriteLine($"Addition of all Number is : {a}+{b} = {a + b }" );
            Console.WriteLine($"Multiplication of all Number is : {a}*{b} = {a * b }");
            Console.WriteLine($"Subtraction of all Number is : {a}-{b}= {a - b }");
            Console.WriteLine($"Division of all Number is : {a}/{b} = {(a / b) }");

            Console.ReadLine();

        }
    }
}
