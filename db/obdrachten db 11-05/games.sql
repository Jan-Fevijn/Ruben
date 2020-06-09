drop database if exists games;
create database if not exists games;
use games;
CREATE TABLE `games`.`spel` (
  `idspel` INT NOT NULL AUTO_INCREMENT,
  `Naamspel` VARCHAR(45) NULL,
  `IDuitgever` INT NULL,
  `korteinhoud` VARCHAR(200) NULL,
  `aankoopdatum` DATETIME NULL,
  PRIMARY KEY (`idspel`));

CREATE TABLE `games`.`type` (
  `idtype` INT NOT NULL AUTO_INCREMENT,
  `eigenschap` VARCHAR(45) NULL,
  PRIMARY KEY (`idtype`));

CREATE TABLE `games`.`uitgever` (
  `iduitgever` INT NOT NULL AUTO_INCREMENT,
  `naamUitgever` VARCHAR(45) NULL,
  PRIMARY KEY (`iduitgever`));

CREATE TABLE `games`.`speltype` (
  `idspelType` INT NOT NULL AUTO_INCREMENT,
  `idSpel` INT NULL,
  `idType` VARCHAR(45) NULL,
  PRIMARY KEY (`idspelType`));
  
  
CREATE TABLE `games`.`uitleening` (
  `iduitleening` INT NOT NULL AUTO_INCREMENT,
  `iduitleener`INT NOT NULL,
  `idspel`INT NOT NULL,
  PRIMARY KEY (`iduitleening`));

CREATE TABLE `games`.`uitleener` (
  `iduitleener` INT NOT NULL AUTO_INCREMENT,
  `naam` VARCHAR(45) NULL,
   `famielienaam` VARCHAR(45) NULL,
    `gsmNummer` VARCHAR(15) NULL,
     `email` VARCHAR(45) NULL,
  PRIMARY KEY (`iduitleener`));
  /*               new records                                  */ 
  USE `games`;
INSERT INTO `games`.`spel` (`idspel`, `Naamspel`, `IDuitgever`, `korteinhoud`, `aankoopdatum`) 
VALUES ('1', 'minecraft', '1', 'speelen met blokken', '2020-06-08');
INSERT INTO `games`.`spel` (`idspel`, `Naamspel`, `IDuitgever`, `korteinhoud`, `aankoopdatum`) 
VALUES ('2', 'gta 5', '2', 'schieten naar de politie', '2020-06-08');

INSERT INTO `games`.`speltype` (`idspelType`, `idSpel`, `idType`) VALUES ('1', '1', 'avontuur');
INSERT INTO `games`.`speltype` (`idspelType`, `idSpel`, `idType`) VALUES ('2', '1', 'bouwen');
INSERT INTO `games`.`uitgever` (`iduitgever`, `naamUitgever`) VALUES ('1', 'ubisoft');

INSERT INTO `games`.`uitleening` (`iduitleening`, `iduitleener`, `idspel`) VALUES ('1', '1', '1');
INSERT INTO `games`.`uitleening` (`iduitleening`, `iduitleener`, `idspel`) VALUES ('2', '1', '2');

INSERT INTO `games`.`uitleener` (`iduitleener`, `naam`, `famielienaam`, `gsmNummer`, `email`) VALUES 
('1', 'Ruben', 'Aspeslag', '0762548565', 'ruben.aspeslag@gmail.com');



