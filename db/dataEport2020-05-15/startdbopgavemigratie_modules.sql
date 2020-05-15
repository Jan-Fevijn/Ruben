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
-- Table structure for table `modules`
--

DROP TABLE IF EXISTS `modules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `modules` (
  `idModules` int(11) NOT NULL AUTO_INCREMENT,
  `ModuleNaam` varchar(45) DEFAULT NULL,
  `ModuleJaar` varchar(45) DEFAULT NULL,
  `ModuleGraad` varchar(45) DEFAULT NULL,
  `ModuleWeken` int(11) DEFAULT NULL,
  `ModulePrijs` decimal(10,0) DEFAULT NULL,
  `ModuleLeerkracht` varchar(45) DEFAULT NULL,
  `ModuleMaxAantal` int(11) DEFAULT NULL,
  PRIMARY KEY (`idModules`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modules`
--

LOCK TABLES `modules` WRITE;
/*!40000 ALTER TABLE `modules` DISABLE KEYS */;
INSERT INTO `modules` (`idModules`, `ModuleNaam`, `ModuleJaar`, `ModuleGraad`, `ModuleWeken`, `ModulePrijs`, `ModuleLeerkracht`, `ModuleMaxAantal`) VALUES (1,'sport en spel','18/19','1',4,10,'jan sporters',15),(2,'kaarten','18/19','1',3,0,'kaatje kaart',10),(3,'rugby','19/20','1',4,5,'ruige bert',12),(4,NULL,NULL,NULL,NULL,NULL,'hannes dekezesel ',NULL),(5,NULL,NULL,NULL,NULL,NULL,'hannes de kesel',NULL),(6,NULL,NULL,NULL,NULL,NULL,'bart burgrave',NULL),(7,NULL,NULL,NULL,NULL,NULL,'hannes dekezesel ',NULL),(8,NULL,NULL,NULL,NULL,NULL,'hannes de kesel',NULL),(9,NULL,NULL,NULL,NULL,NULL,'bart burgrave',NULL),(10,NULL,NULL,NULL,NULL,NULL,'hannes dekezesel ',NULL),(11,NULL,NULL,NULL,NULL,NULL,'hannes de kesel',NULL),(12,NULL,NULL,NULL,NULL,NULL,'bart burgrave',NULL),(13,NULL,NULL,NULL,NULL,NULL,'hannes dekezesel ',NULL),(14,NULL,NULL,NULL,NULL,NULL,'hannes de kesel',NULL),(15,NULL,NULL,NULL,NULL,NULL,'bart burgrave',NULL),(16,NULL,NULL,NULL,NULL,NULL,'hannes dekezesel ',NULL),(17,NULL,NULL,NULL,NULL,NULL,'hannes de kesel',NULL),(18,NULL,NULL,NULL,NULL,NULL,'bart burgrave',NULL);
/*!40000 ALTER TABLE `modules` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-15 11:11:56
