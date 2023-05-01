--===========================================--
--                TASK - 5                   --
--===========================================--

--For below task use join
--1. write down SQL query to Select Customer Name, Count of orders,total order AMOUNT

SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Orders;
SELECT * FROM Orderdetails;


SELECT CONCAT (C.C_FirstName , C.C_LastName) AS CUSTOMER_NAME, COUNT (O.O_OrderId) AS COUNT_OF_ORDERS ,SUM(O.O_Amount) AS ORDER_AMOUNT 
FROM  Orders AS O 
INNER JOIN  Customers AS C ON C.C_CustomerId = O.C_CustomerId 
GROUP BY C.C_FirstName , C.C_LastName;

--2. write down SQL query to Select Employee name, And no of order assigned to him/her NOTE:
-----------------------Select the Only Employee having more than 3 order
SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Orders;
SELECT * FROM Orderdetails;

SELECT CONCAT (E.E_FirstName, ' ' , E.E_LastName) AS EMPLOYEE_NAME, COUNT(O.E_EmployeeId) AS NO_OF_ORDERS
FROM Employees E
INNER JOIN Orders O ON E.E_EmployeeId = O.E_EmployeeId
GROUP BY E.E_FirstName,E.E_LastName,O.E_EmployeeId ORDER BY O.E_EmployeeId ASC

--3. write down SQL query to Select retrieve all Employee list which are having 0 Order.
SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Orders;
SELECT * FROM Orderdetails;

SELECT CONCAT (E.E_FirstName, ' ' , E.E_LastName) AS EMPLOYEE_NAME, COUNT(O.E_EmployeeId) AS NO_OF_ORDERS
FROM Employees E
INNER JOIN Orders O ON E.E_EmployeeId = O.E_EmployeeId
GROUP BY E.E_FirstName,E.E_LastName,O.E_EmployeeId,E.E_EmployeeId
HAVING COUNT(O.E_EmployeeId) = 0





--4. write down SQL query to Select Customer Name, Employee Name,orderno(id),oderdate,Amount.

SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Orders;
SELECT * FROM Orderdetails;


SELECT Customers.C_UserName as Customer_Name,Employees.E_UserName as Employees_Name,Orders.O_OrderId,Orders.O_OrderDATE,Orders.O_Amount
FROM Customers INNER JOIN Orders
ON Customers.C_CustomerId = Orders.C_CustomerId
INNER JOIN Employees ON Orders.E_EmployeeId = Employees.E_EmployeeId


--5. write down SQL query to Select only Orders within last 7 days, last month, Custom Dates
-------------------------------------------(note :create diff Query for All three Criteria )


SELECT * FROM Orders   
WHERE O_OrderDATE BETWEEN GETDATE()-7 AND GETDATE()
order by O_OrderDATE DESC

SELECT * FROM Orders   
WHERE O_OrderDATE BETWEEN '1894-06-22'  AND '1894-07-01'
order by O_OrderDATE DESC

SELECT * FROM Orders   
WHERE O_OrderDATE BETWEEN GETDATE()-28 AND GETDATE()
order by O_OrderDATE DESC




--6. write down SQL query to Select employee who has max order




select TOP 1 Employees.E_FirstName+' '+Employees.E_LastName as Employees_Name,count(Orders.O_OrderId) as No_of_Orders from Employees Inner join orders
on Employees.E_EmployeeId = Orders.E_EmployeeId
group by Employees.E_FirstName , Employees.E_LastName
order by No_of_Orders desc;



--7. write down SQL query to Select customerOrders which order date is less than 10 days

SELECT  Customers.C_FirstName  + Customers.C_LastName as CustomerName,*
FROM Customers
LEFT  JOIN Orders ON  Customers.C_CustomerId = Orders.C_CustomerId 
WHERE O_OrderDATE >= DATEADD(day,-10, GETDATE());


--8. write down SQL query to Select the Customer name, Employee name, order no, order Date
-----------------------------------------------------------------which have min 2 items.

SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Orders;
SELECT * FROM Orderdetails;

SELECT Customers.C_FirstName  + Customers.C_LastName AS CustomerName
		,Employees.E_FirstName + Employees.E_LastName AS EmployeeName
		,Orders.O_OrderId
		,Orders.O_OrderDATE
FROM Orders  LEFT JOIN Customers  ON Orders.C_CustomerId = Customers.C_CustomerId
			LEFT JOIN  Employees ON Orders.E_EmployeeId = Employees.E_EmployeeId
			LEFT JOIN Orderdetails ON Orderdetails.O_OrderId = Orders.O_OrderId
WHERE  Orderdetails.ItemName IN (SELECT ItemName
							FROM Orderdetails
							GROUP BY ItemName
							HAVING COUNT(*) >=2 
							)

--9. write down SQL query to Select Employee vise Average order amount. Here Column should
--display like Employee name & Average Order Amount


SELECT Employees.E_FirstName + Employees.E_LastName AS EmployeeName , AVG(Orders.O_Amount) AS AverageOrderAmount
FROM Employees
INNER JOIN Orders ON Orders.E_EmployeeId = Employees.E_EmployeeId
GROUP BY Employees.E_FirstName ,Employees.E_LastName




--10. write down SQL query to Select orders which not have any discounts on items.

SELECT *
FROM Orders
LEFT JOIN Orderdetails ON Orders.O_OrderId = Orderdetails.O_OrderId
WHERE Orderdetails.DiscountRate = '0';