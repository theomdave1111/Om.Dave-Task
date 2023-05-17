using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task1
{

   
    internal class Program
    {

        // declaring an Enum class
        enum switchCase
        {
            Task1=1, Task2=2, Task3=3, Task4=4
        }


        /*
       Create a console application which will print mark-sheet as per user input.
          - Get the below details from the user
          - Student Name
          - Student Enrollment-number
          - Subject name (fixed 5 subjects only),
          - Subject Marks (out of 100) - Validate the marks (Marks should not be greater then
          100)
          - As per input you need to calculate percentage and define grade as per percentage.
          Note : If grade is F then display &quot;Failed&quot; other wise &quot;Passed&quot; in bottom of mark-
          sheet. -(Refer attached image(marksheet.png) for output format).
          -(Use If else if else or you can use ternary operator also.)
          -(Use Enum for Grade.)
       */
        static void Task1()
        {
            string name;
            int erno, egMarks, math3Marks, pyMarks, totalMarks;
            float percentageMarks;
            Console.Write("Please Enter student name  : ");
            name = Console.ReadLine();
            Console.Write("Please Enter Enrollment No : ");
            erno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter E.G Marks     : ");
            egMarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter Maths III     : ");
            math3Marks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter Python        : ");
            pyMarks = Convert.ToInt32(Console.ReadLine());
            totalMarks = (egMarks + math3Marks + pyMarks);
            percentageMarks = totalMarks / 3;
            StringBuilder s = new StringBuilder();
            s.AppendLine("=================================================================================");
            s.AppendLine("                                MARKSHEET                                        ");
            s.AppendLine("=================================================================================");
            s.AppendLine($"Name           : {name}");
            s.AppendLine($"Enrollment No. : {erno}");
            s.AppendLine("=================================================================================");
            s.AppendLine("Subject                       Out Of marks                            Total marks");
            s.AppendLine($"E.G                               100                                  {egMarks}");
            s.AppendLine($"Maths III                         100                                  {math3Marks}");
            s.AppendLine($"E.G                               100                                  {pyMarks}");
            s.AppendLine("=================================================================================");
            s.AppendLine($"Total                             300                                  {totalMarks}");
            s.AppendLine($"Percentage                        {percentageMarks}%                                   {percentageMarks}");

            if (percentageMarks > 75)
            {
                s.AppendLine($"Grade                              A                                             ");
                s.AppendLine("=================================================================================");
                s.AppendLine("Congratulation you passed this exam with A Grade.");

            }
            else if (percentageMarks > 60)
            {
                s.AppendLine($"Grade                              B                                             ");
                s.AppendLine("=================================================================================");
                s.AppendLine("Congratulation you passed this exam with B Grade.");

            }
            else if (percentageMarks > 45)
            {
                s.AppendLine($"Grade                              C                                             ");
                s.AppendLine("=================================================================================");
                s.AppendLine("Congratulation you passed this exam with C Grade.");

            }
            else if (percentageMarks > 33)
            {
                s.AppendLine($"Grade                              D                                             ");
                s.AppendLine("=================================================================================");
                s.AppendLine("Congratulation you passed this exam with D Grade.");

            }
            else
            {
                s.AppendLine($"Grade                             FAIL                                          ");
                s.AppendLine("=================================================================================");
                s.AppendLine("You Failed the Exam");
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }


        /*
         Task 2:
            Create a console program which will generate Random password with length of 8
            character.
            - Password must contain 2 small letters, 2 capital letters, 2 special characters and 2
            numbers.
            Note : Every time password should be different.
            (User String builder for append the password characters.)
         */
       
        static void Task2()
        {

            char character;

            // string builder.
            StringBuilder s = new StringBuilder();

            //random number of 4 digit.
            Random random = new Random();
            s.Append(random.Next(1000,9999));

            //string of 4 character in lower case
            for(int i = 1; i < 5; i++)
            {
                character = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                s.Append(character);

            }
            //string of 4 character in upper case
            for (int i = 1; i < 5; i++)
            {
                character = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 97 )));
                s.Append(character);

            }

            Console.WriteLine(s);
            Console.ReadKey();
        }



        /*
         Task 3:
            Display the pattern like right angle triangle with number increased by 1.
            Check screenshot for output of task3.
         */

        static void Task3()
        {
            int rows , number = 1;
            StringBuilder s = new StringBuilder();

            Console.WriteLine("Display the pattern like right angle triangle with number increased by 1.");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.Write("\nInput number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for(int i = 0;i < rows; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write( number + " ");
                    number++;
                }
                Console.Write("\n");
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }


        /*
         Task 4:
            1) Display the pattern like Floyd&#39;s Triangle.
            Check screenshot for output.
         */

        enum number
        {
            One = 0,
            Two = 1
        }

        static void Task4()
        {
            int rows, num;
            Console.WriteLine("Print The Floyds Triangle");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("\nInput Numbers of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for(int i = 0;i<= rows; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    if (i % 2 == 0 )
                    {
                        if(j % 2 == 0)
                        {
                        num = (int)number.Two;
                        }
                        else
                        {
                            num = (int)number.One;

                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            num = (int)number.One;
                        }
                        else
                        {
                            num = (int)number.Two;
                            
                        }
                    }
                    
                    Console.Write( num +" ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Press 1 for task1 \nPress 2 for task2 \nPress 3 for task3 \nPress 4 for task4 \n");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());


            switch (caseSwitch)
            {
                case (int)switchCase.Task1:
                    Task1();
                    break;

                case (int)switchCase.Task2:
                    Task2();
                    break;

                case (int)switchCase.Task3:
                    Task3();
                    break;

                case (int)switchCase.Task4:
                    Task4();
                    break;

                default:
                    break;
            }

        }
    }
}
