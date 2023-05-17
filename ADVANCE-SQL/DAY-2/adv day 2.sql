use [Om Dave];


---------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------TASK - 1-------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------

-- CREATED TABLE FOR SALESMAN

CREATE TABLE salesman(
salesman_id INT PRIMARY KEY,
[name] VARCHAR(20),
city VARCHAR(15),
commission float
);

INSERT INTO salesman
VALUES 
(5001,'JAMES HOOG','NEW YORK',0.15),
(5002,'NAIL KNITE','PARIS',0.13),
(5005,'PIR ALEX','LONDON',0.11),
(5006,'MC LYON','PARIS',0.14),
(5007,'PAUL ADAM','ROME',0.13),
(5003,'LAUSON HEN','SAN JOSE',0.12)

--CREATED TABLE FOR CUSTOMER

CREATE TABLE customer_day2(
customer_id INT PRIMARY KEY,
cust_name VARCHAR(20),
city VARCHAR(15),
grade INT,
salesman_id INT FOREIGN KEY REFERENCES salesman(salesman_id)
);

INSERT INTO customer_day2 
VALUES
(3002,'NICK RIMANDO','NEW YORK',100,5001),
(3007,'BRAD DAVIS','NEW YORK',200,5001),
(3005,'GRAHAM ZUSI','CALIFORNIA',200,5002),
(3008,'JULIAN GREEN','LONDON',300,5002),
(3004,'FEBIAN JOHNSON','PARIS',300,5006),
(3009,'GEOFF CAMERON','BERLIN',100,5003),
(3003,'JOZY ALTIDOR','MOSCOW',200,5007)

--SELECT TABLE

SELECT * FROM salesman
SELECT * FROM customer_day2



-- UNION EXAMPLE --

SELECT salesman_id,[name],TABLE_NAME = 'salesman' FROM salesman WHERE city = 'LONDON'
UNION
SELECT customer_id,cust_name,TABLE_NAME = 'customer_day2' FROM customer_day2 WHERE city = 'LONDON'

-- UNION ALL EXAMPLE --

SELECT salesman_id,[name],TABLE_NAME = 'salesman' FROM salesman WHERE city = 'LONDON'
UNION ALL
SELECT customer_id,cust_name,TABLE_NAME = 'customer_day2' FROM customer_day2 WHERE city = 'LONDON'


---------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------TASK - 2-------------------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------
--Write query to for SQL Transaction practice
--1. Begin Transaction: It indicates that the transaction is started.
--2. Commit Transaction: It indicates that the transaction was completed successfully and all the
--data manipulation operations performed since the start of the transaction are committed to the
--database and frees the resources held by the transaction.

--3. Rollback Transaction: It indicates that the transaction was Failed and will roll back the data
--to its previous state.
--4. Save Transaction: This is used for dividing or breaking a transaction into multiple units so
--that the user has a chance of roll backing a transaction up to a point or location.


-- BEGIN AND COMMIT TRANSACTION

BEGIN TRAN
UPDATE salesman 
SET name = 'SMIT'
WHERE salesman_id = 5001
COMMIT ;


-- SAVE POINT EXAMPLE

BEGIN TRAN
SAVE TRAN point1

DELETE FROM customer_day2
WHERE salesman_id = 5002
SAVE TRAN point2

DELETE FROM customer_day2
WHERE salesman_id = 5001
SAVE TRAN point3

--ROLL-BACK EXAMPLE 

ROLLBACK TRAN point1


--SELECT TABLE

SELECT * FROM salesman

SELECT * FROM customer_day2
