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
include('checkIfLogedIn.php');
include("dbConnection.php");
$accType ="leerling";
include("banner.php");

if (isset($_POST['oefid'])) {
   
    
    $oefid = $_POST['oefid'];
    echo("<br>");
    if ($_POST['move'] == "next") {
        $oefid = $oefid +1; 
       if($debug) echo("++");
    } else if  ($_POST['move'] == "B") {
        $oefid = $oefid -1; 
      if ($debug)  echo("-");
    } else echo ("error");
   
  if ($debug)  echo($oefid);
    $sql = "UPDATE leerlingen SET oefeningid='$oefid' WHERE idleerlingen='$id'";
    $resultaat = $conn->query($sql);
   echo(mysqli_error($conn));
} else {
  
}

$sql = "SELECT * FROM leerlingen WHERE idleerlingen ='$id'" ;
$result = $conn->query($sql);
$oef = $result->fetch_assoc();
$naam = $oef['naam'];
$Fnaam = $oef['famielienaam'];
$oefid = $oef['oefeningid'];
?>
   

    <div id="instructie2">

        <table border="1">
            <tr>
                <td>

                    <img src="../../img/instructie.png" height="50" width="50" />
                </td>
                <td id="instructie2">

               <?php
			  

$sql = "SELECT * FROM oefeningen WHERE idoefeningen='$oefid'";
$result = $conn->query($sql);
$oef = $result->fetch_assoc();
//if ($result->num_rows > 0) {
    // output data of each row
    $ex = 1;
        echo ( $oef["bodyDeel1"] );
		
   
//} else {
 //   echo "0 results";
//}
echo ("<div class ='listOfLeerlingen'> "); 
if ($oefid == 1 ) {

}else {
echo ("    <form method='POST' action='oefeningen.php'> ");
echo(" <input type='text' style='display: none' name='id' value='$id'  >");
echo(" <input type='text' style='display: none' name='oefid' value='$oefid'  >");
echo(" <input type='text' style='display: none' name='move' value='B'  >");
echo("  <input type='submit' value='back'> </form> ");
}
    echo ("    <form method='POST' action='oefeningen.php'> ");
    echo(" <input type='text' style='display: none' name='id' value='$id'  >");
    echo(" <input type='text' style='display: none' name='oefid' value='$oefid'  >");
    echo(" <input type='text' style='display: none' name='move' value='next'  >");
    echo("  <input  type='submit' value='next'> ");
 echo("</div>");

$conn->close();
?>
                   
                </td>
            </tr>
        </table>
    </div>
    <?php
include("footer.php");
?>
   
</body>
</html>