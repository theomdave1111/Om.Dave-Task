/*
 Task 3:
Create a C# Program to accept Employee details and print those detail in the Console
Application.
- Need to create a class for Employee and define below properties(use appropriate
data type like string, int, decimal)
- Employee ID
- Employee First Name
- Employee Last Name
- Designation
- Current Salary
- Expected Salary
- Job Profile
- Address(City, State, Country)
- Mobile Number
- Accept information from user using console screen (use Console.ReadLine())

-Create object of Employee class using information from the user input
- Display information using Employee class object.
- Display the all details like Table Sheet (Use your skills for display the console.)
 */

class Employee
{
    int employeeID;
    string firstName;
    string lastName;
    string designation;
    int currentSalary;
    int expectedSalary;
    string jobprofile;
    string address;
    decimal mobileNumber;


    static void Main(string[] args)
    {
        Employee myObj = new Employee();
        Console.WriteLine("Enter Your Employee Id ");
        myObj.employeeID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Your  First Name ");
        myObj.firstName = Console.ReadLine();
        Console.WriteLine("Enter Your Last Name ");
        myObj.lastName = Console.ReadLine();
        Console.WriteLine("Enter Your Designatiom ");
        myObj.designation = Console.ReadLine();
        Console.WriteLine("Enter Your Current Salary ");
        myObj.currentSalary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Your Expected Salary :");
        myObj.expectedSalary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Your Job Profile ");
        myObj.jobprofile = Console.ReadLine();
        Console.WriteLine("Enter Your Address (City, State, Country) ");
        myObj.address = Console.ReadLine();
        Console.WriteLine("Enter Your Mobile Number ");
        myObj.mobileNumber = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("=============================================");
        Console.WriteLine($"|| EMPLOYEE ID      : {myObj.employeeID}              ||");
        Console.WriteLine($"|| FIRST NAME       : {myObj.firstName}              ||");
        Console.WriteLine($"|| LAST NAME        : {myObj.lastName}              ||");
        Console.WriteLine($"|| DESIGNATION      : {myObj.designation}              ||");
        Console.WriteLine($"|| CURRENT SALARY   : {myObj.currentSalary}              ||");
        Console.WriteLine($"|| EXPECTED SALARY  : {myObj.expectedSalary}              ||");
        Console.WriteLine($"|| JOB PROFILE      : {myObj.jobprofile}              ||");
        Console.WriteLine($"|| ADDRESS          : {myObj.address}              ||");
        Console.WriteLine($"|| MOBILE NUMBER    : {myObj.mobileNumber}              ||");
        Console.WriteLine("=============================================");





    }

}