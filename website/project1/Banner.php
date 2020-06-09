<?php 
 $result = mysqli_query($conn,"SELECT * FROM user WHERE iduser = '$iduser'");    
$row = $result->fetch_assoc();

echo("<div id='banner'> <h1>INKOMSTEN EN UITGAVEN</h1><br /> ");
if (isset($_SESSION['iduser'])) {
echo ("<a id='naamInBanner' href='#' >". $row['username'] ."</a>" ); 

echo("<a id='logoutInBanner' href='index.php'> uitloggen </a> ");
}
  

?>