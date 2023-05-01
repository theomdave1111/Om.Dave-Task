/*
 Task 4:
Create a program to accept 5 values from user and calculate the total and average of
those value.
- Accept 5 values from user using console screen (use Console.ReadLine())
- Number should be like (int or float)
 */

decimal a, b, c, d, e , sum;
Console.WriteLine("Enter any Five Numbers to Find an average of it ? ");
Console.Write("Enter 1st Value : ");
a = Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter 2nd  Value : ");
b = Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter 3rd Value : ");
c = Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter 4th Value : ");
d = Convert.ToDecimal(Console.ReadLine());
Console.Write("Enter 5th Value : ");
e = Convert.ToDecimal(Console.ReadLine());

sum = (a + b + c + d + e) / 5;
Console.WriteLine($"The average of Five number is {sum}");