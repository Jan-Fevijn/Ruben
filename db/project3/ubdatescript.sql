use bakerijpol; 
drop table if exists muntjes ;
CREATE TABLE `bakerijpol`.`muntjes` (
  `idmuntjes` INT NOT NULL AUTO_INCREMENT,
  `value` decimal (8,2) NULL,
  `transactie`decimal (8,2) NULL,
  PRIMARY KEY (`idmuntjes`),
  UNIQUE INDEX `idmuntjes_UNIQUE` (`idmuntjes` ASC));
