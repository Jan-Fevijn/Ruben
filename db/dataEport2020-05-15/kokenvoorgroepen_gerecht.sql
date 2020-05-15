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
-- Table structure for table `gerecht`
--

DROP TABLE IF EXISTS `gerecht`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gerecht` (
  `idgerecht` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(45) DEFAULT NULL,
  `img` varchar(700) DEFAULT NULL,
  `vegan` tinyint(4) DEFAULT NULL,
  `veganistisch` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`idgerecht`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gerecht`
--

LOCK TABLES `gerecht` WRITE;
/*!40000 ALTER TABLE `gerecht` DISABLE KEYS */;
INSERT INTO `gerecht` (`idgerecht`, `naam`, `img`, `vegan`, `veganistisch`) VALUES (1,'pannenkoeken','https://vegetus.nl/wp-content/uploads/2013/02/Pannenkoeken-veganistisch-zonder-melk-zonder-ei.jpg',1,0),(2,'tomatensoep','https://img.static-rmg.be/a/food/image/q75/w640/h400/12475/tomatensoep-met-balletjes.jpg',0,0),(3,'omelet','http://i1.wp.com/lotkookt.com/wp-content/uploads/2015/07/goedgevulde-omelet-met-feta-tomaat-en-rucola2.png?zoom=1.75&resize=683%2C478',1,0),(4,'LEKKER EN SIMPEL: APPELTAARTJES','http://i1279.photobucket.com/albums/y537/lekkerensimpel/2014/jan/IMG_7520_zps42e58d30.jpg',0,0),(5,'croque monsieur','https://static.nieuwsblad.be/Assets/Images_Upload/2016/11/01/croque.jpg?maxheight=460&maxwidth=638&scale=both',0,0),(6,'Spaghetti bolognaise','https://www.42brasso.be/wp-content/uploads/spaghettibolognaise.jpg',0,0),(7,'boterham met choco','https://images3.persgroep.net/rcs/OOwUxAWaKRQFN518VpSm4fubAGM/diocontent/63408847/_fitwidth/763?appId=2dc96dd3f167e919913d808324cbfeb2&quality=0.8',1,0),(8,'appelmoes','https://www.appelmoesmaken.eu/wp-content/uploads/2019/07/Appelmoes-maken-748x410.jpg',0,1);
/*!40000 ALTER TABLE `gerecht` ENABLE KEYS */;
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
