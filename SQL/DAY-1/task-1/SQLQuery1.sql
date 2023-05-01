
--table 1

CREATE TABLE Persons (
    Mybit  bit,
    Mytinyint tinyint,
    Mysmallint smallint,
    Myint int,
    Mybigint bigint,
	Mydecimal decimal,
	Mynumeric numeric,
	Mymoney money
);
select * from Persons

insert into Persons values(1,22,33,456,4567,10,123456789,300)

insert into Persons values(1,22,33,456,4567,10,123456789,300)
insert into Persons values(1,22,33,456,4567,10,123456789,301)

select * from Persons where Mymoney=301
delete from Persons where Mymoney=301

CREATE TABLE Persons2 (
    Mybit  bit,
    Mytinyint tinyint,
    Mysmallint smallint,
    Myint int,
    Mybigint bigint,
	Mydecimal decimal,
	Mynumeric numeric,
	Mymoney money
);
alter table Persons2
drop column Myint,Mybigint,Mydecimal,Mynumeric


--ALTER TABLE Persons2 
--rename COLUMN Mymoney to Myfloat;
drop table Persons2;]


--table2
create table Persons2(
MyFloat float
)
insert into Persons2 values (8.541651)

select * from Persons2

--table3
create table Persons3(
Mydate date ,
Mydatetime datetime,
Mydatetime2 datetime2,
Mydatetimeoffset datetimeoffset,
Mysmalldatetime smalldatetime,
Mytime time
)

insert into Persons3 values('2001-01-11', '2023-03-13 12:12:12', '2001-01-11 12:12:12.0000000', '2001-01-11 10:52:00.0000000 -08:00', '2001-01-11 10:52:00', '10:52:00');
select * from Persons3

--table4
create table Persons4(
Mychar char,
Myvarchar varchar(20),
Mytext text
)


select * from Persons4
insert into Persons4 values ('o','theomdave','hollaaa')

--table5
create table Persons5(
Mynvarchar nvarchar(50),
Myntext ntext
)
select * from Persons5
insert into Persons5 values ('theomdave','hollaaa my name is om dave how may i help you')