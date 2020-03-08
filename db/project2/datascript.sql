-- data structure 

drop database if EXISTS kokenvoorgroepen;
create  database if not exists  kokenvoorgroepen;
use  kokenvoorgroepen; 
DROP TABLE IF EXISTS `event`;
CREATE TABLE `event` (
  `idevent` int(11) NOT NULL,
  `datumStart` date DEFAULT NULL,
  `datumEnd` date DEFAULT NULL,
  `img` varchar(700) DEFAULT NULL,
  `naam` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idevent`));
  
  
   DROP TABLE IF EXISTS `eventgerecht`;
  
  CREATE TABLE `eventgerecht` (
  `ideventGerecht` int(11) NOT NULL,
  `idEvent` varchar(45) DEFAULT NULL,
  `idGerecht` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ideventGerecht`));
  
  
  DROP TABLE IF EXISTS `gerecht`;
  CREATE TABLE `gerecht` (
  `idgerecht` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(45) DEFAULT NULL,
  `img` varchar(700) DEFAULT NULL,
  `vegan` tinyint(4) DEFAULT NULL,
  `veganistisch` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`idgerecht`));
  
  
  DROP TABLE IF EXISTS `inschrijving`;
  CREATE TABLE `inschrijving` (
  `idinschrijving` int(11) NOT NULL AUTO_INCREMENT,
  `iduser` int(11) DEFAULT NULL,
  `idevent` int(11) DEFAULT NULL,
  PRIMARY KEY (`idinschrijving`));
  
  
 
  DROP TABLE IF EXISTS `product`;
  CREATE TABLE `product` (
  `idproduct` int(11) NOT NULL,
  `naam` varchar(45) DEFAULT NULL,
  `hoeveelheid` varchar(45) DEFAULT NULL,
  `eenheid` varchar(3) DEFAULT NULL,
  `idwinkel` int(11) DEFAULT NULL,
  PRIMARY KEY (`idproduct`));
  
  
  DROP TABLE IF EXISTS `produtgerecht`;
  CREATE TABLE `produtgerecht` (
  `idprodutGerecht` int(11) NOT NULL AUTO_INCREMENT,
  `gerechtid` int(11) DEFAULT NULL,
  `productid` int(11) DEFAULT NULL,
  `hoeveelheid` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idprodutGerecht`));
  
 
  DROP TABLE IF EXISTS `user`;
  
  CREATE TABLE `user` (
  `iduser` int(11) NOT NULL AUTO_INCREMENT,
  `voornaam` varchar(45) DEFAULT NULL,
  `naam` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `vegan` tinyint(4) DEFAULT NULL,
  `veganistisch` tinyint(4) DEFAULT NULL,
  `admin` tinyint(4) DEFAULT NULL,
  `username` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`iduser`));
  
    DROP TABLE IF EXISTS `winkel`;
  
  CREATE TABLE `winkel` (
  `idwinkel` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idwinkel`));
  
  -- data records 
  
INSERT INTO `user` (`iduser`, `voornaam`, `naam`, `password`, `vegan`, `veganistisch`, `admin`, `username`) VALUES (1,'Ruben','Aspeslag','Ruben2001',0,0,0,'ruben'),(2,'Ruben','Ruben','azerty123',0,0,0,'admin33'),(3,'Ruben','Ruben','azerty123',1,0,0,'ruben2001'),(4,'Ruben','Aspeslag','azerty123',0,1,0,'999');
INSERT INTO `produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES (1,1,1,'62.5'),(2,1,2,'1.25'),(3,1,3,'0.75'),(4,1,4,'0.25');
INSERT INTO `product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES (1,'suiker','100','gra',1),(2,'bloem','100','gra',1),(3,'melk','1','lie',1),(4,'eieren','1','stu',1);
INSERT INTO `inschrijving` (`idinschrijving`, `iduser`, `idevent`) VALUES (1,1,1);
INSERT INTO `eventgerecht` (`ideventGerecht`, `idEvent`, `idGerecht`) VALUES (1,'1','1');
INSERT INTO `gerecht` (`idgerecht`, `naam`, `img`, `vegan`, `veganistisch`) VALUES (1,'pannenkoeken','https://vegetus.nl/wp-content/uploads/2013/02/Pannenkoeken-veganistisch-zonder-melk-zonder-ei.jpg',1,0);
INSERT INTO `event` (`idevent`, `datumStart`, `datumEnd`, `img`, `naam`) VALUES (1,'2020-03-04','2020-03-04','https://vegetus.nl/wp-content/uploads/2013/02/Pannenkoeken-veganistisch-zonder-melk-zonder-ei.jpg','bak pannenkoeken');

INSERT INTO `winkel` (`idwinkel`, `naam`) VALUES (1,'ALDI');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('5', 'soepvlees', '100', 'gra', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('6', 'basilicum gehakt', '100', 'il', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('7', 'gehakt', '700', 'gra', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('8', 'ui', '100', 'stu', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('9', 'ei', '100', 'stu', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('10', 'paneermeel', '100', 'el', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('11', 'tomaten', '100', 'stu', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('12', 'kruidentuiltje (laurier, tijm, peterselie)', '100', 'stu', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('13', 'wortel', '100', 'stu', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('14', 'selder', '100', 'stu', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('15', 'preiwit', '100', 'stu', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `idwinkel`) VALUES ('16', 'tomatenpuree', '100', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `idwinkel`) VALUES ('17', 'roomscheutje', '100', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `idwinkel`) VALUES ('18', 'boter', '100', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `idwinkel`) VALUES ('19', 'peper', '100', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('20', 'zout', '100', '', '1');
INSERT INTO `kokenvoorgroepen`.`event` (`idevent`, `datumStart`, `datumEnd`, `img`, `naam`) VALUES ('2', '2020-03-07', '2020-03-09', 'https://img.static-rmg.be/a/food/image/q75/w640/h400/12475/tomatensoep-met-balletjes.jpg', 'koken voor beginners');
INSERT INTO `kokenvoorgroepen`.`eventgerecht` (`ideventGerecht`, `idEvent`, `idGerecht`) VALUES ('2', '2', '2');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('5', '2', '5', '100');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('6', '2', '6', '0.5');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('7', '2', '7', '75');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('8', '2', '8', '0.5');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('9', '2', '9', '0.25');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('10', '2', '10', '0.5');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('11', '2', '11', '1.25');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('12', '2', '12', '0.25');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('13', '2', '13', '0.25');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('14', '2', '14', '0.25');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('15', '2', '15', '0.25');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('16', '2', '16', '0.5');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('17', '2', '17', '1');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('18', '2', '18', '1');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('19', '2', '19', '1');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('20', '2', '20', '1');
INSERT INTO `kokenvoorgroepen`.`gerecht` (`idgerecht`, `naam`, `img`, `vegan`, `veganistisch`) VALUES ('2', 'tomatensoep', 'https://img.static-rmg.be/a/food/image/q75/w640/h400/12475/tomatensoep-met-balletjes.jpg', '0', '0');
INSERT INTO `kokenvoorgroepen`.`gerecht` (`idgerecht`, `naam`, `img`, `vegan`, `veganistisch`) VALUES ('3', 'omelet', 'http://i1.wp.com/lotkookt.com/wp-content/uploads/2015/07/goedgevulde-omelet-met-feta-tomaat-en-rucola2.png?zoom=1.75&resize=683%2C478', '1', '0');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('21', '3', '9', '2');
INSERT INTO `kokenvoorgroepen`.`eventgerecht` (`ideventGerecht`, `idEvent`, `idGerecht`) VALUES ('3', '2', '3');
INSERT INTO `kokenvoorgroepen`.`gerecht` (`idgerecht`, `naam`, `img`, `vegan`, `veganistisch`) VALUES ('4', 'LEKKER EN SIMPEL: APPELTAARTJES', 'http://i1279.photobucket.com/albums/y537/lekkerensimpel/2014/jan/IMG_7520_zps42e58d30.jpg', '0', '0');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('22', '4', '21', '2');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('23', '4', '22', '4');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('24', '4', '23', '1');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('25', '4', '24', '1');
INSERT INTO `kokenvoorgroepen`.`eventgerecht` (`ideventGerecht`, `idEvent`, `idGerecht`) VALUES ('4', '2', '4');
INSERT INTO `kokenvoorgroepen`.`eventgerecht` (`ideventGerecht`, `idEvent`, `idGerecht`) VALUES ('5', '2', '1');
INSERT INTO `kokenvoorgroepen`.`gerecht` (`idgerecht`, `naam`, `img`, `vegan`, `veganistisch`) VALUES ('5', 'croque monsieur', 'https://static.nieuwsblad.be/Assets/Images_Upload/2016/11/01/croque.jpg?maxheight=460&maxwidth=638&scale=both', '0', '0');
INSERT INTO `kokenvoorgroepen`.`eventgerecht` (`ideventGerecht`, `idEvent`, `idGerecht`) VALUES ('6', '2', '5');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('25', 'brood', '100', 'stu', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('26', 'kaas', '100', 'gra', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('27', 'ham', '100', 'gra', '1');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('26', '5', '25', '6');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('27', '5', '26', '3');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('28', '5', '27', '3');
INSERT INTO `kokenvoorgroepen`.`eventgerecht` (`ideventGerecht`, `idEvent`, `idGerecht`) VALUES ('7', '2', '6');
INSERT INTO `kokenvoorgroepen`.`gerecht` (`idgerecht`, `naam`, `img`, `vegan`, `veganistisch`) VALUES ('6', 'Spaghetti bolognaise', 'https://www.42brasso.be/wp-content/uploads/spaghettibolognaise.jpg', '0', '0');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('28', 'gemengd gehakt', '100', 'kg', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('29', 'dikke sneetjes pancetta', '100', 'stu', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('30', 'dikke ui', '100', 'stu', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('31', 'look ', '100', 'tee', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('32', 'dikke wortel', '100', 'g', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('33', 'champignons', '100', 'g', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('34', 'tomatenpuree ', '100', 'g', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('35', 'tomatenstukjes ', '100', 'dl', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('36', 'passata van tomaten', '100', 'dl', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('37', 'water', '100', 'dl', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('38', 'rode wijn', '100', 'tak', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('39', 'rozemarijn', '100', 'sch', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('40', 'olijfolie', '100', 'ste', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('41', 'groene selder', '100', 'tak', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('42', 'tijm', '100', 'stu', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('43', 'verse oregano', '100', 'tak', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('44', 'laurierblaadje', '100', 'stu', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('45', 'Harissa', '100', 'toe', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('46', 'spaghetti', '100', 'g', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `idwinkel`) VALUES ('47', 'zout', '100', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `idwinkel`) VALUES ('48', 'peper van de molen', '100', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `idwinkel`) VALUES ('49', 'zout', '100', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `idwinkel`) VALUES ('50', 'gemalen Emmental kaas', '100', '1');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('29', '6', '28', '0.25');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('30', '6', '29', '1');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('31', '6', '30', '0.25');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('32', '6', '31', '0.25');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('33', '6', '32', '0.5');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('34', '6', '33', '62.5 ');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('35', '6', '34', '25 ');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('36', '6', '35', '200 ');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('37', '6', '36', '0.75');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('38', '6', '37', '0.5');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('39', '6', '38', '0.25');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('40', '6', '39', '0.5');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('41', '6', '40', '1');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('42', '6', '41', '1');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('43', '6', '42', '0.5');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('44', '6', '43', '0.5');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('45', '6', '44', '0.5');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('46', '6', '45', '1');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('47', '6', '46', '125');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`) VALUES ('48', '6', '47');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`) VALUES ('49', '6', '48');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`) VALUES ('50', '6', '49');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`) VALUES ('51', '6', '50');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `hoeveelheid`) VALUES ('', '', '');
INSERT INTO `kokenvoorgroepen`.`gerecht` (`idgerecht`, `naam`, `img`, `vegan`, `veganistisch`) VALUES ('7', 'boterham met choco', 'https://images3.persgroep.net/rcs/OOwUxAWaKRQFN518VpSm4fubAGM/diocontent/63408847/_fitwidth/763?appId=2dc96dd3f167e919913d808324cbfeb2&quality=0.8', '0', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('51', 'choco', '100', 'sne', '1');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `gerechtid`, `productid`, `hoeveelheid`) VALUES ('53', '7', '25', '6');
INSERT INTO `kokenvoorgroepen`.`produtgerecht` (`idprodutGerecht`, `productid`, `hoeveelheid`) VALUES ('54', '51', '3');
INSERT INTO `kokenvoorgroepen`.`eventgerecht` (`ideventGerecht`, `idEvent`, `idGerecht`) VALUES ('8', '2', '7');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('21', 'suiker', '100', 'el', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('22', 'bladerdeeg ', '100', 'pla', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('23', 'kaneel', '100', 'the', '1');
INSERT INTO `kokenvoorgroepen`.`product` (`idproduct`, `naam`, `hoeveelheid`, `eenheid`, `idwinkel`) VALUES ('24', 'appel', '100', 'stu', '1');
UPDATE `kokenvoorgroepen`.`produtgerecht` SET `gerechtid` = '7' WHERE (`idprodutGerecht` = '54');

