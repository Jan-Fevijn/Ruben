<?php 

if (isset($_POST['order'])) {
    if ($geldinworp > $broodprijs) {
        $terig = $geldinworp - $broodprijs ;
        $payed = true ;
        $terigString = "";
       include("terig.php");  // geld terig geven .
       
        $_SESSION['geldinworp'] = 0;
      //  header("location: contant.php?thnx=bedankt om te betaalen. ");
    } else if ($geldinworp == $broodprijs) {
         // gepast betaald
         $payed = true ; 
         $terigString = "";
        $_SESSION['geldinworp'] = 0;
       // header("location: contant.php?thnx=bedankt om gepast te betaalen. ");
    } else {
        $payed = false ;
        echo("gelieve meer geld in het automaat te steken, het gekozen brood kost € " . $broodprijs);
    }
if ($payed) {


    $sql = "INSERT INTO `bakerijpol`.`order` (`usercode`, `idSoortbrood`, `idlocatie`) VALUES ('00000000', '$IDsoordBrood', '$machinenummer');";
    if ($conn->query($sql) === TRUE) {
       // echo "New record created successfully";
    } else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
        // UPDATE `bakerijpol`.`broodlocatie` SET `hoeveelheid` = '$hoeveelheidBrood' WHERE (`idBroodLocatier` = '3');
        echo("<br>" . $hoeveelheid . "<br>"); 
        $hoeveelheid =$hoeveelheid -1;
    $sql = "UPDATE `bakerijpol`.`broodlocatie` SET `hoeveelheid` = '$hoeveelheid' WHERE (`idBroodLocatier` = '$idBroodLocatier');";
    echo($sql);
    if ($conn->query($sql) === TRUE) {
        // echo "New record created successfully";
     } else {
         echo "Error: " . $sql . "<br>" . $conn->error;
     }


     header("location: contant.php?thnx=bedankt voor u aankoop . ".$terigString);

    }
}
?>