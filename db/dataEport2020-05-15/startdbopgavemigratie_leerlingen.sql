-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: startdbopgavemigratie
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
  `idLeerlingen` int(11) NOT NULL AUTO_INCREMENT,
  `Naam` varchar(45) DEFAULT NULL,
  `Voornaam` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `geboortedatum` date DEFAULT NULL,
  `schooljaar` varchar(45) DEFAULT NULL,
  `klas` varchar(45) DEFAULT NULL,
  `ModuleID` int(11) DEFAULT NULL,
  `klastitularis` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idLeerlingen`),
  UNIQUE KEY `uniek` (`Naam`,`Voornaam`,`schooljaar`,`klas`,`ModuleID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `leerlingen`
--

LOCK TABLES `leerlingen` WRITE;
/*!40000 ALTER TABLE `leerlingen` DISABLE KEYS */;
INSERT INTO `leerlingen` (`idLeerlingen`, `Naam`, `Voornaam`, `email`, `geboortedatum`, `schooljaar`, `klas`, `ModuleID`, `klastitularis`) VALUES (1,'pieters','pieter','p.p@gmail.com','1990-05-05','18/19','2bvl',1,'hannes de kezesel '),(2,'karelsen','karel','k.k@gmail.com','1995-05-05','18/19','1ab',2,'hannes de kesel'),(3,'Stevens','Steven','s.s@gmail.com','1995-05-06','19/20','1ab',2,'bart burgrave');
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

-- Dump completed on 2020-05-15 11:11:57
