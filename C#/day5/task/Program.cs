using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Program
    {
        //declared an enum class for switch case.
        enum SwitchCase
        {
            task1 = 1, task2 = 2, task3 = 3, exit = 4
        }

        /*
         Task 1:
                200 bullies standing in a circle in an order 1 to 200. No. 1 has a Gun. He kills the next bully
                (i.e. No. 2)  and gives the Gun to the next (i.e. No. 3). All bullies do the same until only 1 survives. Which number survives at the last? There are 200 people starting from 1 to 200. 
                - make a c# program using arrays and for loop
         */
        static void task1()
        {
            List<int> bullies = new List<int>();
            for (int i = 1; i <= 200; i++)
            {
                bullies.Add(i);
            }
            int currentBully = 0;

            while (bullies.Count > 1)
            {
                int nextBully = (currentBully + 1) % bullies.Count;
                bullies.RemoveAt(nextBully);
                currentBully = nextBully;
            }

            Console.WriteLine("The Bully no {0} survived to last.", bullies[0]);
            Console.ReadLine();
        }




        /*
         Task 2:
                There are 100 closed doors. 
                A cage holding 100 Lions is placed nearby. Every Lions that visits a door either opens a closed door or closes an open door.
                The first Lion that is let out of the cage visits and opens all the hundred doors. 
                The second Lion that is released visits doors of the order 2, 4, 6, 8, 10…. 
                The third Lion released visits doors 3, 6, 9, 12, 15……, and so on.
                After all the Lions from the cage are released and have opened or closed at least one door, 
                1) How many doors are left open? and 
                2) Which doors are left open?
         */


        static void task2()
        {
            bool[] doors = new bool[100];
            for (int i = 1; i <= 100; i++)
            {
                for (int j = i - 1; j < 100; j += i)
                {

                    doors[j] = !doors[j];
                }
            }

            int openDoorsCount = 0;
            Console.Write("The Open doors are : ");
            for (int i = 0; i < 100; i++)
            {
                if (doors[i] == true)
                {
                    openDoorsCount++;
                    Console.Write((i + 1) + " ");
                }
            }
            Console.WriteLine("\nTotal open doors: " + openDoorsCount);

            Console.ReadLine();
        }

        /*
         Task 3:
                Swapping the neighbor character in the user defined string.

                For Example:
                User Defined String
                SANDIP SANJAYBHAI PARMAR

                Output String:
                ASDNPIS NAAJBYAH IAPMRRA
         */
        static void task3()
        {
            Console.WriteLine("Enter any string : ");
            string userString = Console.ReadLine();
            char[] arr = userString.ToCharArray();
            StringBuilder s = new StringBuilder();
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (i != arr.Length - 1)
                {
                    s.Append(arr[i + 1]);
                }
                s.Append(arr[i]);
                i += 1;
            }
            Console.WriteLine("After Swapping : {0}", s.ToString());
            Console.ReadLine();
        }


        static void Main(string[] args)
        {

            Console.WriteLine("+=======================================================================+");
            Console.WriteLine("                              TASK OF DAY 5                              ");
            Console.WriteLine("+=======================================================================+");
            Console.WriteLine("                            Enter 1 for Task1\r\n                            Enter 2 for Task2 \r\n                            Enter 3 fro Task3 \r\n                            Enter 4 for Exit");
        switchCase:
            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case (int)SwitchCase.task1:
                    task1();
                    break;
                case (int)SwitchCase.task2:
                    task2();
                    break;
                case (int)SwitchCase.task3:
                    task3();
                    break;
                case (int)SwitchCase.exit:
                    break;
                default:
                    Console.WriteLine("Please Enter valid number to execute task");
                    goto switchCase;

            }

        }
    }
}
