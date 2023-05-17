using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var departments = new List<Department>()
            {
                new Department() { DepartmentId = 1, Name = ".Net" },
                new Department() { DepartmentId = 2, Name = "Java" },
                new Department() { DepartmentId = 3, Name = "Android" },
                new Department() { DepartmentId = 4, Name = "iOS" },
            };

            // create some employees
            var employees = new List<Employee>()
            {
                new Employee() { EmployeeId = 1, DepartmentId = 1, Name = "John", Salary = 5550000 },
                new Employee() { EmployeeId = 2, DepartmentId = 1, Name = "Jane", Salary = 55000 },
                new Employee() { EmployeeId = 3, DepartmentId = 1, Name = "Bob", Salary = 60000 },
                new Employee() { EmployeeId = 4, DepartmentId = 2, Name = "Tom", Salary = 65000 },
                new Employee() { EmployeeId = 5, DepartmentId = 2, Name = "Mary", Salary = 70000 },
                new Employee() { EmployeeId = 6, DepartmentId = 2, Name = "Jim", Salary = 75000 },
                new Employee() { EmployeeId = 7, DepartmentId = 3, Name = "Sara", Salary = 80000 },
                new Employee() { EmployeeId = 8, DepartmentId = 3, Name = "Jack", Salary = 85000 },
                new Employee() { EmployeeId = 9, DepartmentId = 4, Name = "Lisa", Salary = 90000 },
                new Employee() { EmployeeId = 10, DepartmentId = 4, Name = "Mike", Salary = 95000 }
            };

            Console.WriteLine("Welcome to the Employee and Department application!");

            Console.WriteLine("---------------------------------------------------------------");

            try
            {
                while (true)
                {
                    Console.WriteLine("Please choose one of the following options:");
                    Console.WriteLine("1. View the number of employees in each department");
                    Console.WriteLine("2. Find the department of a particular employee");
                    Console.WriteLine("3. Get the second highest salary from employees");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("5. Press to exit console");
                    int input = Convert.ToInt32(Console.ReadLine());


                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Department\tNo. Of Employees");
                            Console.WriteLine("-------------------------------------");
                            foreach (var dept in departments)
                            {
                                int count = employees.Where(emp => emp.DepartmentId == dept.DepartmentId).Count();
                                Console.WriteLine($"{dept.Name}\t          \t{count}");
                            }
                            Console.WriteLine("-------------------------------------");

                            break;

                        case 2:

                            Console.WriteLine("Please enter the name of the employee:");
                            string empName = Console.ReadLine();

                            var employee = employees.FirstOrDefault(emp => emp.Name == empName);
                            if (employee != null)
                            {
                                var department = departments.FirstOrDefault(dept => dept.DepartmentId == employee.DepartmentId);
                                Console.WriteLine($"The employee with name {employee.Name} is working as {department.Name} Developer");
                            }
                            else
                            {
                                Console.WriteLine($"No employee found with name {empName}");
                            }

                            break;

                        case 3:

                            var HighestSalary = employees.OrderByDescending(emp => emp.Salary).Skip(0).FirstOrDefault();
                            Console.WriteLine($"Employee: {HighestSalary.Name} \tSalary: {HighestSalary.Salary}");

                            break;

                        case 4:

                            Console.WriteLine("Thank you for using the Employee and Department application!");
                            break;

                        case 5:

                            return;

                        default:

                            Console.WriteLine("Invalid input. Please try again.");

                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}