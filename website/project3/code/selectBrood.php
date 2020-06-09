<?php 
 if (isset($_POST['order'])) {
$machinenummer =  $_SESSION['machineNumber'];
if (isset($_POST['order'])){ 
$sql = "SELECT * FROM bakerijpol.broodlocatie where locatie = $machinenummer";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    $row = $result->fetch_assoc();
    $IDsoordBrood = $row['IDsoordBrood'];
}

$sqlBrood = "SELECT * FROM bakerijpol.soortbrood where idsoortBrood = $IDsoordBrood  ";
//     echo($sqlBrood );
     if($resultBrood = mysqli_query($conn, $sqlBrood)){
         if(mysqli_num_rows($resultBrood) > 0){
             $rowBrood = mysqli_fetch_array($resultBrood);
          $broodprijs =   $rowBrood['prijs'];
          $hoeveelheidBrood = $rowBrood['hoeveelheid'];
          $_SESSION['broodprijs'] =  $broodprijs;
         echo($broodprijs);
         }
     }


     $sql = "SELECT * FROM bakerijpol.broodlocatie where IDsoordBrood = $IDsoordBrood;";
     $result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
        $hoeveelheid = $row['hoeveelheid'];
        $idBroodLocatier = $row['idBroodLocatier'];
        }
    }
}
}
?> 