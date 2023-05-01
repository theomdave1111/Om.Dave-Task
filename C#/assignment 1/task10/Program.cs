using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                    10) Write a C# program to that takes a number as input and display it
                    four times in a row (separated by blank spaces), and then four times in
                    the next row, with no separation. You should do it 5 times:
                    Test Data:
                    Enter a digit: 9999
                    Expected Output:
                    9999 9999 9999 9999
                    9999999999999999
                    9999 9999 9999 9999
                    9999999999999999
                    9999 9999 9999 9999
                    9999999999999999
                    9999 9999 9999 9999
                    9999999999999999
                    9999 9999 9999 9999
                    9999999999999999
             */


            int num; //Taken variable num.
                Console.WriteLine("Enter a Number : "); //write a line in concole using console.writeline command
                num = Convert.ToInt32(Console.ReadLine()); //taking input from user and stored in num var.

              
            //code to print the num 4 times in row.(Main Logic)
                    Console.WriteLine("{0} {0} {0} {0}", num);
                    Console.WriteLine("{0}{0}{0}{0}", num);
                    Console.WriteLine("{0} {0} {0} {0}", num);
                    Console.WriteLine("{0}{0}{0}{0}", num);
                    Console.WriteLine("{0} {0} {0} {0}", num);
                    Console.WriteLine("{0}{0}{0}{0}", num);
                    Console.WriteLine("{0} {0} {0} {0}", num);
                    Console.WriteLine("{0}{0}{0}{0}", num);
                    Console.WriteLine("{0} {0} {0} {0}", num);
                    Console.WriteLine("{0}{0}{0}{0}", num);

                    Console.ReadKey();

            
        }

    }
}

