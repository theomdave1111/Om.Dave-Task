--TABLE Customers
CREATE TABLE Customers(
C_CustomerId BIGINT IDENTITY PRIMARY KEY,
C_FirstName NVARCHAR(200) not null,
C_LastName NVARCHAR(200) not null,
C_MobileNo NVARCHAR(12) not null,
C_BirthDATE DATETIME default(getDATE())not null,
C_UserName NVARCHAR(100) not null,
C_UserEmailAddress NVARCHAR(200) UNIQUE not null,
C_Password NVARCHAR(200) not null,
C_HomeAddress NVARCHAR(1000) not null,
C_City NVARCHAR(100) not null,
C_State NVARCHAR(100) not null,
C_Zipcode NVARCHAR(100) not null,
C_INSERTedDATE DATETIME default(getDATE())
 );

 DROP TABLE Customers;

 SELECT * FROM Customers;

 INSERT INTO Customers(C_FirstName,C_LastName,C_MobileNo,C_UserName,C_UserEmailAddress,C_Password,C_HomeAddress,C_City,C_State,C_Zipcode)
VALUES('Mary' ,'Davis' ,'7878787878' ,'Mary Davis' ,'MaryDavis@gmail.com' ,'asdfgh' ,'Shashtri Nagar Andheri ' ,'Mumbai' ,'Maharashtra' ,'400053' ),
('Jasmine' ,'Chen' ,'2525252525' ,'Jasmine Chen' ,'JasmineChen@gmail.com' ,'zxcvbn' ,'Edmondson Trail' ,' Cloverva' ,'United States' ,'245342' ),
('Jennifer' ,'Lee' ,'3636363636' ,'Jennifer Lee' ,'JenniferLee@gmail.com' ,'bnmcxz' ,'Mockernut SW' ,'Lilburn ga,' ,'United States' ,'300431 ' ),
('Emily' ,'Davis' ,'7878787878' ,'Emily Davis' ,'EmilyDavis@gmail.com' ,'fghjkl' ,'Karlstra�e 29' ,'Rheinstetten' ,' Germany' ,' 762870' ),
('Karen' ,'Smith' ,'4848484848' ,'Karen Smith' ,'KarenSmith@gmail.com' ,'wscfty' ,'31 State Road ' ,' Hillsville va' ,' United States' ,'243439' ),
('CHESLI','PATEL','456465465', 'CHELSIPATEL','CHELSI@GMAIL.COM','ABCDEF',' M G Road ','RJK','GUJARAT','455424'),
( 'PRIYA','PATIL','78978974','PRIYAPATEL','DIPTI@GMAIL.COM','ABCDEF',' Lokhandwala Cplx Andheri','AMBD',' GUJARAT','400564'),
( 'RIYA','PATEL','1234567890','DIPTIPATEL','RIYA@GMAIL.COM','ABCDEF','V N Road ','AMBD',' GUJARAT','360005'),
('John' , 'Doe', '02020202' , 'John Doe' , 'JohnDoe@gmail.com', 'qwerty', ' Ambekar Marg Wadala' , 'Surat' , 'UP', '360008' ),
('Jane' ,'Smith' ,'454545454' ,'Jane Smith' ,'JaneSmith@gmail.com' ,'yutyio' ,'Siddhivinayak Temple' ,'Mumbai' ,'Maharashtra' ,'210005' );

 --TABLE Employees
 CREATE TABLE  Employees(
 E_EmployeeId BIGINT  IDENTITY(1,1) PRIMARY KEY ,
 E_FirstName NVARCHAR(200) NOT NULL ,
 E_LastName NVARCHAR(200) NOT NULL ,
 E_MobileNo NVARCHAR(12) NOT NULL ,
 E_BirthDATE DATE NOT NULL ,
 E_UserName NVARCHAR(100) NOT NULL ,
 E_UserEmailAddress NVARCHAR(200) UNIQUE NOT NULL ,
 E_Password NVARCHAR(200) NOT NULL ,
 E_HomeAddress NVARCHAR(1000) NOT NULL ,
 E_City NVARCHAR(100) NOT NULL , 
 E_State NVARCHAR(100) NOT NULL ,
 E_Zipcode NVARCHAR(10) NOT NULL ,
 E_INSERTedDATE DATETIME DEFAULT(getDATE())
 );

 DROP TABLE Employees;

 SELECT * FROM Employees;

 INSERT INTO Employees(E_FirstName,E_LastName,E_MobileNo,E_BirthDATE,E_UserName,E_UserEmailAddress,E_Password,E_HomeAddress,E_City,E_State,E_Zipcode)
 VALUES ('Om', 'dave', 1234567890 , '2011.11.11','abcxyz', 'abc@gmail.com', 'abc@','pqr','pqr','Gujarat',369258),
 ('deep','darji',777777777,'2000-01-01','raj123','darji@gmail.com','raj123','street2','rajkot','gujarat',380015),
('dhairya','patel',99999999,'2000-02-02','dhairya123','dhirya@gmail.com','dhairya123','street3','jamnagar','gujarat',360015);




  --TABLE Orders
  CREATE TABLE Orders(
  O_OrderId BIGINT  IDENTITY(1,1) PRIMARY KEY,
  C_CustomerId BIGINT not null,
  FOREIGN KEY (C_CustomerId) REFERENCES Customers(C_CustomerId),
  E_EmployeeId BIGINT not null,
  FOREIGN KEY (E_EmployeeId) REFERENCES Employees(E_EmployeeId),
  O_OrderDATE DATETIME not null,
  O_RequiredDATE DATETIME not null,
  O_ShippingDATE DATETIME not null , 
  O_Amount DECIMAL(18,4) not null,
   O_INSERTedDATE DATETIME default(getDATE())
  );

  DROP TABLE Orders 

  SELECT * FROM Orders;
  INSERT INTO Orders (C_CustomerId,E_EmployeeId,O_OrderDATE,O_RequiredDATE,O_ShippingDATE,O_Amount)
VALUES (1,1,'05-01-2023',05-01-2023,14-01-2023,900)

 INSERT INTO Orders (C_CustomerId,E_EmployeeId,O_OrderDATE,O_RequiredDATE,O_ShippingDATE,O_Amount)
VALUES (1,1,'03-16-2023',05-01-2023,14-01-2023,900)

 INSERT INTO Orders (C_CustomerId,E_EmployeeId,O_OrderDATE,O_RequiredDATE,O_ShippingDATE,O_Amount)
VALUES (1,1,05-01-2023,05-01-2023,14-01-2023,900),
(1,2,06-01-2023,06-01-2023,15-01-2023,1800) ,
(1,3,21-01-2023,21-01-2023,16-01-2023,900) ,
(2,1,08-01-2023,08-01-2023,06-01-2023,1800) ,
(2,2,09-01-2023,09-01-2023,07-01-2023,900) ,
(2,3,10-01-2023,10-01-2023,08-01-2023,1800) ,
(3,1,21-01-2023,21-01-2023,18-01-2023,900) ,
(3,2,12-01-2023,12-01-2023,19-01-2023,1800) ,
(3,3,13-01-2023,13-01-2023,20-01-2023,900) ,
(4,1,14-01-2023,14-01-2023,21-01-2023,1800) ,
(4,2,15-01-2023,15-01-2023,22-01-2023,900) ,
(4,3,16-01-2023,16-01-2023,14-01-2023,1800) ,
(5,1,13-01-2023,17-01-2023,15-01-2023,900) ,
(5,2,14-01-2023,18-01-2023,16-01-2023,1800) ,
(5,3,15-01-2023,19-01-2023,17-01-2023,900) ,
(6,1,16-01-2023,20-01-2023,18-01-2023,1800) ,
(6,2,17-01-2023,21-01-2023,19-01-2023,900) ,
(6,3,18-01-2023,22-01-2023,20-01-2023,1800) ,
(7,1,19-01-2023,23-01-2023,21-01-2023,900 ),
(7,2,20-01-2023,24-01-2023,22-01-2023,1800 ),
(7,3,21-01-2023,25-01-2023,23-01-2023,900 ),
(8,1,22-01-2023,26-01-2023,24-01-2023,1800 ),
(8,2,23-01-2023,27-01-2023,25-01-2023,900 ),
(8,3,24-01-2023,28-01-2023,26-01-2023,1800 ),
(9,1,25-01-2023,29-01-2023,27-01-2023,900 ),
(9,2,26-01-2023,30-01-2023,28-01-2023,1800 ),
(9,3,27-01-2023,18-01-2023,29-01-2023,900 ),
(10,1,28-01-2023,19-01-2023,30-01-2023,1800),
(10,2,29-01-2023,20-01-2023,31-01-2023,900 ),
(10,3,30-01-2023,21-01-2023,21-01-2023,1800);

   --TABLE Orderdetails
   CREATE TABLE Orderdetails(
   OrderdetailsId BIGINT IDENTITY(1,1) PRIMARY KEY,
   O_OrderId BIGINT FOREIGN KEY  REFERENCES Orders(O_OrderId),
   ItemName NVARCHAR(500) ,
   UnitPrice DECIMAL(18,4),
   Qty INT,
   TotalAmount DECIMAL(18,4),
   DiscountRate DECIMAL(18,4),
   DiscountAmount DECIMAL(18,4),
   FinalAMount DECIMAL(18,4),
   INSERTedDATE DATETIME default(getDATE()),
   IsDeleted BIT default(0)

   )

   DROP TABLE Orderdetails;

   SELECT * FROM Orderdetails;
   


   Insert into Orderdetails(O_OrderId,ItemName,UnitPrice,Qty,TotalAmount,DiscountRate,DiscountAmount,FinalAMount)

values(1,'Item 1',500,1,1000,10,100,900),
(2,'Item 2',1000,2,2000,10,200,1800),
(3,'Item 3',500,1,1000,10,100,900),
(4,'Item 4',1000,2,2000,10,200,1800),
(5,'Item 5',500,1,1000,10,100,900),
(6,'Item 6',1000,2,2000,10,200,1800),
(7,'Item 7',500,1,1000,10,100,900),
(8,'Item 8',1000,2,2000,10,200,1800),
(9,'Item 9',500,1,1000,10,100,900),
(10,'Item 10',1000,2,2000,10,200,1800),
(11,'Item 1',500,1,1000,10,100,900),
(12,'Item 2',1000,2,2000,10,200,1800) ,
(13,'Item 3',500,1,1000,10,100,900),
(14,'Item 4',1000,2,2000,10,200,1800) ,
(15,'Item 5',500,1,1000,10,100,900),
(16,'Item 6',1000,2,2000,10,200,1800) ,
(17,'Item 7',500,1,1000,10,100,900),
(18,'Item 8',1000,2,2000,10,200,1800) ,
(19,'Item 9',500,1,1000,10,100,900),
(20,'Item 10',1000,2,2000,10,200,1800),
(21,'Item 1',500,1,1000,10,100,900),
(22,'Item 2',1000,2,2000,10,200,1800) ,
(23,'Item 3',500,1,1000,10,100,900),
(24,'Item 4',1000,2,2000,10,200,1800) ,
(25,'Item 5',500,1,1000,10,100,900),
(26,'Item 6',1000,2,2000,10,200,1800) ,
(27,'Item 7',500,1,1000,10,100,900),
(28,'Item 8',1000,2,2000,10,200,1800) ,
(29,'Item 9',500,1,1000,10,100,900),
(30,'Item 10',1000,2,2000,10,200,1800);
------[TASK-2]-------	


--TABLE 1--

CREATE TABLE Persons (
    MyBIT  BIT,
    MyTINYINT TINYINT,
    MySMALLINT SMALLINT,
    MyINT INT,
    MyBIGINT BIGINT,
	MyDECIMAL DECIMAL,
	MyNUMERIC NUMERIC,
	MyMONEY MONEY
);

DROP TABLE Persons;

SELECT * FROM Persons;

INSERT INTO Persons VALUES (1,22,33,456,4567,10,123456789,300),(1,22,33,456,4567,10,123456789,300),(1,22,33,456,4567,10,123456789,301);

SELECT * FROM Persons WHERE MyMONEY=301
DELETE FROM Persons WHERE MyMONEY=301

CREATE TABLE Persons2 (
    MyBIT  BIT,
    MyTINYINT TINYINT,
    MySMALLINT SMALLINT,
    MyINT INT,
    MyBIGINT BIGINT,
	MyDECIMAL DECIMAL,
	MyNUMERIC NUMERIC,
	MyMONEY MONEY
);

ALTER TABLE Persons2

DROP COLUMN MyINT,MyBIGINT,MyDECIMAL,MyNUMERIC

DROP TABLE Persons2;


--TABLE2
CREATE TABLE Persons2(
MyFloat float
)
INSERT INTO Persons2 VALUES (8.541651)

SELECT * FROM Persons2

--TABLE3
CREATE TABLE Persons3(
MyDATE DATE ,
MyDATETIME DATETIME,
MyDATETIME2 DATETIME2,
MyDATETIMEOFFSET DATETIMEOFFSET,
MySMALLDATETIME SMALLDATETIME,
MyTIME TIME
)

INSERT INTO Persons3 VALUES('2001-01-11', '2023-03-13 12:12:12', '2001-01-11 12:12:12.0000000', '2001-01-11 10:52:00.0000000 -08:00', '2001-01-11 10:52:00', '10:52:00');
SELECT * FROM Persons3

--TABLE4
CREATE TABLE Persons4(
Mychar char,
Myvarchar varchar(20),
Mytext text
)


SELECT * FROM Persons4
INSERT INTO Persons4 VALUES ('o','theomdave','hollaaa')

--TABLE5
CREATE TABLE Persons5(
MyNVARCHAR NVARCHAR(50),
Myntext ntext
)
SELECT * FROM Persons5
INSERT INTO Persons5 VALUES ('theomdave','hollaaa my name is om dave how may i help you')



--TASK-3
--Write the Alter queries for the TABLEs that you haveCREATEd and upDATE the data types as mentioned below.
--UpDATE the varchar fields to NVARCHAR. i.e changeVarchar INTO NVARCHAR

ALTER TABLE Persons4 
ALTER COLUMN Myvarchar NVARCHAR(200);

SELECT * FROM Persons4

--For any DATETIME column, set a DEFAULT constraINTs.i.e set default GETDATE() for any DATETIME column

CREATE TABLE defaultTIME(
MyDATETIME DATETIME ,
)
ALTER TABLE defaultTIME
ADD CONSTRAINT DF_DATE DEFAULT(GETDATE()) FOR MyDATETIME

DROP TABLE defaultTIME
SELECT * FROM  defaultTIME
INSERT INTO defaultTIME VALUES (default)