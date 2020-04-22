<?php 
    if (isset($_POST['order'])){
      if (isset($_SESSION['userCode'])) {
    $sql = "INSERT INTO `bakerijpol`.`order` (`idorder`, `usercode`, `idSoortbrood`, `idlocatie`) VALUES ('', '$userCode', '$IDsoordBrood', '$machinenummer')";
    if ($conn->query($sql) === TRUE) {
      
       $hoeveelheid = $row['hoeveelheid'] - 1;
       $idBroodLocatier = $row['idBroodLocatier'];
       $sql = "UPDATE `bakerijpol`.`broodlocatie` SET `hoeveelheid` = '$hoeveelheid' WHERE (`idBroodLocatier` = '$idBroodLocatier')";
       if ($conn->query($sql) === TRUE) {
                           $saldo = $saldo - $broodprijs;
                          
                            
                            $sql = "UPDATE `bakerijpol`.`user` SET `saldo` = '$saldo' WHERE (`idUser` = '$idUser')";
                           if ($conn->query($sql) === TRUE) {
                            echo "uw aankoop is voltooid<br>";
                        } else {
                         
                        }

                    }
                }

      } else {
        header("location: ../index.php ");
      }
    }
?>