<?php 
    if (isset($_POST['order'])){
      if (isset($_SESSION['userCode'])) {
           // echo($_SESSION['userCode']);
           $userCode = $_SESSION['userCode'];
           $machinenummer =  $_SESSION['machineNumber'];
        $sql = "SELECT * FROM bakerijpol.broodlocatie where locatie = $machinenummer";
        $result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    $row = $result->fetch_assoc();
    $IDsoordBrood = $row['IDsoordBrood'];
    $sql = "INSERT INTO `bakerijpol`.`order` (`idorder`, `usercode`, `idSoortbrood`, `idlocatie`) VALUES ('', '$userCode', '$IDsoordBrood', '$machinenummer')";
    if ($conn->query($sql) === TRUE) {
        echo "New record created successfully";
    } else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }



} else {
    echo "0 results";
}
      } else {
        header("location: ../index.php ");
      }
      
      
    }
?>