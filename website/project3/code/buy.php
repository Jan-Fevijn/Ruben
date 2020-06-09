<?php 
    if (isset($_POST['order'])){
      if (isset($_SESSION['userCode'])) {
    $sql = "INSERT INTO `bakerijpol`.`order` (`idorder`, `usercode`, `idSoortbrood`, `idlocatie`) VALUES ('', '$userCode', '$IDsoordBrood', '$machinenummer')";
    if ($conn->query($sql) === TRUE) {
      
       $hoeveelheid = $row['hoeveelheid'] - 1;
       $idBroodLocatier = $row['idBroodLocatier'];
       $sql = "UPDATE `bakerijpol`.`broodlocatie` SET `hoeveelheid` = '$hoeveelheid' WHERE (`idBroodLocatier` = '$idBroodLocatier')";
       if ($conn->query($sql) === TRUE) {

                           $saldo = $saldo - $_SESSION['broodprijs'];
                          
                            
                            $sql = "UPDATE `bakerijpol`.`user` SET `saldo` = '$saldo' WHERE (`idUser` = '$idUser')";
                           if ($conn->query($sql) === TRUE) {
                            echo "uw aankoop is voltooid<br>";
                        }

                    }
                }

      } else {
        header("location: ../index.php ");
      }
      $sqlUser = "SELECT * FROM bakerijpol.user where code = '$userCode'";
      $resultUser = $conn->query($sqlUser);
      if ($resultUser->num_rows > 0) {
          // output data of each row
          while($row = $resultUser->fetch_assoc()) {
              $idUser = $row['idUser'];
              $code = $row['code'];
              $saldo = $row['saldo'];
              echo("<h3> code : $code  saldo = $saldo </h3>");
          }
      } else {
          echo "0 results";
      }

    }
?>