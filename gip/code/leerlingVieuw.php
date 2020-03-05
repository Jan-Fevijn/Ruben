
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
$accType = "leerkracht";
include("banner.php");
?>
<table class='tableCenter' border='1'>
<tr>
    <th> voornaam </th> <th> familienaam </th> <th> oefeningnummer </th> 
</tr>
<?php 
if (isset($_GET['id'])) {
    $klasID = $_GET['id'];

    $sql = "SELECT * FROM klas WHERE idklas='$klasID'";
    $result = $conn->query($sql);
    $row = $result->fetch_assoc();
 echo("<div id ='midden' > klasnaam :  ". $row['klasnaam'] . "</div>");
   
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
