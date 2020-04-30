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
          $_SESSION['broodprijs'] =  $broodprijs;
         echo($broodprijs);
         }
     }

}
}
?> 