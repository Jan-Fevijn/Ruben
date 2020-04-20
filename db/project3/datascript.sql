drop database if exists bakerijPol; 
create database if not exists bakerijPol;

CREATE TABLE `bakerijpol`.`soortbrood` (
  `idsoortBrood` INT NOT NULL AUTO_INCREMENT,
  `naam` VARCHAR(20) NULL,
  PRIMARY KEY (`idsoortBrood`));


CREATE TABLE `bakerijpol`.`user` (
  `idUser` INT NOT NULL AUTO_INCREMENT,
  `code` int NULL,
   `saldo` int NULL,
  PRIMARY KEY (`idUser`));



CREATE TABLE `bakerijpol`.`broodLocatie` (
  `idBroodLocatier` INT NOT NULL AUTO_INCREMENT,
  `IDsoordBrood` int NULL,
   `locatie` int NULL, -- the number that the user will have to inter to get the breat 
  PRIMARY KEY (`idBroodLocatier`));

