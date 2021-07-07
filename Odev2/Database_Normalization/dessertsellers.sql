CREATE DATABASE DessertSeller
Use DessertSeller
GO
CREATE TABLE DessertSellers(
Id int primary key identity (1,1),
SellerName nvarchar(50) NOT NULL,
SellerTel  char(10) NOT NULL,
SellerAddress nvarchar(50) NOT NULL,
SellerRating int NOT NULL
);
--DessertSellers adýnda bir tane tablo oluþturuldu. id deðeri birincil anahtar yapýldý ve 
--identitiy(1,1) ile otomatik artan sayý olmasý saðlandý. 

CREATE TABLE Desserts(
Id int primary key identity (1,1),
DessertName nvarchar(50) NOT NULL,
DessertSellersId int,
foreign key (DessertSellersId) references DessertSellers(Id),
);
--Desserts adýnda bir tane tablo oluþturuldu. id deðeri birincil anahtar yapýldý ve
--identitiy(1,1) ile otomatik artan sayý olmasý saðlandý. Ayný zamanda DessertSellers tablosundaki ýd referans alýnarak foreign key
--olacak þekilde DessertSellersId kolonu ifade edildi.
CREATE TABLE Category (
Id int primary key identity(1,1),
CategoryName nvarchar(50) NOT NULL,
);

CREATE TABLE Customers(
Id int primary key identity (1,1),
CustomerName nvarchar(50) NOT NULL,
CustomerTel char(10) NOT NULL,
CustomerAddress nvarchar(50) NOT NULL,
CustomerPay nvarchar (30) NOT NULL,
);

CREATE TABLE DessertsCustomers (
DessertsId int,
CustomersId int,
CustomerType nvarchar (30),
CONSTRAINT PK_dessertsid_customersid primary key (DessertsId, CustomersId),
);