create database ExerciseDb

use ExerciseDb

create table CompanyInfo(
CId int Primary key,
CName varchar(50) not null,

)
insert into CompanyInfo values(1,'Samsung'),(2,'HP'),(3,'Apple'),(4,'Dell'),(5,'Toshiba'),(6,'Redmi')

select * from CompanyInfo




create table ProductInfo(
PId int primary key ,
PName nvarchar(50) not null,
PPrice float not null,
PMDate Date not null,
CId int foreign key references CompanyInfo(CId))

INSERT INTO ProductInfo (PId,PName,PPrice,PMDate,CId) VALUES
(101, 'Laptop', 55000.90, '12-12-2023',1),
(102, 'Laptop', 35000.90, '12-12-2012',2),
(103, 'Mobile', 15000.90, '12-03-2012',2),
(104, 'Laptop', 135000.90, '12-12-2012',3),
(105, 'Mobile', 65000.90, '12-12-2012',3),
(106, 'Mobile', 35000.90, '12-12-2012',5),
(107, 'Laptop', 35000.90, '12-01-2012',5),
(108, 'Earpod', 1000.70, '12-01-2022',3),
(109, 'Laptop', 85000.70, '12-12-2021',6),
(110, 'Mobile', 55000.70, '12-12-2020',1)


select * from ProductInfo