drop database if exists babylijst ;
create database if not exists babylijst; 
use babylijst;

CREATE TABLE `babylijst`.`products` (
  `idproduct` INT NOT NULL  AUTO_INCREMENT,
  `naam` VARCHAR(45) NULL,
  `prijs` DECIMAL(5,2) NULL,
  PRIMARY KEY (`idproduct`));

CREATE TABLE `babylijst`.`buyers` (
  `idbuyers` INT NOT NULL  AUTO_INCREMENT,
  `voornaam` VARCHAR(45) NULL,
  `famielinaam` VARCHAR(45) NULL,
  PRIMARY KEY (`idbuyers`));

CREATE TABLE `babylijst`.`orders` (
  `idorder` INT NOT NULL AUTO_INCREMENT,
  `idbuyer` INT NULL,
  `idproduct` INT NULL,
  `prijs` DECIMAL(5,2) NULL,
  PRIMARY KEY (`idorder`));


INSERT INTO `babylijst`.`buyers` (`idbuyers`, `voornaam`, `famielinaam`) VALUES ('1', 'Ruben', 'Aspeslag');
INSERT INTO `babylijst`.`buyers` (`idbuyers`, `voornaam`, `famielinaam`) VALUES ('2', 'Dieter', 'Aspeslag');


INSERT INTO `babylijst`.`products` (`idproduct`, `naam`, `prijs`) VALUES ('1', 'knuffel', '10');
INSERT INTO `babylijst`.`products` (`idproduct`, `naam`, `prijs`) VALUES ('2', 'babyfoon', '200');
INSERT INTO `babylijst`.`products` (`idproduct`, `naam`, `prijs`) VALUES ('3', 'zokje', '1');
