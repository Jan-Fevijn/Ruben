drop database if exists bakerijPol; 
create database if not exists bakerijPol;
use bakerijpol; 
CREATE TABLE `bakerijpol`.`soortbrood` (
  `idsoortBrood` INT NOT NULL AUTO_INCREMENT,
  `naam` VARCHAR(20) NULL,
   `img` VARCHAR(30) NULL,
   `hoeveelheid` int NULL,
   `prijs` int NULL,
  PRIMARY KEY (`idsoortBrood`));


CREATE TABLE `bakerijpol`.`user` (
  `idUser` INT NOT NULL AUTO_INCREMENT,
  `code` int NULL,
  `saldo` int NULL,
  PRIMARY KEY (`idUser`));



CREATE TABLE `bakerijpol`.`broodLocatie` (
  `idBroodLocatier` INT NOT NULL AUTO_INCREMENT,
  `IDsoordBrood` int NULL,
  `locatie` int NULL,
  `hoeveelheid` int NULL,
  PRIMARY KEY (`idBroodLocatier`));
  
  CREATE TABLE `bakerijpol`.`order` (
  `idorder`  INT NOT NULL AUTO_INCREMENT ,
  `usercode` INT NULL,
  `idSoortbrood` INT NULL,
  `idlocatie` INT NULL,
  PRIMARY KEY (`idorder`));
INSERT INTO `bakerijpol`.`soortbrood` (`naam`, `hoeveelheid` , `prijs`) VALUES ( 'meergranenbrood brood','5' , '2');
INSERT INTO `bakerijpol`.`soortbrood` (`naam`, `hoeveelheid` , `prijs`) VALUES ( 'volkoren brood','5' , '2');
INSERT INTO `bakerijpol`.`soortbrood` (`naam`, `hoeveelheid` , `prijs`) VALUES ( 'chocolade brood','5' , '3');
INSERT INTO `bakerijpol`.`soortbrood` (`naam`, `hoeveelheid` , `prijs`) VALUES ( 'Wit brood','5' , '2');
INSERT INTO `bakerijpol`.`soortbrood` (`naam`, `hoeveelheid` , `prijs`) VALUES ( 'bruin brood','5','2');
INSERT INTO `bakerijpol`.`soortbrood` (`naam`, `hoeveelheid` , `prijs`) VALUES ( 'tijgerbrood','5', '2');
INSERT INTO `bakerijpol`.`soortbrood` (`naam`, `hoeveelheid` , `prijs`) VALUES ( 'boterkoek','5', '3');
INSERT INTO `bakerijpol`.`soortbrood` (`naam`, `hoeveelheid`, `prijs`) VALUES  ( 'croissant', '5', '3');
INSERT INTO `bakerijpol`.`soortbrood` (`naam`, `hoeveelheid` , `prijs`) VALUES ( 'rozijnenbrood','5', '2');