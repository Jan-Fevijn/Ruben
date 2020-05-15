drop database   if EXISTS diepvries;
create database if not EXISTS diepvries;
drop table if exists  product ;
 CREATE TABLE `diepvries`.`product` (
  `idproduct` INT NOT NULL AUTO_INCREMENT,
  `productNaam` VARCHAR(45) NOT NULL,
  `aankoopDate` DATETIME NOT NULL,
  `hoeveelheid` INT NOT NULL,
  `ideenheid` INT NOT NULL,
  `bewaartijd` INT NOT NULL,
  `lade` INT NOT NULL,
   UNIQUE INDEX `aankoopDateProductNaam` (`productNaam` ASC, `aankoopDate` ASC) COMMENT
 'je kan niet hetzelvde product op het zelvde moment toevoegen.',
  PRIMARY KEY (`idproduct`)
 )  ;
 

CREATE TABLE `diepvries`.`eenheid` (
  `ideenheid` INT NOT NULL AUTO_INCREMENT,
  `eenheid` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ideenheid`));


