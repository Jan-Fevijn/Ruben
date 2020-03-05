<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../../css/css.css" />       
</head>
<body>

<?php

include("checkIfLogedIn.php");
include("dbConnection.php");
$accType = "ADMIN";
include("banner.php");
  // object 
  include("objects/adminFunctionObjects.php");
   echo ("  <div class='flexListOfAdminFunctions'>");
 
        // add instructie 
      $functie->set("add instructie / oefening", "instructie.png", "addinstructie", 200 , 200);
      $functie->write();

        // change instructie
        $functie->set("change instructie / oefening", "instructie.png", "changeInstructie", 200 , 200);
        $functie->write();
        // leerlingen 
        $functie->set("leerlingen", "logoStudent.jfif", "leerlingenbeheer", 300 , 200);
        $functie->write();

        // leerkrachten
        $functie->set("leerkrachten", "lkrCartoon.jfif", "leerkrachtenbeheer", 150 , 200);
        $functie->write();
         // admin forum
         $functie->set("admin forum", "forum.jfif", "adminForum", 300 , 200);
         $functie->write();
          // admin forum
          $functie->set("reports", "gmail.png", "reports", 300 , 200);
          $functie->write();
          // query uitvoeren (db)
          $functie->set("query uitvoeren (db) ", "sqlLogo.png", "sql", 300 , 200);
          $functie->write();
          echo("</div>");
          
   ?>
   <br><br><br><br><br><br><br><br><br><br><br><br>
  <?php
include("footer.php");
?>
   
</body>
</html>