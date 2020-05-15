-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: inuitgaven
-- ------------------------------------------------------
-- Server version	5.6.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `inkomsten`
--

DROP TABLE IF EXISTS `inkomsten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inkomsten` (
  `code` int(11) NOT NULL,
  `omschrijving` varchar(45) DEFAULT NULL,
  `bedrag` int(11) DEFAULT NULL,
  `io` tinyint(4) DEFAULT NULL,
  `iduser` int(11) NOT NULL,
  PRIMARY KEY (`code`,`iduser`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inkomsten`
--

LOCK TABLES `inkomsten` WRITE;
/*!40000 ALTER TABLE `inkomsten` DISABLE KEYS */;
INSERT INTO `inkomsten` (`code`, `omschrijving`, `bedrag`, `io`, `iduser`) VALUES (0,'5',555,1,5),(1,'zakgeld',50,1,2),(5,'uitgaan',50,0,1),(5,'snoep',50,0,2),(6,'uitgaan',50,0,1),(7,'zakgeld',50,1,1),(8,'gevonden',1,1,1),(9,'inbraak',200,1,1),(10,'mony',100000,1,1),(56,'snoep',5,0,1),(68,'uitgaan',50,0,1),(69,'vakantiejob',2000,1,1),(70,'uitgaan',20,0,1),(84,'uitgaan',50,0,1),(98,'oortjes',5,0,1),(99,'zakgeld',100,1,1),(100,'snoep',3,0,1),(101,'schoen',50,0,1),(112,'zakgeld',50,1,1),(200,'zakgeld',50,1,1),(201,'zakgeld',50,1,1),(202,'monny',200,1,1),(234,'a',7777,1,1),(777,'a',555,1,1),(1234,'uitgaan',50,0,1),(2234,'uitgaan',50,0,1),(3084,'uitgaan',50,0,1),(10000,'mony',10,1,1),(12234,'uitgaan',50,0,1),(122234,'a',555,1,1),(1000000,'',2000,1,14),(65962528,'yeet',2000,1,14);
/*!40000 ALTER TABLE `inkomsten` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-15 11:12:03
