--====================================--
             --SQL DAY-4--
--====================================--
--1) Write down SQL query to Select Customer Name, EmployeeName,orderno(id),orderdate,Amount.

SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Orders;

SELECT C_FirstName + C_LastName as Customername , E_FirstName + E_LastName as Employee_Name, O_OrderId as orderno,O_OrderDATE as orderdate,O_Amount as Amount    FROM Customers,Employees,Orders; 



--2) write down SQL query to Select customer Name, Count oforders,total order AMOUNT.

SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Orders;
SELECT * FROM Orderdetails;

--SELECT  C_FirstName + C_LastName as Customername FROM  Customers
--SELECT COUNT(C_CustomerId) as Countoforders,SUM(O_Amount) AS AMOUNT FROM Orders group by C_CustomerId

SELECT  C.C_FirstName + C.C_LastName as Customernamem,COUNT(C.C_CustomerId) as Countoforders,SUM(O.O_Amount) AS AMOUNT FROM  Customers C , Orders O WHere C.C_CustomerId = O.C_CustomerId  group by  C.C_FirstName , C.C_LastName 


--3) write down SQL query to Select Employee name, And no oforder assigned to him/her NOTE: Select the Only Employee having more than 3 order

SELECT E.E_FirstName + E.E_LastName AS EMPLOYEE_NAME ,  COUNT(O.E_EmployeeId) AS NO_OF_ORDERS  FROM Employees E, Orders O WHERE E.E_EmployeeId = O.E_EmployeeId GROUP BY E.E_FirstName , E.E_LastName


--4)write down SQL query to Select the Customer and employee in desc order to Name.

SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Orders;
SELECT * FROM Orderdetails;


SELECT * FROM Customers,Employees ORDER BY C_FirstName DESC

--5) write down SQL query to Select TOP 5 Orders which have high discount rate.


SELECT TOP 5 * FROM Orderdetails ORDER BY DiscountRate DESC 


--6) write down SQL query to Select only Orders within last 7 days, last month, Custom Dates(note : create diff Query for All three Criteria )

SELECT * FROM Orders   
WHERE O_OrderDATE BETWEEN '1894-06-22'  AND '1894-07-01'
order by O_OrderDATE DESC

SELECT * FROM Orders   
WHERE O_OrderDATE BETWEEN GETDATE()-28 AND GETDATE()
order by O_OrderDATE DESC

SELECT * FROM Orders   
WHERE O_OrderDATE BETWEEN GETDATE()-7 AND GETDATE()
order by O_OrderDATE DESC

-- 7) write down SQL query to Select employee who has max order

SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Orders;
SELECT * FROM Orderdetails;
--SELECT C_FirstName + C_LastName as Customername , E_FirstName + E_LastName as Employee_Name, O_OrderId as orderno,O_OrderDATE as orderdate,O_Amount as Amount    FROM Customers,Employees,Orders; 

select TOP 1 (select Employees.E_FirstName + ' ' + Employees.E_LastName)as employee_name, 
(select COUNT(*) from Orders where Orders.E_EmployeeId = Employees.E_EmployeeId) as number_of_orders,*
from Employees ORDER BY number_of_orders DESC

--8) write down SQL query to Select customer-orders which order date is less than 10 days
SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Orders;
SELECT * FROM Orderdetails;


SELECT * FROM Orders   
WHERE O_OrderDATE BETWEEN GETDATE()-10 AND GETDATE()
order by O_OrderDATE DESC

--9) write down SQL query to Select the Customer name, Employee name, order no, order Date which have min 2 items.

--SELECT C_FirstName + C_LastName as Customername , E_FirstName + E_LastName as Employee_Name, O_OrderId as orderno,O_OrderDATE as orderdate,O_Amount as Amount    FROM Customers,Employees,Orders; 

SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Orders;
SELECT * FROM Orderdetails;

Select c.C_FirstName,c.C_LastName, e.E_FirstName,e.E_LastName,o.O_OrderId,o.O_OrderDATE
from Customers c,Employees e, Orders o
where o.C_CustomerId = c.C_CustomerId and o.E_EmployeeId = e.E_EmployeeId
group by c.C_FirstName,c.C_LastName, e.E_FirstName,e.E_LastName,o.O_OrderId,o.O_OrderDATE
having MIN(o.O_OrderId) >= 2


--10) write down SQL query to Select Employee vise Average order amount. Here Column should display like Employee name & Average Order Amount

select Employees.E_FirstName + ' ' + Employees.E_LastName as employee_name,
(select avg(Orders.O_Amount) from Orders where Orders.E_EmployeeId = Employees.E_EmployeeId) as average_order_amount
from Employees;


