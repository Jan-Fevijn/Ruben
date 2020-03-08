ALTER TABLE `inuitgaven`.`inkomsten` 
ADD COLUMN `iduser` INT NOT NULL AFTER `io`,
DROP PRIMARY KEY,
ADD PRIMARY KEY (`code`, `iduser`);
;

CREATE TABLE `inuitgaven`.`user` (
  `iduser` INT NOT NULL AUTO_INCREMENT,
  `username` VARCHAR(45) NULL,
  `password` VARCHAR(45) NULL,
  `admin` bool NULL,
  PRIMARY KEY (`iduser`));

ALTER TABLE `gamestore`.`user` 
ADD COLUMN `admin` TINYINT NULL AFTER `password`;



UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '5') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '6') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '7') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '68') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '69') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '70') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '84') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '98') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '99') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '100') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '101') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '200') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '234') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '777') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '1234') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '2234') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '3084') and (`iduser` = '0');
UPDATE `inuitgaven`.`inkomsten` SET `iduser` = '1' WHERE (`code` = '12234') and (`iduser` = '0');


INSERT INTO `inuitgaven`.`user` (`iduser`, `username`, `password`) VALUES ('1', 'Ruben', 'Ruben2001');