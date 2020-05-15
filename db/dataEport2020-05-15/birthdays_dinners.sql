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
-- Table structure for table `dinners`
--

DROP TABLE IF EXISTS `dinners`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dinners` (
  `name` varchar(30) DEFAULT NULL,
  `birthdate` date DEFAULT NULL,
  `entree` varchar(30) DEFAULT NULL,
  `side` varchar(30) DEFAULT NULL,
  `dessert` varchar(30) DEFAULT NULL,
  `tourneyID` int(11) DEFAULT NULL,
  `dinnerid` int(11) NOT NULL AUTO_INCREMENT,
  `opNaam` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`dinnerid`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dinners`
--

LOCK TABLES `dinners` WRITE;
/*!40000 ALTER TABLE `dinners` DISABLE KEYS */;
INSERT INTO `dinners` (`name`, `birthdate`, `entree`, `side`, `dessert`, `tourneyID`, `dinnerid`, `opNaam`) VALUES ('Dolly','1946-01-19','steak','salad','cake',NULL,1,NULL),('Etta','1938-01-25','chicken','fries','ice cream',NULL,2,NULL),('Irma','1941-02-18','tofu','fries','cake',NULL,3,NULL),('Barbara','1948-12-25','tofu','salad','ice cream',NULL,4,NULL),('Gladys','1944-05-28','steak','fries','ice cream',NULL,5,NULL);
/*!40000 ALTER TABLE `dinners` ENABLE KEYS */;
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
