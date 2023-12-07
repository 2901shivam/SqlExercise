CREATE DATABASE OurExerciseDb
ON PRIMARY
(
    NAME = 'OurExercise_Db',
    FILENAME = 'C:\Exercise\OurExercise_Db.mdf',
    SIZE = 24MB,
    MAXSIZE = 48MB,
    FILEGROWTH = 8MB
)
LOG ON
(
    NAME = 'OurExercise_Db_log',
    FILENAME = 'C:\Exercise\OurExercise_Db_log.ldf'
)
COLLATE SQL_Latin1_General_CP1_CI_AS;

use OurExerciseDb

create table Product(
PId int Identity (50,1) Primary Key,
PName varChar(50) not null,
PPrice float Check (PPrice>=50.00 AND PPrice<=100000.00),
PCompany varchar(50) check(PCompany='Samsung' OR PCompany='Apple' OR PCompany='Redmi' OR PCompany='HTC'),
PQuantity int Check(PQuantity>1)
)
insert into Product values('Mobile',1000,'Samsung',2)
insert into Product values('Ipad',10000,'Apple',5)
insert into Product values('SmartWatch',5000,'Redmi',2)
insert into Product values('Mobile',8000,'HTC',2)

select*from Product