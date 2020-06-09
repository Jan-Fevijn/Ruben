drop database   if EXISTS diepvries;
create database if not EXISTS diepvries;
use diepvries;
 CREATE TABLE `inhoud` (
  `inhoudID` INT NOT NULL AUTO_INCREMENT,
  `omschrijvingInhoud` VARCHAR(45) NOT NULL,
  `houdbaarheidstijd` int NOT NULL,
  PRIMARY KEY (`inhoudID`));
CREATE TABLE `eenheid` (
  `ladeID` INT NOT NULL AUTO_INCREMENT,
  `omschrijvingLade` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ladeID`));
  
 CREATE TABLE `product` (
  `productID` INT NOT NULL AUTO_INCREMENT,
  `ladeID` INT NOT NULL,
  `inhoudID` INT NOT NULL ,
  `gewicht` int NOT NULL,
  PRIMARY KEY (`productID`));


