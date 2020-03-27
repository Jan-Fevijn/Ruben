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
<form method='POST'>
<?php 
$accType = "ADMIN";
include("dbConnection.php");
include("checkIfLogedIn.php");
include("banner.php");




        // actief / inactief maaken 
        $sqlMax = "select max(idleerkrachten) as a from leerkrachten";
        $resultMax = $conn->query($sqlMax);
        $rowMax = $resultMax->fetch_assoc();

        for($i=1; $i<= $rowMax['a']; $i++){
           if (isset($_POST['active'.$i])){
              // echo($i);
                $sql = "select * from leerkrachten where idleerkrachten = '$i'";
               $result = $conn->query($sql);
               $row = $result->fetch_assoc();
               $act = false;
                if ($row['actief'] == 0) {
                    $act = true; 
                } else {
                    $act = false;
                }
                $sql = "UPDATE `dbarduinoeducatief`.`leerkrachten` SET `actief` = '$act' WHERE (`idleerkrachten` = '$i') " ;
                if ($conn->query($sql)) {
                    echo "New record created successfully";
                } else {
                    echo "Error: " . $sql . "<br>" . $conn->error;
                }

           }
        }





$sql = "SELECT * from leerkrachten";
$result = $conn->query($sql);
                    if($debug) echo("yeep");
if ($result->num_rows > 0) {
                   if($debug)  echo("yeeep");
    // output data of each row
    echo("<table border='1'>");
    echo("<tr> <th>idleerkracht </th> <th> actief </th> <th>voornaam</th> <th>naam</th> <th> email</th> <th> klassen </th> </tr>");
    while($row = $result->fetch_assoc()) {
                     if($debug) echo("k");
                     $actief = "";
                     $act = false;
                      if ($row['actief'] == 1) {
                          $actief = "actief";
                          $act = true;
                      } else if ($row['actief'] == "") {
                          $actief = "actief";
                          $act = true;
                      } else if ($row['actief'] == 0) {
                          $actief = "inactief";
                          $act = false;
                      }
                   $idleerkrachten =   $row["idleerkrachten"];

        echo( " <tr> <td>$idleerkrachten  </td> <td> <input type='submit' name='active$idleerkrachten' value='$actief'> </td> <td> " . $row["naam"]. " </td><td> "  . $row["famielienaam"]." </td><td> " . $row["email"] ." </td><td> ");
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
   </form>


</body>
</html>