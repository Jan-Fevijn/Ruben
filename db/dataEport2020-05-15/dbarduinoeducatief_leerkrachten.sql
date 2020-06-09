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
-- Table structure for table `leerkrachten`
--

DROP TABLE IF EXISTS `leerkrachten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `leerkrachten` (
  `idleerkrachten` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(10) NOT NULL,
  `famielienaam` varchar(20) NOT NULL,
  `wachtwoord` varchar(100) NOT NULL,
  `email` varchar(45) NOT NULL,
  `actief` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`idleerkrachten`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=134 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `leerkrachten`
--

LOCK TABLES `leerkrachten` WRITE;
/*!40000 ALTER TABLE `leerkrachten` DISABLE KEYS */;
INSERT INTO `leerkrachten` (`idleerkrachten`, `naam`, `famielienaam`, `wachtwoord`, `email`, `actief`) VALUES (79,'Ruben','aspeslag','0cc175b9c0f1b6a831c399e269772661','Rauben.aspeslag@gmail.com',1),(80,'Ruben','famielienaam','e1e1d3d40573127e9ee0480caf1283','ruben.piediesup@gmail.com',1),(81,'a','a','0cc175b9c0f1b6a831c399e2697726','Ruben@aaaaaaaaa',1),(82,'z','z','fbade9e36a3f36d3d676c1b808451d','Ruben.azzzspeslag@gmail.com',1),(83,'Ruben','aspeslag','72104a570ffdc2434f0a250ee82054','Rubeffffffffn.aspeslag@gmail.com',1),(87,'ruben','aspeslag','882baf28143fb700b388a87ef561a6','ruuuuben.piediesup@gmail.com',1),(88,'q','q',' 882baf28143fb700b388a87ef561a','ruben.piedqqqqqiesup@gmail.com',1),(89,'ruben','aspeslag','882baf28143fb700b388a87ef561a6','rrrrrruben.piedisup@gmail.com',1),(93,'ruben','aspeslag','882baf28143fb700b388a87ef561a6','Ruoooooooooooben@aaaaa',1),(94,'ruben','aspeslag','882baf28143fb700b388a87ef561a6','Raaaaaauben.aspeslag@gmail.com',1),(95,'ruben','aspeslag','882baf28143fb700b388a87ef561a6','rubesssssssssn.piedisup@gmail.com',1),(96,'ruben','famielienaam','882baf28143fb700b388a87ef561a6','Raaaaaaaaauben.aspeslag@gmail.com',1),(100,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6','ruben.aspeqsdfqsfdqgfslag@gmail.com',1),(101,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6','ruben.aspeslsssssssssssdag@gmail.com',1),(103,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6e5','ruben.aseeeeeeepeslag@gmail.com',1),(104,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6e5','ruben.aspesdddlag@gmail.com',1),(105,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6e5','ruben.aspesdfsqfsslag@gmail.com',1),(106,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6e5','ruben.aspssssssssaeslag@gmail.com',1),(107,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6e5','ruben.aaaazspeslag@gmail.com',1),(108,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6e5','rubefqsfearen.aspeslag@gmail.com',1),(109,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6e5','ruben.aspesqqfqfsqfeslag@gmail.com',1),(111,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6e5','ruben.aspqsfqecxqeslag@gmail.com',1),(112,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6e5','ruben.aqsfdsqfcszspeslag@gmail.com',1),(114,'azerty123','azerty123','882baf28143fb700b388a87ef561a6e5','rubeazerty123n.aspeslag@gmail.com',1),(115,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6e5','rubazerty123en.aspazerty123eslag@gmail.com',1),(116,'Ruben','Aspeslag','882baf28143fb700b388a87ef561a6e5','ruben.aspqfqefdxqfeeslag@gmail.com',1),(117,'azerty2222','Aspeslag','882baf28143fb700b388a87ef561a6e5','rubesqdfqxzaen.aspeslag@gmail.com',1),(119,'Ruben','aspeslag','882baf28143fb700b388a87ef561a6e5','ruben.aqsfsqfsqdjlfhspeslag@gmail.com',1),(120,'Ruben','aspeslag','882baf28143fb700b388a87ef561a6e5','ruben.aspeslagdds@gmail.com',1),(121,'a','b','882baf28143fb700b388a87ef561a6e5','fqsfdfsvdwfqsf@sdjfksql',1),(122,'Ruben','aspeslag','882baf28143fb700b388a87ef561a6e5','ruben.assdfqpeslag@gmail.com',1),(123,'a','a','882baf28143fb700b388a87ef561a6e5','ruben.aspeddddaaslag@gmail.com',1),(124,'a','azerty123','882baf28143fb700b388a87ef561a6e5','ruben.asqfsqdfsqspeslag@gmail.com',1),(125,'Hannes','De Kezel','72104a570ffdc2434f0a250ee8205455','leerkracht@gmail',1),(127,'Ruben','Aspeslag','18b161fea5f73a67e9d486ad98f523e2','ruben.asdqsffqsfqqsdfdpeslag@gmail.com',1),(129,'ruben','famielienaam','18b161fea5f73a67e9d486ad98f523e2','rubeqqqqqn.piedisup@gmail.com',1),(130,'ruben','aspeslag','18b161fea5f73a67e9d486ad98f523e2','rubaaaen.piedisup@gmail.com',1),(131,'ruben','aspeslag','18b161fea5f73a67e9d486ad98f523e2','rubaaaean.aspeslag@gmail.com',1),(132,'ruben','aspeslag','18b161fea5f73a67e9d486ad98f523e2','ruben.aspe55slag@gmail.com',1),(133,'ruben','aspeslag','18b161fea5f73a67e9d486ad98f523e2','ruben.piediaasup@gmail.com',1);
/*!40000 ALTER TABLE `leerkrachten` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-15 11:11:53
