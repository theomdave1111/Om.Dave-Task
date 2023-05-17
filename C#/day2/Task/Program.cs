using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace task1
{
    internal class Program
    {
        /*
         Task 1:
            Write code to take input string from user and count the number of capital
            letter,small letter,special character and number.
         */
        static void Task1()
        {
            Console.Write("ENter a string:");
            string stringTask1 = Console.ReadLine();
            Console.WriteLine(stringTask1);

            int upperCase = 0, lowerCase = 0, number = 0, specialChar = 0;

            for (int i = 0; i < stringTask1.Length; i++)
            {
                char ch = stringTask1[i];
                if (ch >= 'A' && ch <= 'Z')
                    upperCase++;
                else if (ch >= 'a' && ch <= 'z')
                    lowerCase++;
                else if (ch >= '0' && ch <= '9')
                    number++;
                else
                    specialChar++;
            }
            Console.WriteLine("Upper case letters in string are : " + upperCase);
            Console.WriteLine("Lower case letters in string are: " + lowerCase);
            Console.WriteLine("Numbers in string are : " + number);
            Console.Write("Special characters in string are: " + specialChar);

            Console.ReadKey();
        }

        /*
         Task 2:
            Write a code to display pattern. User will ask for number of rows and on basis of
            value pattern should draw.
            Check screenshot for output of task2.
         */
        static void Task2()
        {
            Console.WriteLine("Enter number of rows");
            int intTask2 = Convert.ToInt32(Console.ReadLine());
            int number = 0, space = intTask2 - 1;
            for (int i = 0; i <= intTask2; i++)
            {
                for (int j = 0; j <= space; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= number; k++)
                {
                    Console.Write("*");
                }
                if (space > i)
                {
                    space = space - 1;
                    number = number + 2;
                }
                if (space < i)
                {
                    space = space + 1;
                    number = number - 2;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        /*
         Task 3:
            Write a program to display Today’s date in different formats.   
         */

        static void Task3()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString("yyyy-mm-dd"));
            Console.WriteLine(date.ToString("yyyy-dd-mm"));
            Console.WriteLine(date.ToString("dd-mm-yyyy"));
            Console.WriteLine(date.ToString("dd-yyyy-dd"));
            Console.WriteLine(date.ToString("mm-dd-yyyy"));
            Console.WriteLine(date.ToString("mm-yyyy-dd"));
            Console.ReadKey();
        }

        /*
         Task 4:
            Write a program to implement the simple ATM services.
            It’s like to Check Current Balance, Deposit the Amount, Withdraw the Amount,
            Change Pin
            Note:
            1) Take Amount and Pin number should be static and based on that all other
            transaction should be perform.
            2) Use switch case for the choice. (For Example 1 for Check Current Balance, 2 for
            Deposit the Amount, 3 for Withdraw the Amount, 4 for Change Pin.)

         */

        static void Task4()
        {
            Console.WriteLine(" ATM Service : \r\n        1) For Check Current Balance.\r\n        2) For Deposit the Amount.\r\n        3) For withdraw the Amount.\r\n        4) For change Pin");
            int numTask4 = Convert.ToInt32(Console.ReadLine());
            int currentBalance = 5000, deposit, withdraw, x, pin = 2112;
            switch (numTask4)
            {
                case 1:
                    Console.WriteLine("Current Balance : " + currentBalance);
                    break;

                case 2:
                    Console.WriteLine("How much amount you want to deposit in account");
                    deposit = Convert.ToInt32(Console.ReadLine());
                    currentBalance = currentBalance + deposit;
                    Console.WriteLine("Your amount is deposited\n");
                    Console.WriteLine("Your Updated Balance :" + currentBalance);
                    break;

                case 3:
                    Console.WriteLine("How much amount you want to Withdraw in account");
                    withdraw = Convert.ToInt32(Console.ReadLine());
                    if (withdraw < currentBalance)
                    {

                        currentBalance = currentBalance - withdraw;
                    }
                    else
                    {

                        Console.WriteLine("your withdraw amount is greater than current balance\n to check the current balance press 1 \n to again withdraw amount press 2 \n press other to exit");
                        x = Convert.ToInt32(Console.ReadLine());
                        if (x == 1)
                        {
                            goto case 1;
                        }
                        else if (x == 2)
                        {
                            goto case 3;
                        }
                        else
                        {
                            break;
                        }
                    }

                    Console.WriteLine("Your amount is deposited\n");
                    Console.WriteLine("Your Updated Balance :" + currentBalance);
                    break;

                case 4:
                    Console.WriteLine($"Your previous pin is : {pin}");
                    pin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Your Updated pin is : {pin}");

                    break;

                default:
                    break;

            }





            Console.ReadKey();
        }


        /*
         Task 5:
            Write a C# program to generate 10 digit Random Number.
         */

        static void Task5()
        {
            Random tenDigit = new Random();
            Console.WriteLine(tenDigit.Next(0, 1999999999).ToString("d10"));
            Console.ReadLine();
        }

        /*
         Task 6:
            Write a program to display the Elder person from age.
            Note: Take a Two Age number from the User and Based on that two age find the
            Elder person. (Validate the Age.)
         */
        static void Task6()
        {
            Console.Write("Enter th age of x ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter th age of y ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {

                Console.WriteLine("The Elder person is x");
            }
            else
            {

                Console.WriteLine("The Elder person is y");
            }
            Console.ReadKey();
        }

        /*
         Task 7:
            Write a C# Program to Use All the Math function of C#. (Max, Min, Sqrt, Abs, Round)
         */
        static void Task7()
        {
            Console.WriteLine("MAX VALUE FROM 50 and 100  :" + Math.Max(50, 100));
            Console.WriteLine("MIN VALUE FROM 50 and 100  :" + Math.Min(50, 100));
            Console.WriteLine("SQRT OF 64                 :" + Math.Sqrt(64));
            Console.WriteLine("ABSOLUTE +ve VALUE OF -6.7 :" + Math.Abs(-6.7));
            Console.WriteLine("ROUND OFF 9.999            :" + Math.Round(9.99));
            Console.ReadKey();

        }

        /*
         Task 8:
            Write a program to Use All the String function of C#. (Length, ToUpper, ToLower,
            Concat, IndexOf, SubString).
         */

        static void Task8()
        {
            Console.WriteLine("Enter any string :");
            string text = Console.ReadLine(), text2 = "Hello this is string of text 2", concat;

            Console.WriteLine("The length of the text string is               : " + text.Length);
            Console.WriteLine("String is Converted in Uppercase               :" + text.ToUpper());
            Console.WriteLine("String is Converted in Lowercase               :" + text.ToLower());
            concat = text + " " + text2;
            Console.WriteLine("Concated String                                :" + concat);
            Console.WriteLine("The alphabet at index 1 of concat string is    :" + concat[1]);
            Console.WriteLine("This metghod gives index of e                  :" + concat.IndexOf("e"));
            Console.WriteLine("Substring from index of 'e' from concat string :" + concat.Substring(concat.IndexOf("e")));

            Console.ReadKey();
        }


        /*
         Task 9:
            Write a C# Sharp program to find the sum of first 10 natural numbers.
         */

        static void Task9()
        {
            int sum = 0;
            Console.WriteLine("The Sum of first 10 natural number is ");
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        /*
         Task 10:
            Write a program in C# Sharp to display the cube of the number up to given an
            integer. (Take a number as a user input)

         */
        static void Task10()
        {
            Console.Write("Input number of Terms : ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Number is : {i} and Cube ot the {i} is {i * i * i}");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {


            Console.WriteLine(" Enter value to execute program :\r\n            1) For Count the characters type \r\n            2) For Pattern\r\n            3) For Date Display \r\n            4) For ATM service\r\n            5) For Random Number\r\n            6) For Find Elder person\r\n            7) For Math Functions\r\n            8) For String Functions\r\n            9) For Sum of Digit \r\n            10) For Cube display \r\n                  and\r\n            Press Other for exit.");
            int num = Convert.ToInt32(Console.ReadLine());
            ; switch (num)
            {
                case 1:
                    Task1();
                    break;

                case 2:
                    Task2();
                    break;

                case 3:
                    Task3();
                    break;

                case 4:
                    Task4();
                    break;

                case 5:
                    Task5();
                    break;

                case 6:
                    Task6();
                    break;

                case 7:
                    Task7();
                    break;

                case 8:
                    Task8();
                    break;

                case 9:
                    Task9();
                    break;

                case 10:
                    Task10();
                    break;

                default:
                    break;
            }

        }

    }
}
