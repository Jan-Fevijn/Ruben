
<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../css/css.css" />
          <style>
          a {
              display: block;
          }
          </style>
</head>
<body>
<?php

include("checkIfLogedIn.php");
include("dbConnection.php");
$accType = "leerkracht";
include("banner.php");

if (isset($_GET['delClass'])){
    if (isset($_GET['id'])) {
        $klasID = $_GET['id'];
$sql = "DELETE FROM `leerlingen` WHERE (`idleerlingen` > '0' and idklas = '$klasID')";
$sql2 = "DELETE FROM `klas` WHERE (`idklas` = '$klasID');";
if ($conn->query($sql) === TRUE) {
    echo "New record created successfully";
  } else {
    echo "Error: " . $sql . "<br>" . $conn->error;
  }


  if ($conn->query($sql2) === TRUE) {
    echo "New record created successfully";
  } else {
    echo "Error: " . $sql2 . "<br>" . $conn->error;
  }

  header('Location: leerkrachten.php');
    }
}


if (isset($_GET['id'])) {
    $klasID = $_GET['id'];
    
    $sql = "SELECT * FROM klas WHERE idklas='$klasID'";
    $result = $conn->query($sql);
    $row = $result->fetch_assoc();
    echo("<div id ='midden' > klasnaam :  ". $row['klasnaam'] );
}
?>

<a href='leerlingVieuw.php?delClass=1&id=<?php echo($klasID) ?>' > <img src="../img/trachCan.jpg" height='50' border='10' id='imgHooft' /> </a>
</div>


<table class='tableCenter' border='1'>
<tr>
    <th> voornaam </th> <th> familienaam </th> <th> oefeningnummer </th> 
</tr>
<?php 
if (isset($klasID)) {
   
$sql = "SELECT * FROM leerlingen WHERE idklas='$klasID'";
$result = $conn->query($sql);
while($row = $result->fetch_assoc()) {
 echo("<tr> <td> ". $row['naam']." </td> <td> ". $row['famielienaam']."  </td> <td> ". $row['oefeningid']." </td>  </tr> ");
}
echo("</table>");
}
?>
</table>
<?php
include("footer.php");
?>
   
</body>
</html>
