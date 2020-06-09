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
          
          h3 {
              font-size:200%;
           
          }
          #container {
            text-align:center;
          }
          h2 {
              color:red;
          }
          </style>
</head>
<body>
<div id='container'>

<?php 
include("dbConnection.php");
include("checkIfLogedIn.php");
   $accType= "leerkracht";
   include("banner.php");
   echo("<p> hier kunt u al de instructies zien die uw leerlingen uit aan het leeren zijn. </p>");

          $sql = "SELECT count(*) as count FROM dbarduinoeducatief.klas where formule <> 2 and idleerkracht = $id;";
          $result = $conn->query($sql);
          $row = $result->fetch_assoc();

       $count =$row['count'];

       if ($count == 0 ) {
        $sql = "SELECT * from oefeningen WHERE idoefeningen < 4";
       } else {
        $sql = "SELECT * from oefeningen";
       }

 
   $result = $conn->query($sql);
  while ( $row = $result->fetch_assoc()) {
    echo( "<h3> instructie: " . $row['idoefeningen'] . "</h3>");
    echo( $row['bodyDeel1']);
  }
  if ($count == 0 ) {
   echo("<h2> dit waren de eerste 3 instructies, indien u de andere ook wilt zien of wil hebben dat uw leerlingen die kunnen zien moet u een betaalde klas aanmaken. </h2>");
   }
    ?>
    </div>
</body>
</html>