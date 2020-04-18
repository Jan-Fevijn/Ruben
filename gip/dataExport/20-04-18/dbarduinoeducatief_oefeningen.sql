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
INSERT INTO `oefeningen` (`idoefeningen`, `bodyDeel1`, `tietel`) VALUES (1,' <p>Als je in de doos kijkt van je arduino zal je zeker de volgende dingen zien (je zal ze allemaal nodig hebben)</p> <p>de arduino zelf, deze ziet er als volgt uit:<br /> <img src=\"../img/arduino.png\" style=\"height:100px; width:100px\" /></p> <p>het bord<br />  <img src=\"../img/arduinoBoard.png\" style=\"height:100px; width:100px\" /><br />  deze zal je veel nodig hebben om alles erop aan te sluiten en deze te verbinden met je arduino.<br /> &nbsp;</p> <p>de usb kabel waarmee je de arduino en de pc met elkaar kunt verbinden<br /> <img src=\"../img/usb.png\" style=\"height:80px; width:200px\" /><br /> &nbsp;</p> <p>je ledjes (je zal er meerdere hebben en in verschillende kleuren)<br /> <img src=\".../img/arduinoLed.png\" style=\"height:80px; width:200px\" /><br /> &nbsp;</p> <p>de draadjes<br /> <img src=\"../img/draatjes.png\" style=\"height:100px; width:300px\" /><br />deze heb je nodig om alles op elkaar aan te sluiten, je mag die plooien, want dit kan geen kwaad<br />  <br />&nbsp;</p> <p>de lichtsensor<br /><img src=\"../img/lichtsensor.png\" style=\"height:100px; width:300px\" /><br /> &nbsp;</p>',NULL),(2,' <ul>  <li>Electriciteit loopt altijd in een kring met een verbruiker (bv een lampje). De kring moet altijd gesloten zijn. Je hebt ook&nbsp; een energiebron nodig (in ons geval een poort van de arduino). Een gesloten kring zonder verbruiker veroorzaakt kortsluiting, geen zorgen je arduino is daar tegen beveiligd en zal daarvan niet stuk gaan.</li>   <li>Electriciteit kiest altijd de makkelijkste weg om de cirkel te sluiten, zorg er dus voor dat het verplicht is om door de verbruiker te komen. Want als er een andere omweg is zal de electriciteit die omweg nemen ipv de verbruiker en dan veroorzaak je weer kortsluiting.</li> </ul>',NULL),(3,' <p>Download s4a (scratch for arduino) <a href=\"https://s4a.soft112.com/\" target=\"_blank\"> klik hier om het te downloaden</a> . Download het hele pakket, dan kan je op &quot;next&quot; klikken.</p>',NULL),(4,' <p><img src=\"../img/s4aUitleg1.png\" style=\"height:300px; width:500px\" /></p> <p>&nbsp;</p> <table border=\"1\">  <tbody> <tr>   <th>nummers</th>   <th>uitleg</th>  </tr>    <tr> <td>1</td> <td>Hier kun je kiezen welk type blokjes je nodig hebt</td>    </tr>  <tr> <td>2</td>  <td>Hieruit kun je blokjes kiezen en ze naar je &quot;script&quot; slepen. Ieder blokje heeft een specifieke functie.</td>  </tr>  <tr>  <td>3</td> <td>   <p>Hier moet je je blokjes naartoe slepen, en aan elkaar hangen. Je arduino zal alles van boven naar beneden uitvoeren zodra je of het groen vlaggetje klikt (5).</p>  <p>De blokjes die je hier naartoe gesleept hebt vormen je &quot;script&quot;</p>  </td> </tr>  <tr> <td>4</td> <td>Hieraan kun je zien of je arduino correct aangesloten is aan je pc. Als het goed is aangesloten krijg je een afbeelding van het bord .Indien niet komt er &quot;bord wordt gezocht &quot;op.&nbsp;</td>   </tr>  <tr> <td>5</td>  <td>Het vlaggetje dat ervoor zorgt dat je &quot;script&quot; start als je er op drukt.Ernaast is er een rood bolletje (stopteken) dat er voor zorgt dat je &quot;script&quot; stopt.</td>   </tr>  </tbody> </table>',NULL),(5,' <table border=\"1\"> <tbody> <tr><th>blokjes</th><th>functie</th></tr><tr><td><img src=\"../img/s4ablokjesStart.png\" /></td><td>Dit is bijna altijd je eerste blokje die je nodig hebt. Die plaats je altijd vanboven in je script. De functie van de blokjes die je er onder hebt geplaatst zal uitgevoerd worden.(Deze staat bij besturen.)</td> </tr> <tr> <td><img src=\"../img/s4aBlokjesDigitaalAan.png\" /></td><td>Hier kan je de digitale poort op je arduino aanzetten waardoor er stroom komt te staan op die poort. Als je alles goed aangesloten hebt aan die poort zullen&nbsp; er bv. aangesloten lichtjes moeten branden (dit leer je nog in deze cursus.)<br /> <img src=\"../img/s4aDigitaalPoorten.png\" style=\"float:left; height:300px; width:300px\" />Dat zijn de poorten die hiernaast met een accolade aangeduid zijn. Als je bv digitaal 13 hebt aangeduid in je code moet je er ook voor zorgen dat je poort 13 met je bord hebt verbonden. (dit is de energiebron )</td></tr><tr><td><img src=\"../img/s4aBlokjesDigitaalUit.png\" /></td><td>Met dit blokje zet je de aangeduide digitale poort weer uit.</td></tr></tbody></table><p>De andere blokken spreken voor zich, heb je niet nodig in deze cursus of worden later nog uitgelegd wanneer ze wel relevant worden.</p>',NULL),(6,'<p>Nu gaan we alles dat je in de vorige instructies geleerd hebt samenvoegen en toepassen.<br /> Dit is hoe het bord onderling verbonden is van binnen.<br /> <img src=\"../img/boardOnderlingVerbonden.jpg\" style=\"height:300px\" /><br /> Op deze manier moet je ervoor zorgen dat je een <strong>gesloten</strong> kring bekomt die begint in digitaal 10-13 en eindigd in de GND (zijn beiden poorten op je arduino)</p> <h2>Eerste schema : een lichtje aansluiten.</h2> <p>  Op de volgende manier kan je een lichtje laten branden. Je hebt 2 draadje nodig, een ledje en een weerstand. Verbindt deze zoals hieronder op de afbeelding. Aan het ledje heb je twee draadjes, (een lange en een kortere). De langste moet het dichtst bij de energiebron (digitale poort) verbonden worden. Als je dit niet juist doet dan zal je ledje niet branden.<br />  <br />dus voor de duidelijkheid je moet je ledje als volgd aansluiten:<br /> <img  alt=\"\" src=\"../img/lichtDirection.png\" style=\"height:137px; width:184px\" />   <br />  <img src=\"../img/arduinoSchemaLicht.png\" style=\"height:200px; width:400px\" /><br /> Op je script gebruik je volgende blokjes . Links bovenaan vind je de knoppen met de hoofdfuncties vb: bewegen,besturen, waarnemen. Je zal zien dat elk soort blokje een bepaald kleur heeft. Als je een hoofdfunctie aanklikt verschijnen er verschillende blokjes links in beeld waaruit je kan kiezen. In dit geval is je eerste blokje het oranje blokje op de foto hieronder: je vindt deze onder de hoofdfunctie : besturen.<br />  <img src=\"../img/s4aCodeBrandentLichtje1.png\" style=\"height:200px; width:400px\" /><br /> Je draadje verbond je van poort 13 naar je bord. Dus moet je nu een blokje aan je script toevoegen die zorgt dat digitale poort 13 aanstaat. Je kan zelf het nummer aanpassen via het zwarte pijltje naast het cijfer. Het is belangrijk dat je draadje op je arduino in dezelfde poort zit als aangegeven op je script.<br />   <img src=\"../img/s4aCodeBrandentLichtje.png\" style=\"height:200px; width:400px\" /> </p> <p>Probeer nu op dezelfde manier de blokjes te verbinden zoals op de afbeelding hierboven. Als je dit juist hebt gedaan dan zal het ledje knipperen. De duur van het knipperen kan je aanpassen op het blokje &#39; wacht... tellen&#39;.</p>',NULL),(7,'<h3>oefening 1</h3> <p>Probeer hetzelfde nu te bekomen nadat je het ledje verplaatst hebt met &eacute;&eacute;n of meerdere kabels indien nodig (denk eraan dat je kring gesloten moet zijn en dat je ledje in de juiste richting staat)<br /> Dit is wat je had.&nbsp;<br /> <img src=\"../img/arduinoSchemaLicht.png\" style=\"height:200px; width:400px\" /><br /> Je kan weten of je oefening juist is door te kijken of je lichtje effectief brandt / flikkert(bij het klikken op de startknop), als dit niet het geval is komt er nog een ander vorbeeld op als je op &quot;next&quot; drukt.</p>',NULL),(8,' <p>  Dit is een voorbeeld van een juiste oefening (als je lichtje brandt / flikkert is de oefenning juist).<br />  <img src=\"../img/arduinoSchemaLicht2.png\" style=\"height:150px; width:200px\" /><br />   Het rode draadje moet wel nog steeds in digital 10-13 zitten.  </p>',NULL);
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

-- Dump completed on 2020-04-18 15:56:18
