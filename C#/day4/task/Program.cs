using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {

        /*
         Task 1:
                Read the number of values in an array and display it in reverse order.
                (Note: Take input from user and Array size 10)
         */

        static void task1()
        {
            try
            {
                int[] arr = new int[10];
                Console.WriteLine("-----------------------------  TASK 1  -----------------------------");

                Console.WriteLine("\n \nEnter an array vlaues ");
                Console.WriteLine("--------------------------------------------------------------------");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("\nElements of an array not in reverse order: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("{0}  ", arr[i]);
                }
                Console.Write("\n");
                Console.Write("\nElements of an array in reverse order: ");
                for (int i = 9; i >= 0; --i)
                {
                    Console.Write("{0}  ", arr[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception has occured {0}", ex.Message);
            }
            Console.ReadKey();
        }

        /*
         Task 2:
                Find sum of all elements of array.
                (Note: Take input from user and Array size 10)
         */

        static void task2()
        {
            try
            {
                int[] arr = new int[10];
                int sum = 0;
                Console.WriteLine("-----------------------------  TASK 2  -----------------------------");
                Console.WriteLine("\n \nEnter the values of an array");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    sum += arr[i];
                }
                Console.WriteLine("Sum of all elements of an array is : {0}", sum);


            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an expection came : {0}", ex.Message);
            }
            Console.ReadKey();
        }


        /*
         Task 3:
                Create a Calculator using C# console application.
                Take a input from the user and perform operation Add,Subtract,Multiplication and
                Division
                Note :
                1) Use Switch case for select option (Enter 1 for Addition, Enter 2 for Subtraction,
                Enter 3 for Multiplication, Enter 4 for Division and Enter 5 for Exit)
                2) Use Exception handling for error catching (Display user perceptive message)
                3) Also use Enum for the Switch Choice.
         */

        enum Operators
        {
            plus = 1,
            minus = 2,
            mul = 3,
            divsion = 4,
            modulo = 5,


        }


        static void task3()
        {

            try
            {
                int num1, num2, ans;
                Console.WriteLine("-----------------------------  TASK 3  -----------------------------");
                Console.Write("Enter the Value of Number 1 : ");
                num1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter the Value of Number 2 : ");
                num2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(" Press 1 for ADDITION of {0} + {1} \n Press 2 for SUBTRACTION of {0} - {1} \n Press 3 for MULTIPLICATION of {0} x {1} \n Press 4 for DIVISION of {0} / {1} \n Press 5 for MODULO of {0} % {1} \n ", num1, num2);
            Case:
                int switchCase = Convert.ToInt32(Console.ReadLine());

                switch (switchCase)
                {
                    case (int)Operators.plus:
                        ans = num1 + num2;
                        Console.WriteLine("{0} + {1} = {2}", num1, num2, ans);
                        break;
                    case (int)Operators.minus:
                        ans = num1 - num2;
                        Console.WriteLine("{0} - {1} = {2}", num1, num2, ans);

                        break;
                    case (int)Operators.mul:
                        ans = num1 * num2;
                        Console.WriteLine("{0} x {1} = {2}", num1, num2, ans);

                        break;
                    case (int)Operators.divsion:
                        ans = num1 / num2;
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, ans);

                        break;
                    case (int)Operators.modulo:
                        ans = num1 % num2;
                        Console.WriteLine("{0} % {1} = {2}", num1, num2, ans);

                        break;
                    default:
                        Console.WriteLine("Please press number from 1-5");
                        goto Case;
                }
            }
            //catch(Exception e)
            //{ 
            //    Console.WriteLine("An Error Ocurred : {0}" , e.ToString());
            //}
            catch (DivideByZeroException)
            {
                Console.WriteLine("A decimal Cannot divide by Zero.");

            }

            Console.ReadKey();
        }

        /*
         Task 4:
                Accept two matrices and check whether they are equal or not. (use two-dimensional
                array)
                (Check screenshot for output of matrix)
                Note: (Take a input from User)
         */
        static void task4()
        {
            try
            {
                int[,] matrix1 = new int[2, 2];
                int[,] matrix2 = new int[2, 2];
                int flag = 1;

                Console.WriteLine("-----------------------------  TASK 4    -----------------------------");
                Console.WriteLine("Enter the First matrix ");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Enter the Second matrix ");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("The Value of matrix 1 is ");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(matrix1[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("The Value of matrix 1 is ");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(matrix2[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (matrix1[i, j] == matrix2[i, j])
                        {
                            flag = 1;
                        }
                        else
                        {
                            flag = 0;

                        }
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("IS EQUAL");
                }
                else
                {
                    Console.WriteLine("IS NOT EQUAL");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error occured : {0}", e.Message);
            }

            Console.ReadLine();
        }

        /*
         Task 5:
                Get the student name and 1 to 8 semester percentage. Display percentage for
                particular semester. (use Array)
         */

        static void task5()
        {
            try
            {
                int[] arr = new int[8];
                int sem, count = 1;
                Console.WriteLine("-----------------------------  TASK 5    -----------------------------");
                Console.Write("Enter the Student Name: ");
                string name = Console.ReadLine();
                Console.WriteLine(name);

                Console.WriteLine("Enter the Percentage of all 8 Semester :-");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("Enter the Percentage of {0}", count);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    if (arr[i] > 100)
                    {
                        Console.WriteLine("Please Enter Right marks of semester {0} ", count);
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    count++;

                }
                Console.WriteLine("Enter the Semester you want get percentage of that semester :-");
                sem = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0} Your Percentage of {1} Semester is :\n{2}", name, sem, arr[sem - 1]);
            }
            catch (Exception e)
            {
                Console.WriteLine("An Error Occured {0}", e.Message);
            }
            Console.ReadKey();
        }
        /*
         Task 6:
                Create a Example that includes all the types of Exception.
                Exception includes like: (Use Nested switch case)
                1) IndexOutOfRangeException
                2) OutOfMemoryException
                3) DivideByZeroException
                4) NullReferenceException
                5) InvalidCastException
                6) ArrayTypeMismatchException
                7) StackOverflowException
         */

        static void task6()
        {
            string message = null;
            try
            {
                Console.WriteLine("-----------------------------  TASK 6    -----------------------------");
                Console.WriteLine("                1) IndexOutOfRangeException\r\n                2) OutOfMemoryException\r\n                3) DivideByZeroException\r\n                4) NullReferenceException\r\n                5) InvalidCastException\r\n                6) ArrayTypeMismatchException");
            gotoStatement:
                int switchCase = Convert.ToInt32(Console.ReadLine());
                switch (switchCase)
                {
                    case 1:
                        //Index Out Of Range Exception:
                        int[] numbers = { 1, 2, 3 };
                        Console.WriteLine(numbers[5]);
                        break;
                    case 2:
                        //Out of memory exception:
                        //here, we are trying to create an array of integers with the maximum possible size.
                        // the array is too large to fit in memory, an OutOfMemoryException is thrown.
                        int[] arr = new int[int.MaxValue];
                        break;
                    case 3:
                        //DivideByZeroException :
                        int a = 5, b = 0;
                        int c = a / b;
                        Console.WriteLine(c);
                        break;
                    case 4:
                        //NullReferenceException :

                        int length = message.Length;
                        Console.WriteLine(message);
                        break;
                    case 5:
                        //InvalidCastException :
                        bool flag = true;
                        Char ch = Convert.ToChar(flag);
                        break;
                    case 6:
                        //ArrayTypeMismatchException :
                        string[] array1 = { "THE", "OM", "DAVE" };
                        object[] array2 = array1;
                        array2[0] = 5;
                        break;
                    default:
                        Console.WriteLine("Please Enter valid Number from 1 to 6 to execute the statement:");
                        Console.WriteLine("===============================================================");
                        goto gotoStatement;
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.ReadKey();

        }


        /*
         Task 7:
                Create one Movie Class with properties like (Id, MovieName, HeroName,
                HeroineName, VillianName, Choreographer, Producer, Director, Composer, Budget,
                MovieReleaseDate, Rating, Profit, IsFlopOrHit).
                1) Add 5 Records (Using List - Add Custom Data)
                2) Display that Five Records in Table
                3) Display the Full Movie details whose Hero Name is Sandip. (Use LinQ)
        */
        class Movie
        {
            public int Id { get; set; }
            public string MovieName { get; set; }
            public string HeroName { get; set; }
            public string HeroineName { get; set; }
            public string VillianName { get; set; }
            public string Choreographer { get; set; }
            public string Producer { get; set; }
            public string Director { get; set; }
            public string Composer { get; set; }
            public decimal Budget { get; set; }
            public DateTime MovieReleaseDate { get; set; }
            public double Rating { get; set; }
            public decimal Profit { get; set; }
            public bool IsFlopOrHit { get; set; }
        }



        static void task7()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie() { Id = 1, MovieName = "The Avengers", HeroName = "Sandip", HeroineName = "Scarlett Johansson", VillianName = "Tom Hiddleston", Choreographer = "Joss Whedon", Producer = "Kevin Feige", Director = "Joss Whedon", Composer = "Alan Silvestri", Budget = 220000000, MovieReleaseDate = new DateTime(2012, 5, 4), Rating = 8.0, Profit = 1518812988, IsFlopOrHit = false });
            movies.Add(new Movie() { Id = 2, MovieName = "Jurassic Park", HeroName = "Sam Neill", HeroineName = "Laura Dern", VillianName = "Tyrannosaurus rex", Choreographer = "Steven Spielberg", Producer = "Kathleen Kennedy", Director = "Steven Spielberg", Composer = "John Williams", Budget = 63000000, MovieReleaseDate = new DateTime(1993, 6, 11), Rating = 8.1, Profit = 1039107193, IsFlopOrHit = false });
            movies.Add(new Movie() { Id = 3, MovieName = "The Godfather", HeroName = "Marlon Brando", HeroineName = "Diane Keaton", VillianName = "Al Pacino", Choreographer = "Francis Ford Coppola", Producer = "Albert S. Ruddy", Director = "Francis Ford Coppola", Composer = "Nino Rota", Budget = 6000000, MovieReleaseDate = new DateTime(1972, 3, 24), Rating = 9.2, Profit = 286000000, IsFlopOrHit = false });
            movies.Add(new Movie() { Id = 4, MovieName = "Gone with the Wind", HeroName = "Clark Gable", HeroineName = "Vivien Leigh", VillianName = "George Reeves", Choreographer = "Victor Fleming", Producer = "David O. Selznick", Director = "Victor Fleming", Composer = "Max Steiner", Budget = 3977000, MovieReleaseDate = new DateTime(1939, 12, 15), Rating = 8.1, Profit = 400176459, IsFlopOrHit = false });
            movies.Add(new Movie() { Id = 5, MovieName = "Avatar", HeroName = "Sam Worthington", HeroineName = "Zoe Saldana", VillianName = "Stephen Lang", Choreographer = "James Cameron", Producer = "James Cameron", Director = "James Cameron", Composer = "James Horner", Budget = 237000000, MovieReleaseDate = new DateTime(2009, 12, 18), Rating = 7.8, Profit = 2787965087, IsFlopOrHit = false });

            Console.WriteLine("ID\tMovie Name\tHero Name\tHeroine Name\tBudget\tRelease Date\tRating\tProfit\tFlop/Hit");
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"{movie.Id}\t{movie.MovieName}\t{movie.HeroName}\t{movie.HeroineName}\t{movie.Budget}\t{movie.MovieReleaseDate.ToShortDateString()}\t{movie.Rating}\t{movie.Profit}\t{movie.IsFlopOrHit}");
            }

            var sandipMovies = from movie in movies
                               where movie.HeroName == "Sandip"
                               select movie;

            Console.WriteLine("\nMovies with Hero Name Sandip:");
            Console.WriteLine("ID\tMovie Name\tHero Name\tHeroine Name\tBudget\tRelease Date\tRating\tProfit\tFlop/Hit");
            foreach (Movie movie in sandipMovies)
            {
                Console.WriteLine($"{movie.Id}\t{movie.MovieName}\t{movie.HeroName}\t{movie.HeroineName}\t{movie.Budget}\t{movie.MovieReleaseDate.ToShortDateString()}\t{movie.Rating}\t{movie.Profit}\t{movie.IsFlopOrHit}");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int switchCase;
            Console.WriteLine("-----------------------------DAY 4 -----------------------------");
            Console.WriteLine("                        Press  1 for Task 1\r\n                        Press  2 for Task 2\r\n                        Press  3 for Task 3\r\n                        Press  4 for Task 4\r\n                        Press  5 for Task 5\r\n                        Press  6 for Task 6\r\n                        Press  7 for Task 7\r\n");
            switchCase = Convert.ToInt32(Console.ReadLine());

        switchCase:
            switch (switchCase)
            {

                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    task5();
                    break;
                case 6:
                    task6();
                    break;
                case 7:
                    task7();
                    break;
                default:
                    Console.WriteLine("Please Enter valid number, To execute the program. ");
                    Console.WriteLine("--------------------------------------------------------------------");
                    switchCase = Convert.ToInt32(Console.ReadLine());
                    goto switchCase;

            }
        }
    }
}
