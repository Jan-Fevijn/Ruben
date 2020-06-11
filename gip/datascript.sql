-- Host: 127.0.0.1    Database: dbarduinoeducatief

-- 										datascript 

CREATE TABLE `admin` (
  `idadmin` int(11) NOT NULL AUTO_INCREMENT,
  `naam` varchar(10) NOT NULL,
  `famielienaam` varchar(20) NOT NULL,
  `wachtwoord` varchar(50) NOT NULL,
  `gebruikersnaam` varchar(20) NOT NULL,
  `email` varchar(45) NOT NULL,
  PRIMARY KEY (`idadmin`)
);

INSERT INTO `admin` (`idadmin`, `naam`, `famielienaam`, `wachtwoord`, `gebruikersnaam`, `email`) VALUES (1,'Ruben','Aspeslag','72104a570ffdc2434f0a250ee8205455 ','ADMIN','ADMIN.Ruben@gmail.com');
