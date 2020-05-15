drop database   if EXISTS spel;
create database if not EXISTS spel;
CREATE TABLE `spel`.`spel` (
  `idspel` INT NOT NULL AUTO_INCREMENT,
  `idUitgever` INT NOT NULL,
  `korteInhoud` VARCHAR(200) NOT NULL,
  `aankoopdatum` DATETIME NOT NULL,
  `aankoopprijs` DECIMAL(8,2) NOT NULL,
  PRIMARY KEY (`idspel`));

CREATE TABLE `spel`.`type` (
  `idtype` INT NOT NULL AUTO_INCREMENT,
  `type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idtype`));

CREATE TABLE `spel`.`speltype` (
  `idspelType` INT NOT NULL AUTO_INCREMENT,
  `idSpel` INT NOT NULL,
  `idType` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idspelType`));

CREATE TABLE `spel`.`uitgever` (
  `iduitgever` INT NOT NULL AUTO_INCREMENT,
  `naam` VARCHAR(45) NOT NULL,
  `website` VARCHAR(300) NOT NULL,
  PRIMARY KEY (`iduitgever`));

CREATE TABLE `spel`.`uitlenen` (
  `iduitlenen` INT NOT NULL AUTO_INCREMENT,
  `leener` VARCHAR(45) NOT NULL,
  `idSpel` INT NOT NULL,
  `datum` DATETIME NOT NULL,
  PRIMARY KEY (`iduitlenen`));

