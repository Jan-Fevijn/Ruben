-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: birthdays
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
-- Table structure for table `tourneys`
--

DROP TABLE IF EXISTS `tourneys`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tourneys` (
  `name` varchar(30) DEFAULT NULL,
  `wins` double DEFAULT NULL,
  `best` double DEFAULT NULL,
  `size` double DEFAULT NULL,
  `tourneysid` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`tourneysid`),
  UNIQUE KEY `tourneysid_UNIQUE` (`tourneysid`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tourneys`
--

LOCK TABLES `tourneys` WRITE;
/*!40000 ALTER TABLE `tourneys` DISABLE KEYS */;
INSERT INTO `tourneys` (`name`, `wins`, `best`, `size`, `tourneysid`) VALUES ('Dolly',7,245,8.5,1),('Etta',4,283,9,2),('Irma',9,266,7,3),('Barbara',2,197,7.5,4),('Gladys',13,273,8,5),('average',7,100,6,6),('average',7,100,6,7),('average',9,100,6,8),('average',9,100,6,9),('average',6,10000,6,10),('average',9,100,9,11),('average',7,100,6,12),('average',7,100,6,13),('average',9,100,6,14),('average',9,100,6,15),('average',6,100,6,16),('average',9,100,9,17);
/*!40000 ALTER TABLE `tourneys` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-15 11:11:48
