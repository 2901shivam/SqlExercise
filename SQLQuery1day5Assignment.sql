Create database Assignment05Db

use Assignment05Db;

CREATE SCHEMA bank;

create table bank.Customer(
CId int primary key,
CName varchar(50)not null,
CEmail varchar(50) not null unique,
Contact varchar(50) not null,
CPwd varchar(50) not null unique
)

create table bank.Maillnfo(
CId int primary key,
CName varchar(50),
CEmail varchar(50),
Contact varchar(50) ,
CPwd varchar(50) ,
mailTo varchar(50),
Maildate date default GetDate()
)

select*from bank.Customer
select*from bank.Maillnfo

create trigger afterInsTrg
on
bank.Customer
after insert
as 
declare @id int
declare @cn nvarchar(50)
declare @ce nvarchar(50)
declare @co nvarchar(50)
declare @cp nvarchar(50)
declare @mai nvarchar(50)

select @id=CId from inserted
select @cn=CName from inserted
select @ce=CEmail from inserted
select @co=Contact from inserted
select @cp=CPwd from inserted


insert into bank.Maillnfo(CId,CName,CEmail,Contact,CPwd,mailTo,Maildate) 
values(@id,@cn,@ce,@co,@cp,@ce,GETDATE());
print'Record inserted'

select*from bank.Customer
select*from bank.Maillnfo

insert into bank.Customer (Cid, CName, CEmail,Contact, CPwd)
values 
    (1, 'Customer1', 'customer1@example.com','21222222', 'password1'),
    (2, 'Customer2', 'customer2@example.com','1234567898', 'password2'),
    (3, 'Customer3', 'customer3@example.com','1236547898', 'password3');

