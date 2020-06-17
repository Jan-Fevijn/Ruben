drop database if exists  syntax_ex;
create database if not exists   syntax_ex;
use syntax_ex;

CREATE TABLE Customers ( 
idCustomer int ,
CustomerName varchar(50),
Address varchar(50),
City varchar(50),
PostalCode INT ,
Country	varchar(50),
 PRIMARY KEY (idCustomer)
);

INSERT INTO Customers 
( CustomerName, Address, City, PostalCode, Country ) VALUES
 ( 'Hekkan Burger', 'Gateveien 15', 'Sandnes', '4306', 'Norway') ;