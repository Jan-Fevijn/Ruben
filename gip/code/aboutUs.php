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
    <h2> over ons</h2>
    <div id="aboutUsContainer">
    <img  src="../img/head.jpg" height='250' border='10' id='imgHooft' align="right" />
        Hallo, mijn naam is Ruben Aspeslag .Ik ben 18 jaar. Ik heb deze site gemaakt voor mijn GIP.
        <br />Ik volg de opleiding IT N aan het KA Jan Fevijn te Assebroek Brugge.<br/> Het onderwerp voor mijn GIP is het maken van een website. Die website biedt instructies en uitleg over Arduino. <br/> Wie de instructies aankoopt kan zelfstandig en op eigen tempo zijn kennis van Arduino bijwerken.<br/>Veel leerplezier.

       
    </div>
<?php
include("footer.php");
?>
    
    <script type="text/javascript" src="js/js.js"></script>
</body>
</html>
