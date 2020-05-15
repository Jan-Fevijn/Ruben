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
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `idproduct` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(45) DEFAULT NULL,
  `hoeveelheid` varchar(45) DEFAULT NULL,
  `eenheid` varchar(3) DEFAULT NULL,
  `idwinkel` int(11) DEFAULT NULL,
  PRIMARY KEY (`idproduct`),
  UNIQUE KEY `idproduct_UNIQUE` (`idproduct`),
  KEY `fk_winkel` (`idwinkel`),
  CONSTRAINT `fk_winkel` FOREIGN KEY (`idwinkel`) REFERENCES `winkel` (`idwinkel`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES (1,'suiker','100','gra',1),(2,'bloem','100','gra',1),(3,'melk','1','lie',1),(4,'eieren','1','stu',1),(5,'soepvlees','100','gra',1),(6,'basilicum gehakt','100','il',1),(7,'gehakt','700','gra',1),(8,'ui','100','stu',1),(9,'ei','100','stu',1),(10,'paneermeel','100','el',1),(11,'tomaten','100','stu',1),(12,'kruidentuiltje (laurier, tijm, peterselie)','100','stu',1),(13,'wortel','100','stu',1),(14,'selder','100','stu',1),(15,'preiwit','100','stu',1),(16,'tomatenpuree','100',NULL,1),(17,'roomscheutje','100',NULL,1),(18,'boter','100',NULL,1),(19,'peper','100',NULL,1),(20,'zout','100','',1),(21,'suiker','100','el',1),(22,'bladerdeeg ','100','pla',1),(23,'kaneel','100','the',1),(24,'appel','100','stu',1),(25,'brood','100','stu',1),(26,'kaas','100','gra',1),(27,'ham','100','gra',1),(28,'gemengd gehakt','100','kg',1),(29,'dikke sneetjes pancetta','100','stu',1),(30,'dikke ui','100','stu',1),(31,'look ','100','tee',1),(32,'dikke wortel','100','g',1),(33,'champignons','100','g',1),(34,'tomatenpuree ','100','g',1),(35,'tomatenstukjes ','100','dl',1),(36,'passata van tomaten','100','dl',1),(37,'water','100','dl',1),(38,'rode wijn','100','tak',1),(39,'rozemarijn','100','sch',1),(40,'olijfolie','100','ste',1),(41,'groene selder','100','tak',1),(42,'tijm','100','stu',1),(43,'verse oregano','100','tak',1),(44,'laurierblaadje','100','stu',1),(45,'Harissa','100','toe',1),(46,'spaghetti','100','g',1),(47,'zout','100',NULL,1),(48,'peper van de molen','100',NULL,1),(49,'zout','100',NULL,1),(50,'gemalen Emmental kaas','100',NULL,1),(51,'choco','100','sne',1),(52,'Kaneelpoeder','100','tee',1);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-15 11:12:00
