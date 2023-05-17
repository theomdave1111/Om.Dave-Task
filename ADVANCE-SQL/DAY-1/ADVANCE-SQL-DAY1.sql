use [Om Dave];


-------------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------- TASK - 1 -----------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------
--User Defined Function
--1) Write a SQL Function to Check the Number is Odd or Even.

-- CREATE a user defined function to find the number is odd

CREATE FUNCTION dbo.isEvenOdd(@num INT)
RETURNS VARCHAR(20)
AS
BEGIN 
DECLARE @ans VARCHAR(10)
IF (@num % 2 ) = 0
	SET @ans = 'EVEN'
ELSE
	SET @ans = 'ODD'
RETURN @ans;
END
--calling user defined function
SELECT dbo.isEvenOdd(8);


-------------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------- TASK - 2 -----------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE OrdersDay1(
id	INT NOT NULL,
order_date DATE NOT NULL,
customer_id INT NOT NULL,
store VARCHAR(20) NOT NULL,
employee_id INT NOT NULL,
amount INT NOT NULL
) 

INSERT INTO OrdersDay1
VAlUES
(101,'05-01-2023',234,'east',11,211),
(102,'06-01-2023',151,'east',12,511),
(103,'07-01-2023',244,'south',13,845),
(104,'08-01-2023',811,'south',11,1265),
(105,'09-01-2023',125,'west',14,285),
(106,'10-01-2023',952,'west',12,355);


SELECT * FROM OrdersDay1

DROP TABLE OrdersDay1
--- made cte

WITH cte 
AS
  (
		SELECT id , amount, store
		FROM OrdersDay1
		
   )

SELECT cte.amount,cte.id,cte.store, AVG(OrdersDay1.amount) AS avg_store
FROM cte 
JOIN OrdersDay1 
ON cte.store = OrdersDay1.store
GROUP BY cte.amount,cte.id,cte.store 
ORDER BY cte.store DESC;

-- made temp TABLE

SELECT a.id, a.amount,a.store, AVG(a.amount) AS avg_store 
INTO #temp 
FROM OrdersDay1 a
JOIN OrdersDay1 b
ON a.store = b.store
GROUP BY a.store ,a.id , a.amount
ORDER BY a.store desc ;

SELECT * FROM #temp;

DROP TABLE #temp; 


SELECT store, avg(amount) AS avg_for_store
INTO #temptable
FROM OrdersDay1
GROUP BY store

SELECT o.id, o.store, o.amount, s.avg_for_store
from OrdersDay1 o
JOIN #temptable s ON o.store = s.store


-------------------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------------------- TASK - 3 -----------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------------------------------------------------


--Write 3 different query for Insert, Update and Delete TRIGGERs On
--TABLE: Order
---> On perform insert, update and delete operation insert record in to Order_backup TABLE.


--CREATE BACKUP TABLE

CREATE TABLE Order_backup(
   id INT,
   order_date DATE,
   customer_id INT,
   store CHAR(255),
   Operation NVARCHAR(50),
   employee_id INT,
   amount INT,
);

-- CREATE TRIGGER FOR INSERT.

CREATE TRIGGER trgInsert
ON OrdersDay1
FOR INSERT
AS
   INSERT INTO Order_backup(id, order_date, customer_id, store , Operation, employee_id , amount)
   SELECT id, order_date, customer_id, store, 'INSERT', employee_id , amount
   FROM inserted;
GO

--INSERT QUERY

INSERT INTO OrdersDay1
VALUES(101, '2021-07-01',234,'East',11, 111.00),
(112, '2015-01-01',11,'West',14,777.00);

--Update TRIGGER

CREATE TRIGGER trgUpdate
ON OrdersDay1
FOR UPDATE
AS
   INSERT INTO Order_backup(id, order_date, customer_id, store , Operation, employee_id , amount)
   SELECT id, order_date, customer_id, store, 'UPDATE', employee_id , amount
   FROM inserted;
GO

--UPDATE QUERY

UPDATE OrdersDay1
SET customer_id = 100
WHERE id = 101;

--DELETE TRIGGER

CREATE TRIGGER trgDelete
ON OrdersDay1
FOR DELETE
AS
   INSERT INTO Order_backup(id, order_date, customer_id, store,Operation, employee_id, amount)
   SELECT id, order_date, customer_id, store, 'DELETE',employee_id,amount
   FROM deleted;

-- DELETE QUERY

DELETE 
FROM OrdersDay1
WHERE id = 105;


-- select * from  TABLEs

select * from OrdersDay1
select * from Order_backup;


--DROP TABLEs

DROP TABLE OrdersDay1;
DROP TABLE Order_backup;

-- DROP TRIGGERs

DROP TRIGGER trg;
DROP TRIGGER trgUpdate;
DROP TRIGGER trgOrderDelete;




---------------------------------------------------------------------------------------------------------------------------------------------------------------------
--																			EXTRA																				   --
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

-- create extra table for practice


CREATE TABLE orderrrr(
id	INT NOT NULL,
order_date DATE NOT NULL,
customer_id INT NOT NULL,
store VARCHAR(20) NOT NULL,
employee_id INT NOT NULL,
amount INT NOT NULL
) 

INSERT INTO orderrrr
VAlUES
(101,'05-01-2023',234,'east',11,211),
(102,'06-01-2023',151,'east',12,511),
(103,'07-01-2023',244,'south',13,845),
(104,'08-01-2023',811,'south',11,1265),
(105,'09-01-2023',125,'west',14,285),
(106,'10-01-2023',952,'west',12,355);

Create TABLE auditoftrigger(
Id INT,
auditreason NVARCHAR(100)
)


create TRIGGER tr_insert
ON orderrrr
FOR INSERT
AS
BEGIN
	DECLARE @id INT
	SELECT @id = Id from inserted
	Insert into auditoftrigger
	values (@id , 'NEW employee is added id with id = ' +  CAST(@id as nvarchar(5)) + 'is added at' + CAST(GETDATE() as nvarchar(20)))
END



INSERT INTO orderrrr
VAlUES
(115,'05-01-2023',234,'east',11,211)



drop table orderrrr
drop table auditoftrigger
drop trigger tr_insert


select * from orderrrr
select * from auditoftrigger