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
INSERT INTO `leerlingen` (`idleerlingen`, `naam`, `famielienaam`, `idklas`, `wachtwoord`, `email`, `oefeningid`, `actief`) VALUES (1,'a','a',78,'0cc175b9c0f1b6a831c399e2697726','Ruuben.aspeslag@gmail.com',9,1),(2,'Ruben','Aspeslag',86,'0cc175b9c0f1b6a831c399e2697726','Ruben.aspeslag@gmail.com',10,1),(3,' aa','a',89,'0cc175b9c0f1b6a831c399e2697726','ruben.piediesup@gmail.com',1,1),(4,'Rupert','vde',86,'fvdcdcde0','rupert.vde@gmail.com',1,1),(5,'Jarmo','Van Moefeard',86,'0fgqdsfdggfsfdqd51dgfsgdb6sdg','Jarmo.vm@gmail.com',30,1),(6,'Dario','De cuipere',86,'0dqgqsdfdgqfdgdc','dario.decuipere@gmail.com',33,1),(7,'Dieter','Aspeslag',86,'qdfqs0dqsfqs0fdq0f','Dieter.aspeslag@gmail.com',35,1),(8,'Maarten','Aspeslag',86,'0qdgfgsdqgfvcxwvdqgsv0qfd','Maaretn.aspeslag@gmail.com',555,1),(10,'ruben','aspeslag',101,'0cc175b9c0f1b6a831c399e2697726','rubaaaen.piedisup@gmail.com',10,1),(11,'ruben','famielienaam',101,'0cc175b9c0f1b6a831c399e2697726','rubenddd.piediesup@gmail.com',82,0),(12,'ruben','famielienaam',101,'0cc175b9c0f1b6a831c399e2697726','ruben.piessssssdisup@gmail.com',10,0),(13,' d','r',103,'0cc175b9c0f1b6a831c399e2697726','mathildedemuynck@hotmail.com',7,0),(15,'ruben','aspeslag',103,'0cc175b9c0f1b6a831c399e2697726','ruben.peeiediesup@gmail.com',5,0),(16,' Ruben','aspeslag',108,'0cc175b9c0f1b6a831c399e2697726','rubeaaaaaaan.piedisup@gmail.com',3,0),(17,'Ruben','aspeslag',93,'0cc175b9c0f1b6a831c399e2697726','ruaben.aspeslag@gmail.com',2,1),(20,'Ruben','Aspeslag',108,'882baf28143fb700b388a87ef561a6','ruben.aspssssssssafdfeslag@gmail.com',3,1),(21,'Ruben','Aspeslag',115,'882baf28143fb700b388a87ef561a6','ruben.aspeddddddslag@gmail.com',2,1),(22,'Ruben','Aspeslag',108,'882baf28143fb700b388a87ef561a6','ruben.aspsssseslag@gmail.com',1,1),(200,'Ruben','Aspeslag',134,'aedfqsdfsqd','ruben.aspeslag@gmadgdgfdfdqgil.com',5,0),(205,'leerling ','1',140,'72104a570ffdc2434f0a250ee8205455','leerling1@gmail',9,0),(206,'leerling','2',140,'72104a570ffdc2434f0a250ee8205455','leerling2@gmail',2,0),(207,'leerling','3',140,'72104a570ffdc2434f0a250ee8205455','leerling3@gmail',2,0),(208,'leerling','4',140,'72104a570ffdc2434f0a250ee8205455','leerling4@gmail',2,1),(209,'leerling','5',140,'72104a570ffdc2434f0a250ee8205455','leerling5@gmail',2,1),(210,'leerling','6',140,'72104a570ffdc2434f0a250ee8205455','leerling6@gmail',2,1),(211,'leerling','7',140,'72104a570ffdc2434f0a250ee8205455','leerling7@gmail',2,1),(212,'leerling','8',140,'72104a570ffdc2434f0a250ee8205455','leerling8@gmail',2,1),(213,'leerling','9',140,'72104a570ffdc2434f0a250ee8205455','leerling9@gmail',2,0),(214,'leerling','10',140,'72104a570ffdc2434f0a250ee8205455','leerling10@gmail',2,0),(215,'Ruben','aspeslag',144,'18b161fea5f73a67e9d486ad98f523e2','ruben.asssaspeslag@gmail.com',1,0);
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

-- Dump completed on 2020-04-18 15:56:18
