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
-- Table structure for table `oefeningen`
--

DROP TABLE IF EXISTS `oefeningen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `oefeningen` (
  `idoefeningen` int(11) NOT NULL,
  `bodyDeel1` longtext,
  `tietel` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idoefeningen`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `oefeningen`
--

LOCK TABLES `oefeningen` WRITE;
/*!40000 ALTER TABLE `oefeningen` DISABLE KEYS */;
INSERT INTO `oefeningen` (`idoefeningen`, `bodyDeel1`, `tietel`) VALUES 
(1,'<p>Als je in de doos kijkt van je Arduino zal je zeker de volgende dingen zien (je zal ze allemaal nodig hebben):</p>\r\n\r\n<p><strong>De arduino</strong> zelf, deze ziet er als volgt uit:<br />\r\n<img src=\"../img/arduino.png\" style=\"height:100px; width:100px\" /></p>\r\n\r\n<p><strong>Het bord</strong><br />\r\n<img src=\"../img/arduinoBoard.png\" style=\"height:100px; width:100px\" /><br />\r\nHet bord zal je veel nodig hebben om alles erop aan te sluiten en deze te verbinden met je Arduino.<br />\r\n&nbsp;</p>\r\n\r\n<p><strong>De usb kabel </strong>waarmee je de arduino en de pc met elkaar kunt verbinden.<br />\r\n<img src=\"../img/usb.png\" style=\"height:80px; width:200px\" /><br />\r\n&nbsp;</p>\r\n\r\n<p><strong>Je ledjes </strong>(je zal er meerdere hebben en in verschillende kleuren):<br />\r\n<img src=\"../img/led.png\" style=\"height:80px; width:200px\" /><br />\r\n&nbsp;</p>\r\n\r\n<p><strong>De draadjes:</strong><br />\r\n<img src=\"../img/draadjes.png\" style=\"height:100px; width:300px\" /><br />\r\nDeze heb je nodig om alles op elkaar aan te sluiten, je mag die plooien, want dit kan geen kwaad.<br />\r\n<br />\r\n&nbsp;</p>\r\n\r\n<p><strong>De lichtsensor:</strong><br />\r\n<img src=\"../img/lichtsensor.png\" style=\"height:100px; width:300px\" /><br />\r\n&nbsp;</p>\r\n ',NULL),
(2,'<ul>\r\n	<li>Electriciteit loopt altijd in een kring met een verbruiker (bv een lampje). De kring moet altijd gesloten zijn. Je hebt ook&nbsp; een energiebron nodig (in ons geval een poort van de Arduino). Een gesloten kring zonder verbruiker veroorzaakt kortsluiting, geen zorgen je Arduino is daar tegen beveiligd en zal daarvan niet stuk gaan.</li>\r\n	<li>Electriciteit kiest altijd de makkelijkste weg om de cirkel te sluiten, zorg er dus voor dat het verplicht is om door de verbruiker te komen. Want als er een andere omweg is zal de electriciteit die omweg nemen ipv de verbruiker en dan veroorzaak je weer kortsluiting.</li>\r\n</ul>\r\n ',NULL),
(3,' <p>Download s4a (scratch for arduino) <a href=\"https://s4a.soft112.com/\" target=\"_blank\"> klik hier om het te downloaden</a> . Download het hele pakket, dan kan je op &quot;next&quot; klikken.</p>',NULL),
(4,' <p><img src=\"../img/s4aUitleg1.png\" style=\"height:300px; width:500px\" /></p> <p>&nbsp;</p> <table border=\"1\">  <tbody> <tr>   <th>nummers</th>   <th>uitleg</th>  </tr>    <tr> <td>1</td> <td>Hier kun je kiezen welk type blokjes je nodig hebt</td>    </tr>  <tr> <td>2</td>  <td>Hieruit kun je blokjes kiezen en ze naar je &quot;script&quot; slepen. Ieder blokje heeft een specifieke functie.</td>  </tr>  <tr>  <td>3</td> <td>   <p>Hier moet je je blokjes naartoe slepen, en aan elkaar hangen. Je arduino zal alles van boven naar beneden uitvoeren zodra je of het groen vlaggetje klikt (5).</p>  <p>De blokjes die je hier naartoe gesleept hebt vormen je &quot;script&quot;</p>  </td> </tr>  <tr> <td>4</td> <td>Hieraan kun je zien of je arduino correct aangesloten is aan je pc. Als het goed is aangesloten krijg je een afbeelding van het bord .Indien niet komt er &quot;bord wordt gezocht &quot;op.&nbsp;</td>   </tr>  <tr> <td>5</td>  <td>Het vlaggetje dat ervoor zorgt dat je &quot;script&quot; start als je er op drukt.Ernaast is er een rood bolletje (stopteken) dat er voor zorgt dat je &quot;script&quot; stopt.</td>   </tr>  </tbody> </table>',NULL),
(5,'<table border=\"1\">\r\n	<tbody>\r\n		<tr>\r\n			<th>blokjes</th>\r\n			<th>functie</th>\r\n		</tr>\r\n		<tr>\r\n			<td><img src=\"../img/s4ablokjesStart.png\" /></td>\r\n			<td>Dit is bijna altijd je eerste blokje die je nodig hebt. Die plaats je altijd vanboven in je script. De functie van de blokjes die je er onder hebt geplaatst zal uitgevoerd worden.(Deze staat bij besturen.)</td>\r\n		</tr>\r\n		<tr>\r\n			<td><img src=\"../img/s4aBlokjesDigitaalAan.png\" /></td>\r\n			<td>Hier kan je de digitale poort op je Arduino aanzetten waardoor er stroom komt te staan op die poort. Als je alles goed aangesloten hebt aan die poort zullen&nbsp; er bv. aangesloten lichtjes moeten branden (dit leer je nog in deze cursus.)<br />\r\n			<img src=\"../img/s4aDigitaalPoorten.png\" style=\"float:left; height:300px; width:300px\" />Dat zijn de poorten die hiernaast met een accolade aangeduid zijn. Als je bv digitaal 13 hebt aangeduid in je code moet je er ook voor zorgen dat je poort 13 met je bord hebt verbonden. (dit is de energiebron )</td>\r\n		</tr>\r\n		<tr>\r\n			<td><img src=\"../img/s4aBlokjesDigitaalUit.png\" /></td>\r\n			<td>Met dit blokje zet je de aangeduide digitale poort weer uit.</td>\r\n		</tr>\r\n	</tbody>\r\n</table>\r\n\r\n<p>De andere blokken spreken voor zich, heb je niet nodig in deze cursus of worden later nog uitgelegd wanneer ze wel relevant worden.</p>\r\n ',NULL),
(6,'<p>Nu gaan we alles dat je in de vorige instructies geleerd hebt samenvoegen en toepassen.<br />\r\nDit is hoe het bord onderling verbonden is van binnen.<br />\r\n<img src=\"../img/boardOnderlingVerbonden.jpg\" style=\"height:300px\" /><br />\r\nOp deze manier moet je ervoor zorgen dat je een <strong>gesloten</strong> kring bekomt die begint in digitaal 10-13 en eindigd in de GND (zijn beiden poorten op je Arduino)</p>\r\n\r\n<h2>Eerste schema : een lichtje aansluiten.</h2>\r\n\r\n<p>Op de volgende manier kan je een lichtje laten branden. Je hebt 2 draadje nodig, een ledje en een weerstand. Verbindt deze zoals hieronder op de afbeelding. Aan het ledje heb je twee draadjes, (een lange en een kortere). De langste moet het dichtst bij de energiebron (digitale poort) verbonden worden. Als je dit niet juist doet dan zal je ledje niet branden.<br />\r\n<br />\r\ndus voor de duidelijkheid je moet je ledje als volgt aansluiten:<br />\r\n<img alt=\"\" src=\"../img/lichtDirection.png\" style=\"height:137px; width:184px\" /><br />\r\n<img src=\"../img/arduinoSchemaLicht.png\" style=\"height:200px; width:400px\" /><br />\r\nOp je script gebruik je volgende blokjes . Links bovenaan vind je de knoppen met de hoofdfuncties vb: bewegen,besturen, waarnemen. Je zal zien dat elk soort blokje een bepaald kleur heeft. Als je een hoofdfunctie aanklikt verschijnen er verschillende blokjes links in beeld waaruit je kan kiezen. In dit geval is je eerste blokje het oranje blokje op de foto hieronder: je vindt deze onder de hoofdfunctie : besturen.<br />\r\n<img src=\"../img/s4aCodeBrandentLichtje1.png\" style=\"height:200px; width:400px\" /><br />\r\nJe draadje verbond je van poort 13 naar je bord. Dus moet je nu een blokje aan je script toevoegen die zorgt dat digitale poort 13 aanstaat. Je kan zelf het nummer aanpassen via het zwarte pijltje naast het cijfer. Het is belangrijk dat je draadje op je Arduino in dezelfde poort zit als aangegeven op je script.<br />\r\n<img src=\"../img/s4aCodeBrandentLichtje.png\" style=\"height:200px; width:400px\" /></p>\r\n\r\n<p>Probeer nu op dezelfde manier de blokjes te verbinden zoals op de afbeelding hierboven. Als je dit juist hebt gedaan dan zal het ledje knipperen. De duur van het knipperen kan je aanpassen op het blokje &#39; wacht... tellen&#39;.</p>\r\n ',NULL),
(7,'<h3>oefening 1</h3>\r\n\r\n<p>Probeer hetzelfde nu te bekomen nadat je het ledje verplaatst hebt met &eacute;&eacute;n of meerdere kabels indien nodig (denk eraan dat je kring gesloten moet zijn en dat je ledje in de juiste richting staat)<br />\r\nDit is wat je had.&nbsp;<br />\r\n<img src=\"../img/arduinoSchemaLicht.png\" style=\"height:200px; width:400px\" /><br />\r\nJe kan weten of je oefening juist is door te kijken of je lichtje effectief brandt / knippert(bij het klikken op de startknop), als dit niet het geval is komt er nog een ander vorbeeld op als je op &quot;next&quot; drukt.</p>\r\n ',NULL),
(8,'<p>Dit is een voorbeeld van een juiste oefening (als je lichtje brandt / knippert&nbsp;is de oefening juist).<br />\r\n<img src=\"../img/arduinoSchemaLicht2.png\" style=\"height:150px; width:200px\" /><br />\r\nHet rode draadje moet wel nog steeds in digital 10-13 zitten.</p>\r\n ',NULL);
/*!40000 ALTER TABLE `oefeningen` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-12 17:56:35
