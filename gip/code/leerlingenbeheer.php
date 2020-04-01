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
    $accType="ADMIN";
    include("checkIfLogedIn.php");
    include("dbConnection.php");
    include("banner.php");
    

        // actief / inactief maaken 
        $sqlMax = "select max(idleerlingen) as a from leerlingen";
        $resultMax = $conn->query($sqlMax);
        $rowMax = $resultMax->fetch_assoc();

        for($i=1; $i<= $rowMax['a']; $i++){
           if (isset($_POST['active'.$i])){
              // echo($i);
                $sql = "select * from leerlingen where idleerlingen = '$i'";
               $result = $conn->query($sql);
               $row = $result->fetch_assoc();
               $act = false;
                if ($row['actief'] == 0) {
                    $act = true; 
                } else {
                    $act = false;
                }
                $sql = "UPDATE `dbarduinoeducatief`.`leerlingen` SET `actief` = '$act' WHERE (`idleerlingen` = '$i') " ;
                if ($conn->query($sql)) {
                   // echo "New record created successfully";
                } else {
                   // echo "Error: " . $sql . "<br>" . $conn->error;
                }

           }
        }

        $idleerlingen = "";
        $actief = "";
        $voornaamLeerling = "";
        $naamLeerling = "";
        $emailLleerling = "";
        $voornaamLeerkracht = "";
        $naamLeerkracht = "";
        $emailLeerkracht = "";
        $klasnaam = "";
        $klasID = "";
        $oefeningID = "";

        if (isset($_POST['idleerlingen'])) {
            $idleerlingen = $_POST['idleerlingen'];
            $actief = $_POST['actief'];
            $voornaamLeerling =$_POST['voornaamLeerling'];
            $naamLeerling = $_POST['naamLeerling'];
         $emailLleerling = $_POST['emailLleerling'];
         $voornaamLeerkracht = $_POST['voornaamLeerkracht'];
          $naamLeerkracht = $_POST['naamLeerkracht'];
         $emailLeerkracht = $_POST['emailLeerkracht'];
         $klasnaam = $_POST['klasnaam'];
         $klasID = $_POST['klasID'];
          $oefeningID = $_POST['oefeningID'];
        }

?>
idleerlingen:
<input type='text' value='<?php echo($idleerlingen); ?>' name='idleerlingen'>
actief :
<input type='text'  value='<?php echo($actief); ?>' name='actief'>
voornaam leerling:
<input type='text' value='<?php echo($voornaamLeerling); ?>' name='voornaamLeerling'> <br>
naam leerling:
<input type='text' value='<?php echo($naamLeerling); ?>' name='naamLeerling'>
email leerling:
<input type='text' value='<?php echo($emailLleerling); ?>' name='emailLleerling'>
voornaam leerkracht:
<input type='text' value='<?php echo($voornaamLeerkracht); ?>' name='voornaamLeerkracht'><br>
naam leerkracht:
<input type='text' value='<?php echo($naamLeerkracht); ?>' name='naamLeerkracht'>
email leerkracht:
<input type='text' value='<?php echo($emailLeerkracht); ?>' name='emailLeerkracht'>
klasnaam:
<input type='text' value='<?php echo($klasnaam); ?>' name='klasnaam'><br>
klas ID:
<input type='text' value='<?php echo($klasID); ?>' name='klasID'>
oefening ID:
<input type='text' value='<?php echo($oefeningID); ?>' name='oefeningID'><br>
<input type='submit' value ='zoeken'>
<?php

   $sql ="
   
   SELECT 
   lln.idleerlingen,  lln.naam  as leerlingNaam , lln.famielienaam as leerlingFamilienaam,lln.oefeningid, lln.email as emailLeerling,
    lln.actief , sub1.naam as naamLeerkracht,sub1.email as emailLeerkracht, sub1.klasnaam  as klasnaam, sub1.idklas as idklas,
    sub1.famielienaam as famielninaamLeerkracht
    
    from  (select lkr.idleerkrachten, lkr.naam,
    lkr.famielienaam, k.idklas, k.klasnaam, lkr.email from dbarduinoeducatief.leerkrachten as lkr
    inner join dbarduinoeducatief.klas as k on lkr.idleerkrachten = k.idleerkracht) as sub1 inner join 
    dbarduinoeducatief.leerlingen as lln on lln.idklas = sub1.idklas 
    
    where idleerlingen like '%$idleerlingen%' AND lln.naam like '%$voornaamLeerling%' AND lln.famielienaam like '%$naamLeerling%' AND oefeningid like '%$oefeningID%' AND lln.email like '%$emailLleerling%' 
    AND  actief like '%$actief%' AND  sub1.naam like '%$voornaamLeerkracht%' AND sub1.email like '%$emailLeerkracht%' AND sub1.klasnaam like '%$klasnaam%' AND  sub1.idklas like '%$klasID%' AND
     sub1.famielienaam like '%$naamLeerkracht%'
   

   ";

   // echo($sql);
   $result = $conn->query($sql);
    
    if ($result->num_rows > 0) {
        // output data of each row
        echo("<table border='5'  style='  background-color: white;'>");
        echo("<tr> <th>idleerlingen</th> <td> actief </td> <th>voornaam leerling</th> <th>naam leerling</th> <th>email leerling</th> <th>voornaam leerkracht</th>  <th>naam leerkracht</th> <th>email leerkracht</th> <th>klasnaam</th> <th>klas ID</th> <th>oefening ID</th> </tr>");
        while($row = $result->fetch_assoc()) {
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
          $idleerlingen =  $row["idleerlingen"];

            echo " <tr> <td>  $idleerlingen </td><td> <input type='submit' name='active$idleerlingen' value='$actief'> </td> <td> " . $row["leerlingNaam"]. " </td><td> "  . $row["leerlingFamilienaam"]." </td><td> " . $row["emailLeerling"]." </td><td> " . $row["naamLeerkracht"] ." </td><td> " . $row["famielninaamLeerkracht"]. " </td><td> " . $row["emailLeerkracht"]." </td><td> " . $row["klasnaam"]. " </td><td> " . $row["idklas"]. " </td> <td> " . $row["oefeningid"]. " </td> </tr> " ;
        }
        echo("</table>");
    } else {
        echo "0 results";
    }

            
    ?>
    <?php
include("footer.php");
?>
   </form>
    

</body>
</html>