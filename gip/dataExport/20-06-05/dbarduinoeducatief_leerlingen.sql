-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: dbarduinoeducatief
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
-- Table structure for table `leerlingen`
--

DROP TABLE IF EXISTS `leerlingen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `leerlingen` (
  `idleerlingen` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(10) NOT NULL,
  `famielienaam` varchar(20) NOT NULL,
  `idklas` decimal(10,0) NOT NULL,
  `wachtwoord` varchar(1000) NOT NULL,
  `email` varchar(45) NOT NULL,
  `oefeningid` int(11) DEFAULT NULL,
  `actief` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`idleerlingen`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=216 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `leerlingen`
--

LOCK TABLES `leerlingen` WRITE;
/*!40000 ALTER TABLE `leerlingen` DISABLE KEYS */;
INSERT INTO `leerlingen` (`idleerlingen`, `naam`, `famielienaam`, `idklas`, `wachtwoord`, `email`, `oefeningid`, `actief`) VALUES (1,'Ruben ','Aspeslag ',2,'18b161fea5f73a67e9d486ad98f523e2 ','L1@gmail.com',1,1),(2,'Jarmo ','Van Moeffaert ',2,'18b161fea5f73a67e9d486ad98f523e2 ','L2@gmail.com',1,1),(3,'Lorenzo ','Wintein',2,'18b161fea5f73a67e9d486ad98f523e2 ','L3@gmail.com',1,1),(4,'Rupert ','Van Den Eynde',2,'18b161fea5f73a67e9d486ad98f523e2 ','L4@gmail.com',1,1),(5,'Jordi ','Taillaert',2,'18b161fea5f73a67e9d486ad98f523e2 ','L5@gmail.com',1,1),(6,'Rubin ','Paudel',2,'18b161fea5f73a67e9d486ad98f523e2 ','L6@gmail.com',1,1),(7,'Siebe ','Hindryckx ',2,'18b161fea5f73a67e9d486ad98f523e2 ','L7@gmail.com',1,1),(8,'Dario ','Decuypere ',2,'18b161fea5f73a67e9d486ad98f523e2 ','L8@gmail.com',1,1),(9,'Thymen ','Van Bievliet',1,'18b161fea5f73a67e9d486ad98f523e2 ','L9@gmail.com',1,1);
/*!40000 ALTER TABLE `leerlingen` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-05 15:20:51
