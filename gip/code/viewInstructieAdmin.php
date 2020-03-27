<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet"
          type="text/css"
          href="../css/css.css" />
          <style>
          
          h2 {
              font-size:200%;
           
          }
          h3 {
              font-size:180%;
           
          }
          #container {
            text-align:center;
          }
       
          </style>
</head>
<body>
<div id='container'>

<?php 
include("dbConnection.php");
include("checkIfLogedIn.php");
   $accType= "ADMIN";
   include("banner.php");
   echo("<p> hier kunt u al de instructies zien die uw leerlingen uit aan het leeren zijn. </p>");

        $sql = "SELECT * from oefeningen";
   

 
   $result = $conn->query($sql);
  while ( $row = $result->fetch_assoc()) {
    echo( "<h2> instructie: " . $row['idoefeningen'] . "</h2>");
    echo( $row['bodyDeel1']);
  }
  
    ?>
    </div>
</body>
</html>