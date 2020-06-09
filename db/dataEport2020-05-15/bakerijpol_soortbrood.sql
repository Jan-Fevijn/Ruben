-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bakerijpol
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
-- Table structure for table `soortbrood`
--

DROP TABLE IF EXISTS `soortbrood`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `soortbrood` (
  `idsoortBrood` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(20) DEFAULT NULL,
  `img` varchar(30) DEFAULT NULL,
  `hoeveelheid` int(11) DEFAULT NULL,
  `prijs` decimal(8,2) DEFAULT NULL,
  PRIMARY KEY (`idsoortBrood`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `soortbrood`
--

LOCK TABLES `soortbrood` WRITE;
/*!40000 ALTER TABLE `soortbrood` DISABLE KEYS */;
INSERT INTO `soortbrood` (`idsoortBrood`, `naam`, `img`, `hoeveelheid`, `prijs`) VALUES (1,'meergranenbrood broo',NULL,5,2.00),(2,'volkoren brood',NULL,4,2.00),(3,'chocolade brood',NULL,5,3.00),(4,'Wit brood',NULL,5,2.00),(5,'bruin brood',NULL,5,2.00),(6,'tijgerbrood',NULL,5,2.00),(7,'boterkoek',NULL,5,3.00),(8,'croissant',NULL,5,3.00),(9,'rozijnenbrood',NULL,-7,2.00),(10,'somsonbrood','',5,2.00),(16,'mm',NULL,NULL,10.00);
/*!40000 ALTER TABLE `soortbrood` ENABLE KEYS */;
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
