--Create a table named "employees" with columns "id", "name", "age","salary", and "department". Insert some sample data into the table.

--Table EmployeesTask3.
create table EmployeesTask3(
id int identity(1,1) primary key,
e_name varchar(20) not null ,
age int not null,
salary bigint not null,
department varchar(20)
);

drop table EmployeesTask3;

select * from EmployeesTask3;

insert into EmployeesTask3(e_name,age,salary,department) values('John doe',30,50000,'Sales'),
('Jane Smith',25,40000,'Marketing'),
('Bob Johnson',35,60000,'Engineering'),
('Mary Davis',23,45000,'Human Resources'),
('Tom Brown',42,30000,'Finance'),
('James Lee',26,42000,'Marketing'),
('Jasmine Chen',29,55000,'Sales'),
('David Kim',32,67000,'Engineering'),
('Sarah Lee',31,62000,'Finance'),
('Andrew Nguyen',27,43000,'Human Resources'),
('Samantha Smith',34,71000,'Marketing'),
('Michael Johnson',33,34000,'Engineering'),
('Jennifer Lee',23,33000,'Sales'),
('Richard Brown',40,90000,'Finance'),
('Julia Kim',33,63000,'Marketing'),
('Daniel Hernandez',39,87000,'Engineering'),
('Emily Davis',26,41000,'Human Resources'),
('William Chen',30,58000,'Sales'),
('Karen Smith',23,46000,'Marketing'),
('Jonathan Lee',36,75000,'Engineering');

--Write a SELECT statement to retrieve all columns and rows from the"employees" table.
Select * from EmployeesTask3;

--Write a SELECT statement to retrieve only the "name" and "salary" columns from the "employees" table.
Select e_name,salary from EmployeesTask3;

--Write a SELECT statement to retrieve the names of all employees who are over 30 years old.
select e_name from EmployeesTask3 where age>30;

--Write a SELECT statement to retrieve the names and salaries of all employees who work in the "sales" department.
select e_name,salary from EmployeesTask3 where  department = 'Sales';

--Write a SELECT statement to retrieve the names and salaries of all employees who earn more than $50,000 per year and work in the"marketing" department.
select e_name , salary from EmployeesTask3 where salary > 50000 and department = 'Marketing';

--Write a SELECT statement to retrieve the average salary of all employees.
select avg(salary) as 'Average Salary' from EmployeesTask3;

--Write a SELECT statement to retrieve the total salary paid to all employees.
select sum(salary) as 'Total Salary' from EmployeesTask3;

--Write a SELECT statement to retrieve the highest salary earned by any employee.
select max(salary) as 'Highest Salary' from EmployeesTask3;

--Write a SELECT statement to retrieve the names and salaries of the top 5 earners in the company.
select e_name , salary from EmployeesTask3 where salary in (select distinct top 5 salary from EmployeesTask3 order by salary desc);