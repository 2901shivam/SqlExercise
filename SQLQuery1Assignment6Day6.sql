create database ProductInventoryDB

use ProductInventoryDB

create table Products(
ProductId int primary key,
ProductName nvarchar(50),
Price float,
Qunatity int,
MfDate date,
ExpDate date
)
insert into Products values(1,'Shampoo',100.20,5,'10/12/2023','09/06/2025')
insert into Products values(2,'Oreo',25,10,'09/06/2023','09/06/2024')
insert into Products values(3,'HaldiRam',178.20,3,'10/12/2023','09/06/2025')
insert into Products values(4,'Edible Oil',135.20,5,'10/12/2023','09/06/2025')
select*from Products