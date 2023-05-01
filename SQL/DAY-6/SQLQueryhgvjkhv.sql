--===========================================--
--                TASK - 6                   --
--===========================================--

--TABLE :- 1

--Company table
CREATE TABLE Company(
	CompanyId BIGINT  PRIMARY KEY identity(1,1),
	CompanyName NVARCHAR(200) not null,
	symbol NVARCHAR(200) not null,
	exchange NVARCHAR(200) not null,
	industry NVARCHAR(200) not null,
	sector NVARCHAR(200) not null
	)

	

INSERT INTO Company
VALUES
('Apple Inc.','AAPL','NASDAQ','Consumer Electronics','Technology'),
('Microsoft Corp.','MSFT','NASDAQ','Software ','Technology'),
('Alphabet Inc.','GOOGL','NASDAQ','Online Services','Technology'),
('Amazon.com, Inc.','AMZN','NASDAQ','E-Commerce','Consumer Discretionary'),
('Facebook, Inc.','FB','NASDAQ','Social Networking','Communication Services'),
('Johnson & Johnson','JNJ','NYSE','Pharmaceuticals','Health Care'),
('Visa Inc.','V','NYSE','Payment Services','Financials'),
('Procter & Gamble','PG','NYSE','Consumer Goods','Consumer Staples'),
('Coca-Cola Co','KO','NYSE','Beverages - Soft','Consumer Staples'),
('Verizon Comm. Inc','VZ','NYSE','Telecom - Domestic','Communication Services'),
('SAMSUNG','SMG','NASDAQ','Consumer Electronics','Technology'),
('VIVO','VO','NASDAQ','Consumer Electronics','Technology'),
('FLIPKART','FK','NASDAQ','E-Commerce','Consumer Discretionary'),
('MYNTRA','MT','NASDAQ','E-Commerce','Consumer Discretionary'),
('AJIO','AJ','NASDAQ','E-Commerce','Consumer Discretionary');

SELECT * FROM Company;

--TABLE :- 2
--Stocks table
CREATE TABLE Stocks(
	StocksId BIGINT PRIMARY KEY IDENTITY(1,1),
	Company_Id BIGINT FOREIGN KEY REFERENCES Company(CompanyId) not null,
	StocksDate DATE not null,
	)

INSERT INTO Stocks
VALUES 
('1','2023-03-14'),
('2','2023-03-14'),
('3','2023-03-15'),
('4','2023-03-15'),
('5','2023-03-17'),
('6','2023-03-17'),
('7','2023-03-16'),
('8','2023-03-12'),
('9','2023-03-11'),
('10','2023-03-10'),
('11','2023-03-09'),
('12','2023-03-08'),
('13','2023-03-09'),
('14','2023-03-07'),
('15','2023-03-06');

SELECT * FROM Stocks;

--TABLE :- 3
--Transactions Table:
CREATE TABLE Transactions(
	TransactionsId BIGINT PRIMARY KEY IDENTITY(1,1),
	stock_Id BIGINT FOREIGN KEY REFERENCES Stocks(StocksId) not null,
	transaction_type NVARCHAR(200) NOT NULL,
	quantity INT,
	price DECIMAL(18,4),
	TransactionsDate datetime NOT NULL,
)

INSERT INTO Transactions
VALUES 
('1','BUY','1','2000.04','2023-03-15 9:20:12'),
('2','SELL','2','5014.22','2023-03-14 3:10:10'),
('3','BUY','3','7045.78','2023-03-14 10:10:10'),
('4','SELL','1','948.70','2023-03-15 2:15:50'),
('5','BUY','1','105.26','2023-03-20 11:20:25'),
('6','SELL','2','2014.77','2023-03-19 1:55:23'),
('7','BUY','2','3334.33','2023-03-18 12:40:20'),
('8','SELL','3','802.66','2023-03-13 10:25:40'),
('9','BUY','3','3014.80','2023-03-11 9:30:25'),
('10','SELL','4','200.21','2023-03-10 3:00:20'),
('2','BUY','1','8000.02','2023-03-20 9:15:00'),
('3','SELL','1','2015.04','2023-03-16 9:20:12'),
('4','BUY','1','915.04','2023-03-16 9:20:12'),
('5','BUY','1','215.04','2023-03-21 9:20:12'),
('6','BUY','2','3024.04','2023-03-20 03:10:12'),
('7','SELL','2','3024.04','2023-03-19 03:10:12'),
('8','BUY','2','840.04','2023-03-15 03:10:12'),
('9','SELL','2','3100.04','2023-03-12 03:00:12'),
('1','SELL','1','1705.04','2023-03-16 03:00:12'),
('10','BUY','1','185.05','2023-03-12 09:30:12'),
('11','SELL','1','275.05','2023-03-10 02:30:12'),
('12','BUY','1','100.05','2023-03-12 09:30:12'),
('13','SELL','1','777.05','2023-03-13 01:35:15'),
('14','BUY','1','2020.05','2023-03-14 09:30:12'),
('15','SELL','1','3000.05','2023-03-15 09:30:12'),
('11','BUY','1','200.05','2023-03-11 09:30:12'),
('12','SELL','1','170.05','2023-03-13 09:30:12'),
('13','BUY','1','700.05','2023-03-15 09:30:12'),
('14','SELL','1','2770.05','2023-03-17 09:30:12'),
('15','BUY','1','3110.00','2023-03-20 09:30:12');



SELECT * FROM Transactions;


--TABLE :- 4
--Users Table:
CREATE TABLE Users(
	UsersId BIGINT PRIMARY KEY IDENTITY(1,1),
	UsersName NVARCHAR(200) not null,
	Usersemail NVARCHAR(200) UNIQUE not null,
	Userspassword  NVARCHAR(200) not null
)

INSERT INTO Users
VALUES('John Smith','john.smith@example.com','p@ssw0rd1'),
('Jane Doe','jane.doe@example.com','p@ssw0rd1'),
('Bob Johnson','bob.johnson@example.com','mysecurepassword'),
('Emily Chen','emily.chen@example.com','password123'),
('Michael Rodriguez','michael.rodriguez@example.com','secretpassword');


SELECT * FROM Users;

--TABLE :- 1
--Watchlist Table:
CREATE TABLE Watchlist(
	WatchlistId BIGINT PRIMARY KEY IDENTITY(1,1),
	Users_Id BIGINT FOREIGN KEY REFERENCES Users(UsersId) not null,
	Company_Id BIGINT FOREIGN KEY REFERENCES Company(CompanyId) not null
)

INSERT INTO Watchlist
VALUES('1','2'),
('2','3'),
('3','4'),
('4','5'),
('5','6'),
('1','7'),
('2','8'),
('3','9'),
('4','10'),
('5','1');

SELECT * FROM Watchlist;

--------------------------------------------------------

SELECT * FROM Company;
SELECT * FROM Stocks;
SELECT * FROM Transactions;
SELECT * FROM Users;
SELECT * FROM Watchlist;


-------------QUERY-1------------

create procedure date_range @date1 date , @date2 date

AS
BEGIN

SELECT t.transaction_type, c.symbol , t.quantity , t.price ,
SUM(t.price) AS Total_Price
FROM
Company c INNER JOIN Stocks s ON c.CompanyId = s.Company_Id
INNER JOIN Transactions t ON t.stock_Id = s.StocksId
WHERE t.TransactionsDate BETWEEN @date1 AND @date2
GROUP BY t.transaction_type, c.symbol , t.quantity, t.price

END
EXEC date_range @date1 = '2023-03-18', @date2 = '2023-03-19';

DROP PROC date_range;

-------------QUERY-2------------

SELECT * FROM Watchlist;
SELECT * FROM Users;
SELECT * FROM Transactions;
SELECT * FROM Stocks;
SELECT * FROM Company;

CREATE PROCEDURE Watchlist_pro @Company_Name VARCHAR(200)
AS
BEGIN

SELECT c.symbol , t.price
FROM
Company c INNER JOIN Stocks s ON c.CompanyId = s.Company_Id
INNER JOIN Transactions t ON t.stock_Id= s.StocksId
WHERE c.CompanyName = @Company_Name

END
EXEC Watchlist_pro @Company_Name = 'Alphabet Inc.';

DROP PROC Watchlist_pro;

---------------------Query 3----------------

SELECT * FROM Watchlist;
SELECT * FROM Users;
SELECT * FROM Transactions;
SELECT * FROM Stocks;
SELECT * FROM Company;


-----------------------------Gainers-----------------------------------------------------
--DROP PROCEDURE [Gainers]
CREATE PROCEDURE Gainers
( @exchange NVARCHAR(200)  )
AS
BEGIN
	SET NOCOUNT ON
				select top(5) Company.CompanyName,
						Company.symbol,
						Transactions.price as prev_price, 
						current_price = (
											SELECT TOP 1 Price
											FROM Transactions
											WHERE stock_id = Stocks.StocksId
											ORDER BY  cast(Transactions.TransactionsDate as date) DESC
											)
						,percentage_change  = cast((( (
											SELECT TOP 1 Price
											FROM Transactions
											WHERE stock_id = Stocks.StocksId
											ORDER BY  cast(Transactions.TransactionsDate as date) DESC
											)*100/Transactions.price)-100)AS decimal(12,2))
				from  Stocks
				 inner join  Transactions on Stocks.StocksId = Transactions.stock_Id
				inner join Company  on Company.CompanyId = Stocks.Company_Id
				WHERE Company.exchange = @exchange
				ORDER BY percentage_change DESC

END
GO
EXEC  Gainers  @exchange  = 'NASDAQ'

----------------------------------Losers-----------------------------------------------

CREATE PROCEDURE Losers
( @exchange NVARCHAR(200)  )
AS
BEGIN
	SET NOCOUNT ON
select top(5) Company.CompanyName,
					Company.symbol,
					Transactions.price as prev_price, 
					current_price = (
										SELECT TOP 1 Price
										FROM Transactions
										WHERE stock_id = Stocks.StocksId
										ORDER BY  cast(Transactions.TransactionsDate as date) DESC
										)
					,percentage_change  = cast((( (
										SELECT TOP 1 Price
										FROM Transactions
										WHERE stock_id = Stocks.StocksId
										ORDER BY  cast(Transactions.TransactionsDate as date) DESC
										)*100/Transactions.price)-100)AS decimal(12,2))
			from  Stocks
			 inner join  Transactions on Stocks.StocksId = Transactions.stock_Id
			inner join Company  on Company.CompanyId = Stocks.Company_Id

			WHERE Company.exchange = @exchange  
			ORDER BY percentage_change ASC

END
GO
EXEC  Losers  @exchange  = 'NASDAQ'

