<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../css/css.css" />
</head>
<body>

<?php 
 $s = true ; 
 session_start();
 include("dbConnection.php");
 $debug = false ;
    if (isset($_SESSION['accType'])) {
        $accType = $_SESSION['accType'];
        include("checkIfLogedIn.php");
        include("banner.php");
    } else {
        include("banner.php");
    }


?>
    <h2> our service</h2>
    <p id="midden">
        Arduino educatief is een leerplatform om te leren werken met arduino. Het doelpubliek zijn leerlingen van de 1 <sup> ste </sup> graad secundair.<br />
        Wij leveren 30 oefeningen waarbij je stap voor stap leert werken met arduino. De oefeningen evolueren van makkelijk naar gevorderd. <br />
         <br />
        Bij vragen of eventuele problemen kan je ons steeds contacteren.
    </p>
	
    <?php
include("footer.php");
?>
   
</body>
</html>
