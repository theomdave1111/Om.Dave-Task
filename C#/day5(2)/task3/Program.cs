using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        public static void file1()
        {
            
        }
        static void task3()
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("         Bill Generator File       ");
            Console.WriteLine("===================================");
            Console.Write("Enter The Customer ID :- ");
            int id = Convert.ToInt32(Console.ReadLine());   
            Console.Write("Enter The Customer Name :- ");
            string name = Console.ReadLine();   
            Console.Write("Enter the Number :- ");
            long number = Convert.ToInt64(Console.ReadLine());  
            Console.Write("Enter the No. Of Items :- ");
            int noItems = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you Like To Generate a bill ? press y/n");
            char yn = Convert.ToChar(Console.ReadLine());
            if (yn == 'y')
            {
                string filepath = "D:\\Projects\\om.dave\\C#\\day5(2)\\task3\test.txt";
                if (File.Exists(filepath))
                {
                   File.Delete(filepath);
                    if (noItems >= 1)
                    {
                        int[] prizes = new int[noItems];
                        int[] qtys = new int[noItems];
                        int[] total = new int[noItems];
                        int count = 0;

                        for (int i = 0; i < noItems; i++)
                        {

                            count++;
                            Console.WriteLine("Enter the Prize of item {0}", count);
                            prizes[i] = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Enter the Quantity of Item {0}", count);
                            qtys[i] = Convert.ToInt16(Console.ReadLine());

                        }
                        FileStream f = new FileStream(@"D:\\Projects\\om.dave\\C#\\day5(2)\\task3\test.txt", FileMode.Create);
                        StreamWriter s = new StreamWriter(f);
                        s.WriteLine("Bill\n=====================================");
                        s.WriteLine("Customer ID : {0}", id);
                        s.WriteLine("Name        : {0}", name);
                        s.WriteLine("Number      : {0}", number);
                        s.WriteLine("\nItems      Prize       Qty     Total");
                        s.WriteLine("--------------------------------------");


                        for (int i = 0; i < noItems; i++)
                        {
                            total[i] = prizes[i] * qtys[i];
                            s.WriteLine("Item-{0}     {1}         {2}       {3}", i, prizes[i], qtys[i], total[i]);
                        }
                        s.Close();
                        f.Close();
                        Console.WriteLine("File created successfully...");
                    }
                    else
                    {
                        Console.WriteLine("There is No Item To Generate Bill");
                    }
                }
                else
                {
                    if (noItems >= 1)
                    {
                        int[] prizes = new int[noItems];
                        int[] qtys = new int[noItems];
                        int[] total = new int[noItems];
                        int count = 0;

                        for (int i = 0; i < noItems; i++)
                        {

                            count++;
                            Console.WriteLine("Enter the Prize of item {0}", count);
                            prizes[i] = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Enter the Quantity of Item {0}", count);
                            qtys[i] = Convert.ToInt16(Console.ReadLine());

                        }
                        FileStream f = new FileStream(@"D:\\Projects\\om.dave\\C#\\day5(2)\\task3\test.txt", FileMode.Create);
                        StreamWriter s = new StreamWriter(f);
                        s.WriteLine("Bill\n=====================================");
                        s.WriteLine("Customer ID : {0}", id);
                        s.WriteLine("Name        : {0}", name);
                        s.WriteLine("Number      : {0}", number);
                        s.WriteLine("\nItems      Prize       Qty     Total");
                        s.WriteLine("--------------------------------------");


                        for (int i = 0; i < noItems; i++)
                        {
                            total[i] = prizes[i] * qtys[i];
                            s.WriteLine("Item-{0}     {1}         {2}       {3}", i, prizes[i], qtys[i], total[i]);
                        }
                        s.Close();
                        f.Close();
                        Console.WriteLine("File created successfully...");
                    }
                    else
                    {
                        Console.WriteLine("There is No Item To Generate Bill");
                    }


                }

            }
            else
            {
                Console.WriteLine("OKay ! Thank You");
            }



            

            Console.ReadLine();

       }
        class Items
        {
            public int itemno { get; set; }
            public int itemPrize { get; set; }
            public int itemQty { get; set; }

            public int itemTotal { get; set; }
        }

        static void Main(string[] args)
        {
            /*
             
             Task 3: 
                    Write code to generate product bill.
                    - Take input for CustomrId, Name, Number, Number Of Item.
                    - Now run loop based on Number Of Item and take input for Item Name, Quantity, Prize
                    - Create a class for item details with properties.
                    - At last take confirmation input("Do you want to print bill?") if type "Yes" then display bill info like below.

                    CustomerId: ORD123456
                    Name: Abc Xyz
                    Number: 123456798

                    Item Prize Qty Total
                    -------------------------------------------------
                    Item - 1 10.50 2 21.00
                    Item - 2 15.00 3 45.00
                    Item - 3 08.00 1 08.00
                    Item - 4 10.00 2 20.00

                    TOTAL: 94.00
                    9% Tax: 08.46
                    GRANT TOTAL: 85.54

                    - Save the above result in the Text file.
                    - Create the text file in your project directory.
                    - Create the directory if not exist.
                    - If already exits file with the same name then delete the first existing file and create the new one.

             */

            try 
            { 
                task3();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
