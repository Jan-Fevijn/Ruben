drop database if  EXISTS  inuitgaven ;
create database if not exists inuitgaven ;
use inuitgaven ;

DROP TABLE IF EXISTS `inkomsten`;
CREATE TABLE `inkomsten` (
  `code` int(11) NOT NULL,
  `omschrijving` varchar(45) DEFAULT NULL,
  `bedrag` int(11) DEFAULT NULL,
  `io` tinyint(4) DEFAULT NULL,
  `iduser` int(11) NOT NULL,
  PRIMARY KEY (`code`,`iduser`));
  
  
  INSERT INTO `inkomsten` (`code`, `omschrijving`, `bedrag`, `io`, `iduser`) VALUES (0,'5',555,1,5),(1,'zakgeld',50,1,2),(5,'uitgaan',50,0,1),(5,'snoep',50,0,2),(6,'uitgaan',50,0,1),(7,'zakgeld',50,1,1),(8,'gevonden',1,1,1),(56,'snoep',5,0,1),(68,'uitgaan',50,0,1),(69,'vakantiejob',2000,1,1),(70,'uitgaan',20,0,1),(84,'uitgaan',50,0,1),(98,'oortjes',5,0,1),(99,'zakgeld',100,1,1),(100,'snoep',3,0,1),(101,'schoen',50,0,1),(112,'zakgeld',50,1,1),(200,'zakgeld',50,1,1),(201,'zakgeld',50,1,1),(234,'a',7777,1,1),(777,'a',555,1,1),(1234,'uitgaan',50,0,1),(2234,'uitgaan',50,0,1),(3084,'uitgaan',50,0,1),(12234,'uitgaan',50,0,1),(122234,'a',555,1,1),(1000000,'',2147483647,1,14),(65962528,'yeet',555555555,1,14);
  
  DROP TABLE IF EXISTS `user`;
  CREATE TABLE `user` (
  `iduser` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `ADMIN` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`iduser`));
  
  INSERT INTO `user` (`iduser`, `username`, `password`, `ADMIN`) VALUES (1,'Ruben','Ruben2001',0),(2,'Dieter','Dieter2003',0),(3,'RA','Ruben20012001',1),(4,'69','208b25ccd437728061c9a60228035e24',NULL),(5,'99','ac627ab1ccbdb62ec96e702f07f6425b',NULL),(6,'999','999',NULL),(7,'Ruben33','azerty',1),(8,'Ruben33','azerty',1),(9,'Ruben33','azerty',1),(10,'Ruben33','azerty',1),(11,'Ruben33','azerty',1),(12,'admin','ADMIN',1),(13,'admin','Ruben2001',1),(14,'ruben2001','Ruben',NULL);
  