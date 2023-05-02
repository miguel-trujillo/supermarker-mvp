use Supermarker
create table Products
(
 Products_Id int identity (100000,1) primary key,
 Products_Name nvarchar (50) not null,
 Products_Observation nvarchar (50) not null,
)
go
insert into Products values('Portatil', 'Aparatos electronicos')
insert into Products values('Celular', 'Aparatos electronicos')
