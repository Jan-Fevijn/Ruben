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
 $accType = "ADMIN";
 include("dbConnection.php");
 include("checkIfLogedIn.php");
 include("banner.php");

if (isset($_GET['klasid'])) {
 $_SESSION['klasid'] = $_GET['klasid'];
 if ($debug) echo($_SESSION['klasid']);
} else {
    if ($debug) echo("error");
}
if (isset($_SESSION['klasid'])) {
   $klasid = $_SESSION['klasid'];
   if ($debug) echo("<br> " . $klasid);
    $sql = " SELECT * FROM klas where idklas ='$klasid'";
    $result = mysqli_query($conn,$sql);
       while($row = mysqli_fetch_array($result)){
           $idLeerkracht = $row['idleerkracht'];
        $sql2 = " SELECT * FROM leerkrachten where idleerkrachten ='$idLeerkracht'";
        $result2 = mysqli_query($conn,$sql2);
        $row2 = mysqli_fetch_array($result2);
      
        echo( "<div id='midden'>  <table border='1' style='margin-left:32% ;'> <tr> <td> idklas: </td> <td> " .$row['idklas']  ."</td> <td> klasnaam: </td> <td> ".  $row['klasnaam'] . "</td> </tr><tr><td>  id leerkracht: </td> <td> " . $row2['idleerkrachten'] . "</td> <td> naam leerkracht: </td> <td> ". $row2['naam'] ." " . $row2['famielienaam'] ." </h2> </tr> </table> </div> <br/>"  );
 }
}


 echo ( "<div class= 'listOfLeerlingen' >");
 
 $sqlLeerlingen = "SELECT * from leerlingen where idklas= '$klasid' ";
 $resultLeerlingen = mysqli_query($conn,$sqlLeerlingen);
 while($leerlingen = mysqli_fetch_array($resultLeerlingen)){
    echo("<div class= 'leerlingen' id = 'midden2' >");
        echo($leerlingen['naam'] ." " . $leerlingen ['famielienaam'] . "<br> oefeningid=". $leerlingen ['oefeningid'] . "<br> leerlingid=". $leerlingen ['idleerlingen'] ."<br/> <img src='../img/student.png'>" );


    echo("</div>");
 }
 
 echo ("</div>");

?>
<?php
include("footer.php");
?>
   
</body>
</html>