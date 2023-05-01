USE [Om Dave];


-- SELECT TABLES

SELECT * FROM emp_salary;
SELECT * FROM  emp_Ddept;
SELECT * FROM emp_employee;
SELECT * FROM client_table;
SELECT * FROM country;
SELECT * FROM project;
SELECT * FROM empproject;



-- DROP TABLES

DROP TABLE emp_salary;
DROP TABLE emp_Ddept;
DROP TABLE emp_employee;
DROP TABLE client_table;
DROP TABLE country;
DROP TABLE project;
DROP TABLE empproject;

-- TABLE- 1

CREATE TABLE emp_salary(
empid INT PRIMARY KEY,
salary INT ,
ispermanent VARCHAR(200)
); 
INSERT INTO emp_salary 
VALUES(101,2000,'Yes'),
(102,10000,'Yes'),
(103,5000,'No'),
(104,1900,'Yes'),
(105,2300,'Yes')

-- TABLE- 2 

CREATE TABLE emp_Ddept(
deptid VARCHAR(20) primary key,
dept_name VARCHAR(20),
dept_off VARCHAR(20),
dept_head INT
);
INSERT INTO  emp_Ddept
VALUES('E-101' , 'HR' , 'MONDAY' , 105),
('E-102' , 'DEVELOPMENT' , 'TUESDAY' , 101),
('E-103' , 'HOUSE KEEPING' , 'SATURDAY' , 103),
('E-104' , 'SALES' , 'SUNDAY' , 104),
('E-105' , 'PURCHASE' , 'TUESDAY' , 104)

-- TABLE- 3

CREATE TABLE emp_employee(
empid INT PRIMARY KEY,
empname VARCHAR(20),
department VARCHAR(20),
contact_no BIGINT ,
emailid VARCHAR(20),
empheadid INT
);
INSERT INTO emp_employee
VALUES(101 , 'ISHA' , 'E-101' ,1234567890, 'abc@gmail.com' ,  105),
(102 , 'PRIYA' , 'E-104' ,1234567890, 'abc@gmail.com' ,  103),
(103 , 'NEHA' , 'E-101' ,1234567890, 'abc@gmail.com' ,  101),
(104 , 'RAHUL' , 'E-102' ,1234567890, 'abc@gmail.com' ,  105),
(105 , 'ABHISHEK' , 'E-101' ,1234567890, 'abc@gmail.com' ,  102)

-- TABLE- 4

CREATE TABLE client_table(
clientid VARCHAR(20) PRIMARY KEY, 
clientname VARCHAR(20),
cid VARCHAR(20) 
);
INSERT INTO client_table
VALUES('cl-1' , 'ABC GROUP' , 'C-1'),
('cl-2' , 'PQR' , 'C-1'),
('cl-3' , 'XYZ' , 'C-2'),
('cl-4' , 'TECH ALUMINIUM' , 'C-3'),
('cl-5' , 'ABC MNP' , 'C-5')

-- TABLE- 5

CREATE TABLE country(
cid VARCHAR(20) PRIMARY KEY,
cname VARCHAR(20),
);
INSERT INTO country
VALUES('C-1', 'INDIA'  ),
('C-2', 'CHINA'  ),
('C-3', 'USA'  ),
('C-4', 'PAKISTAN'  ),
('C-5', 'RUSSIA'  )

-- TABLE- 6

CREATE TABLE project(
projectid VARCHAR(20) PRIMARY KEY,
duration INT,
);
INSERT INTO project
VALUES('p-1', 23 ),
('p-2', 15 ),
('p-3', 45 ),
('p-4', 2 ),
('p-5', 30)


-- TABLE- 7

CREATE TABLE empproject(
empid INT PRIMARY KEY,
projectid VARCHAR(20),
clientid VARCHAR(20),
startyear INT,
endyear INT
);
INSERT INTO empproject
VALUES(101 , 'p-1','cl-1' , 2010 , 2010),
(102 , 'p-2','cl-2' , 2010 , 2012),
(103 , 'p-1','cl-3' , 2013 , NULL ),
(104 , 'p-4','cl-1' , 2014 , 2015),
(105 , 'p-4','cl-5' , 2015 , NULL )


------------------------------------------QUERIES----------------------------------------------

--1. Select the detail of the employee whose name start with P.

SELECT * FROM emp_employee WHERE empname LIKE 'P%';

--2. How many permanent candidate take salary more than 5000.

SELECT * FROM emp_salary WHERE salary  > 5000;

--3. Select the detail of employee whose emailId is in gmail.

SELECT * FROM emp_employee WHERE emailid like '%@gmail.com';

--4. Select the details of the employee who work either for department E-104 or E-102.

SELECT * FROM emp_employee WHERE department ='E-102' or department='E-104'

--5. What is the department name for DeptID E-102?

SELECT dept_name FROM emp_Ddept WHERE deptid = 'E-102';

--6. What is total salarythat is paid to permanent employees?]

SELECT SUM(salary) FROM emp_salary WHERE ispermanent = 'Yes';

--7. List name of all employees whose name ends with a.

SELECT * FROM emp_employee WHERE empname LIKE '%A';

--8. List the number of department of employees in each project.

SELECT COUNT(empid) , projectid FROM empproject GROUP BY projectid

--9. How many project started in year 2010.

SELECT * FROM empproject WHERE startyear = 2010;

--10. How many project started and finished in the same year.

SELECT * FROM empproject WHERE startyear = endyear;

--11. select the name of the employee whose name's 3rd charactor is 'h'.

SELECT * FROM emp_employee WHERE empname LIKE '__H%';

--12. Select the department name of the company which is assigned to the employee whose employee id is grater 103.

SELECT dept_name FROM emp_Ddept INNER JOIN emp_employee ON deptid = department WHERE empid >103 

--13. Select the name of the employee who is working under Abhishek.

SELECT empname FROM emp_employee WHERE empheadid = (SELECT empid FROM emp_employee WHERE empname = 'abhishek');

--14. Select the name of the employee who is department head of HR.

SELECT empname FROM emp_employee INNER JOIN emp_Ddept ON deptid = department WHERE dept_name= 'HR' 

--15. Select the name of the employee head who is permanent.

SELECT empname  FROM emp_employee e INNER JOIN emp_salary ee ON ee.empid = e.empid WHERE ispermanent = 'Yes'

--16. Select the name and email of the Dept Head who is not Permanent.

SELECT empname , emailid FROM emp_employee e INNER JOIN  emp_Ddept ed on e.empheadid = ed.dept_head INNER JOIN emp_salary es on e.empid = es.empid 
WHERE ispermanent = 'No'

--17. Select the employee whose department off is monday

SELECT emp_employee.* FROM emp_employee INNER JOIN emp_Ddept ON deptid = department WHERE emp_Ddept.dept_off = 'MONDAY'

--18. select the indian clinets details.

SELECT CT.* FROM client_table CT INNER JOIN country C ON CT.cid = C.cid  WHERE C.cname = 'INDIA'

--19. select the details of all employee working in development department.

SELECT EE.* FROM emp_Ddept ED INNER JOIN emp_employee EE ON EE.department = ED.deptid WHERE ED.dept_name = 'DEVELOPMENT'


--20. select the non-indian clinets details.

SELECT CT.* FROM country C INNER JOIN client_table CT ON C.cid = CT.cid WHERE C.cname != 'INDIA'
