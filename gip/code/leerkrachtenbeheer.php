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
$accType = "ADMIN";
include("dbConnection.php");
include("checkIfLogedIn.php");
include("banner.php");

$sql = "SELECT * from leerkrachten";
$result = $conn->query($sql);
                    if($debug) echo("yeep");
if ($result->num_rows > 0) {
                   if($debug)  echo("yeeep");
    // output data of each row
    echo("<table border='1'>");
    echo("<tr> <th>idleerkracht </th>  <th>voornaam</th> <th>naam</th> <th> email</th> <th> klassen </th> </tr>");
    while($row = $result->fetch_assoc()) {
                     if($debug) echo("k");
        echo( " <tr> <td> " . $row["idleerkrachten"]. " </td><td> " . $row["naam"]. " </td><td> "  . $row["famielienaam"]." </td><td> " . $row["email"] ." </td><td> ");
        //dddddd
        $sql = "SELECT * from klas WHERE idleerkracht = '$row[idleerkrachten]' ";
      
        $resultt = $conn->query($sql);
        
        if ($resultt->num_rows > 0) {
            // output data of each row
           while($roww = $resultt->fetch_assoc()) {
                echo  "   <a href ='klasbeheer.php?klasid=". $roww['idklas'] ."'>" . $roww['klasnaam']  . " </a>";
            } // end while 
            echo ("  </td> " );
           
        } else {
            echo "0 klassen";
        }
        //ddddd
      
    
    } // end while (leerkrachten )
  
} else {
    
    echo "0 results";
}

echo("</table>");
?>

<?php
include("footer.php");
?>
   


</body>
</html>