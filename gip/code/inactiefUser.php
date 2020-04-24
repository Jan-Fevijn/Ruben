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
    input {
	box-shadow:inset 0px 0px 0px 0px #f5978e;
	background:linear-gradient(to bottom, #f24537 5%, #c62d1f 100%);
	background-color:#f24537;
	border-radius:6px;
	border:1px solid #d02718;
	display:inline-block;
	cursor:pointer;
	color:#ffffff;
	font-family:Arial;
	font-size:80%;
	font-weight:bold;
	padding:4px 29px;
	text-decoration:none;
	text-shadow:0px 1px 0px #810e05;
}
input:hover {
	background:linear-gradient(to bottom, #c62d1f 5%, #f24537 100%);
	background-color:#c62d1f;
}
input:active {
	position:relative;
	top:1px;
}
        h2 {
            padding: 10%;
            text-align:center;
            color: red;
            display: block;
            font-size:500%;
        }
    </style>
</head>
<body>
<?php

 include("dbConnection.php");
 $debug = false ;
        if (isset($_SESSION['accType'])) {
            $accType = $_SESSION['accType'];
        }
    
        include("checkIfLogedIn.php");
        include("banner.php");
   ?>
<form method='POST'>
    <h2> uw account is inactief <input type='submit' name='act' value ='activeer'> </h2>
    </form>
<?php 
    if (isset($_POST['act'])) {
        echo("ssssssssssssssssssssssssssssssss");
    echo($_SESSION['accType']);
switch ($_SESSION['accType']) {
    case "leerling":
      // echo($id);
      $sql = "UPDATE `dbarduinoeducatief`.`leerlingen` SET `actief` = '1' WHERE (`idleerlingen` = '$id')";
      $conn->query($sql);
      header('Location: oefeningen.php');
        break;
    case "leerkracht":
        $sql = "UPDATE `dbarduinoeducatief`.`leerkrachten` SET `actief` = '1' WHERE (`idleerkrachten` = '$id')";
        $conn->query($sql);
        header('Location: leerkrachten.php');
        break;
    }
}
?>
</body>
</html>