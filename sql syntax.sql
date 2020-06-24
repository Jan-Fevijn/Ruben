drop database if exists  syntax_ex;
create database if not exists   syntax_ex;
use syntax_ex;

CREATE TABLE Customers ( 
idCustomer int auto_increment,
CustomerName varchar(50),
Address varchar(50),
City varchar(50),
PostalCode INT ,
Country	varchar(50),
 PRIMARY KEY (idCustomer)
)ENGINE=INNODB;

CREATE TABLE product ( 
idProduct int auto_increment,
productName varchar(50),

 PRIMARY KEY (idProduct)
)ENGINE=INNODB;


CREATE TABLE customerProduct ( 
idCustomerProduct int auto_increment,
idProduct int not null,
idCustomer int not null,
 PRIMARY KEY (idCustomerProduct)
)ENGINE=INNODB;

alter table Customers 
add constraint FK_Customer
foreign key (idCustomer) references customerProduct (idCustomer);



alter table product 
add constraint FK_Product
foreign key (idProduct) references customerProduct (idProduct);



INSERT INTO Customers 
( CustomerName, Address, City, PostalCode, Country ) VALUES
 ( 'Hekkan Burger', 'Gateveien 15', 'Sandnes', '4306', 'Norway') ;
 
 
 
 