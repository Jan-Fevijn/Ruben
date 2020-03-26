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
              color:red;
              padding: 15%;
              font-size:300%;
              text-align:center;
          }
          </style>
</head>
<body>
<?php
include("checkIfLogedIn.php");
include("dbConnection.php");
$accType = "leerkracht";
include("banner.php");
                   
				
			?>
    <h3> Je hebt de 3 gratise instructies gevolgd. <br> De volgende zijn betaalend. </h3>

</body>
</html>