<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" type="text/css" href="../css/css.css">
</head>
<body>
<?php 
   include("dbConn.php");
   
   include("selectBrood.php");

   include("automaat.php");
   
   include("machineKnoppen.php");
   if (isset($_GET['thnx'])) {
       echo($_GET['thnx']);
       unset($_GET['thnx']);
   } 

   include("muntjes.php");
   include("payContant.php");
   ?>

</body>
</html>