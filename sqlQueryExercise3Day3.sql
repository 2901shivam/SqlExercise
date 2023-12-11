create database ExerciseDay3
use ExerciseDay3

create table Products(
PId int primary key,
PQ int,
PPrice float,
DiscountPercentage int ,
Mfg date);

insert into Products values(1,3,56000.0,10,'12/12/2023')
insert into Products values(2,2,46000.0,10,'10/12/2023')
insert into Products values(3,1,36000.0,10,'11/12/2023')
insert into Products values(4,5,26000.0,10,'09/12/2023')
insert into Products values(5,4,76000.0,10,'08/12/2023')

select*from Products

create function DiscountedPrice(@Pid INT, @Pq INT, @PPrice FLOAT, @DisPer INT)
RETURNS FLOAT
AS
BEGIN
    DECLARE @discountedPrice FLOAT;

    SET @discountedPrice = @PPrice - (@PPrice * @DisPer / 100) * @Pq;

    RETURN @discountedPrice;
END

SELECT
    PId,
    PQ,
    PPrice,
    DiscountPercentage,
    Mfg,
    dbo.DiscountedPrice(PId, PQ, PPrice, DiscountPercentage) AS CalculatedDiscountedPrice
FROM
    Products;