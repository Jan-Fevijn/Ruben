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

include("checkIfLogedIn.php");
include("dbConnection.php");
$accType = "ADMIN";
include("banner.php");
echo("<div id='midden'> <a  href= 'admin.php'>back</a></div> ");
$sql = "SELECT * FROM reports order BY idreports    DESC";
if($result = mysqli_query($conn, $sql)){
 if(mysqli_num_rows($result) > 0){
     echo "<table>";
       
     while($row = mysqli_fetch_array($result)){
         echo "<tr>";
             echo "<tr> <th>" .  $row['voornaam'] ." ".$row['naam']. " ; ".$row['email']. " : </th> </tr>";
             echo "<tr> <td>" . $row['message'] . " </td> </tr>";
            
         echo "</tr>";
     }
     echo "</table>";


 } else ("error");
}else ("error");

$conn->close();
?>

<?php
include("footer.php");
?>
   

</body>
</html>