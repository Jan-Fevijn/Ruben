-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: kokenvoorgroepen
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
-- Table structure for table `produtgerecht`
--

DROP TABLE IF EXISTS `produtgerecht`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produtgerecht` (
  `idprodutGerecht` int(11) NOT NULL AUTO_INCREMENT,
  `gerechtid` int(11) DEFAULT NULL,
  `productid` int(11) DEFAULT NULL,
  `hoeveelheid` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idprodutGerecht`),
  KEY `fk_gerecht` (`gerechtid`),
  CONSTRAINT `fk_gerecht` FOREIGN KEY (`gerechtid`) REFERENCES `gerecht` (`idgerecht`)
) ENGINE=InnoDB AUTO_INCREMENT=59 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtgerecht`
--

LOCK TABLES `produtgerecht` WRITE;
/*!40000 ALTER TABLE `produtgerecht` DISABLE KEYS */;
INSERT INTO `produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES (1,1,1,'62.5'),(2,1,2,'1.25'),(3,1,3,'0.75'),(4,1,4,'0.25'),(5,2,5,'100'),(6,2,6,'0.5'),(7,2,7,'75'),(8,2,8,'0.5'),(9,2,9,'0.25'),(10,2,10,'0.5'),(11,2,11,'1.25'),(12,2,12,'0.25'),(13,2,13,'0.25'),(14,2,14,'0.25'),(15,2,15,'0.25'),(16,2,16,'0.5'),(17,2,17,'1'),(18,2,18,'1'),(19,2,19,'1'),(20,2,20,'1'),(21,3,9,'2'),(22,4,21,'2'),(23,4,22,'4'),(24,4,23,'1'),(25,4,24,'1'),(26,5,25,'6'),(27,5,26,'3'),(28,5,27,'3'),(29,6,28,'0.25'),(30,6,29,'1'),(31,6,30,'0.25'),(32,6,31,'0.25'),(33,6,32,'0.5'),(34,6,33,'62.5 '),(35,6,34,'25 '),(36,6,35,'200 '),(37,6,36,'0.75'),(38,6,37,'0.5'),(39,6,38,'0.25'),(40,6,39,'0.5'),(41,6,40,'1'),(42,6,41,'1'),(43,6,42,'0.5'),(44,6,43,'0.5'),(45,6,44,'0.5'),(46,6,45,'1'),(47,6,46,'125'),(48,6,47,NULL),(49,6,48,NULL),(50,6,49,NULL),(51,6,50,NULL),(53,7,25,'6'),(54,7,51,'3'),(56,8,24,'5'),(57,8,1,'100'),(58,8,52,'100');
/*!40000 ALTER TABLE `produtgerecht` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-15 11:12:01
