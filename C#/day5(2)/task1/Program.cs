using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {


        /*
          Task 1:
                Get the 10 students details (StudentName, Percentage of sem1,sem2...sem8) and
                ask the user for select Student Name and Semester. you need to search
                StudentName and Semester from the list and display the below details. 
                (Note: you have to use the Dictionary for display below details.)
                Hello {Name}!
                You got {Percentage}% in semester{semester}&#39;s.
                Pass Status:{PassStaus}
                Token description :
                {Name}: User Name
                {Semester}: user&#39;s selected semester
                {Percentage}: user&#39;s percentage of selected semester
                {PassStaus}: if user&#39;s percent &gt; 35 then Pass else Failed
         */

        static void Main(string[] args)
        {
            try
            {
                studentDetails s1 = new studentDetails()
            {
                Name = "Om",
                Semester1 = 80,
                Semester2 = 75,
                Semester3 = 30,
                Semester4 = 40,
                Semester5 = 58,
                Semester6 = 69,
                Semester7 = 72,
                Semester8 = 32,
             
            };
            studentDetails s2 = new studentDetails()
            {
                Name = "Rohan",
                Semester1 = 80,
                Semester2 = 75,
                Semester3 = 30,
                Semester4 = 40,
                Semester5 = 58,
                Semester6 = 69,
                Semester7 = 72,
                Semester8 = 32,

            };
            studentDetails s3 = new studentDetails()
            {
                Name = "Smit",
                Semester1 = 80,
                Semester2 = 75,
                Semester3 = 30,
                Semester4 = 40,
                Semester5 = 58,
                Semester6 = 69,
                Semester7 = 72,
                Semester8 = 32,

            };
            studentDetails s4 = new studentDetails()
            {
                Name = "Kishan",
                Semester1 = 80,
                Semester2 = 75,
                Semester3 = 30,
                Semester4 = 40,
                Semester5 = 58,
                Semester6 = 69,
                Semester7 = 72,
                Semester8 = 32,

            };
            studentDetails s5 = new studentDetails()
            {
                Name = "Akashdeep",
                Semester1 = 80,
                Semester2 = 75,
                Semester3 = 30,
                Semester4 = 40,
                Semester5 = 58,
                Semester6 = 69,
                Semester7 = 72,
                Semester8 = 32,

            };
            studentDetails s6 = new studentDetails()
            {
                Name = "Ritik",
                Semester1 = 80,
                Semester2 = 75,
                Semester3 = 30,
                Semester4 = 40,
                Semester5 = 58,
                Semester6 = 69,
                Semester7 = 72,
                Semester8 = 32,

            };
            studentDetails s7 = new studentDetails()
            {
                Name = "Iqbal",
                Semester1 = 80,
                Semester2 = 75,
                Semester3 = 30,
                Semester4 = 40,
                Semester5 = 58,
                Semester6 = 69,
                Semester7 = 72,
                Semester8 = 32,

            };
            studentDetails s8 = new studentDetails()
            {
                Name = "Deep",
                Semester1 = 80,
                Semester2 = 75,
                Semester3 = 30,
                Semester4 = 40,
                Semester5 = 58,
                Semester6 = 69,
                Semester7 = 72,
                Semester8 = 32,

            };
            studentDetails s9 = new studentDetails()
            {
                Name = "Jenil",
                Semester1 = 80,
                Semester2 = 75,
                Semester3 = 30,
                Semester4 = 40,
                Semester5 = 58,
                Semester6 = 69,
                Semester7 = 72,
                Semester8 = 32,

            };
            studentDetails s10 = new studentDetails()
            {
                Name = "Yash",
                Semester1 = 80,
                Semester2 = 75,
                Semester3 = 30,
                Semester4 = 40,
                Semester5 = 58,
                Semester6 = 69,
                Semester7 = 72,
                Semester8 = 32,

            };


            Dictionary<string, studentDetails> students = new Dictionary<string, studentDetails>();
            students.Add(s1.Name, s1);
            students.Add(s2.Name, s2);
            students.Add(s3.Name, s3);
            students.Add(s4.Name, s4);
            students.Add(s5.Name, s5);
            students.Add(s6.Name, s6);
            students.Add(s7.Name, s7);
            students.Add(s8.Name, s8);
            students.Add(s9.Name, s9);
            students.Add(s10.Name, s10);

            float semPercentage;

            Console.WriteLine("Enter Name Of Student: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter the Semester: ");
        semEster:
            int sem = Convert.ToInt32(Console.ReadLine());


            if (students.ContainsKey(studentName))
            {
                foreach (KeyValuePair<string, studentDetails> s in students)
                {
                    studentDetails st = s.Value;
                    Console.WriteLine("Hello ! {0}", studentName);

                    switch (sem)
                    {
                        case 1:
                            Console.WriteLine("You got {0}% in Semester {1}", st.Semester1, sem);

                            semPercentage = st.Semester1;
                            break;
                        case 2:
                            Console.WriteLine("You got {0}% in Semester {1}", st.Semester2, sem);

                            semPercentage = st.Semester2;

                            break;
                        case 3:
                            Console.WriteLine("You got {0}% in Semester {1}", st.Semester3, sem);

                            semPercentage = st.Semester3;

                            break;
                        case 4:
                            Console.WriteLine("You got {0}% in Semester {1}", st.Semester4, sem);

                            semPercentage = st.Semester4;
                            break;
                        case 5:
                            Console.WriteLine("You got {0}% in Semester {1}", st.Semester5, sem);

                            semPercentage = st.Semester5;
                            break;
                        case 6:
                            Console.WriteLine("You got {0}% in Semester {1}", st.Semester6, sem);

                            semPercentage = st.Semester6;
                            break;
                        case 7:
                            Console.WriteLine("You got {0}% in Semester {1}", st.Semester7, sem);

                             semPercentage = st.Semester7;
                            break;
                        case 8:
                            Console.WriteLine("You got {0}% in Semester {1}", st.Semester8, sem);

                            semPercentage = st.Semester8;
                            break;

                        default:
                            Console.WriteLine("Enter a valid semester:");
                            goto semEster;
                    }

                    if (semPercentage > 35)
                    {
                        Console.WriteLine(" Pass Status: PASS");
                    }
                    else
                    {
                        Console.WriteLine(" Pass Status: FAIL");

                    }
                    break;
                }

            }
                
                else
                {
                    Console.WriteLine("the student name is not in the list");

                }
                
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
          
            Console.ReadKey();

        }

        class studentDetails
        {

            public string Name { get; set; }
            public int Semester1 { get; set; }
            public int Semester2 { get; set; }
            public int Semester3 { get; set; }
            public int Semester4 { get; set; }
            public int Semester5 { get; set; }
            public int Semester6 { get; set; }
            public int Semester7 { get; set; }
            public int Semester8 { get; set; }


        }

    }
}
