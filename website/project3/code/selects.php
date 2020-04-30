<?php 
$userCode = $_SESSION['userCode'];
$machinenummer =  $_SESSION['machineNumber'];



if (isset($_POST['order'])){
    $sqlUser = "SELECT * FROM bakerijpol.user where code = '$userCode'";
$resultUser = $conn->query($sqlUser);
if ($resultUser->num_rows > 0) {
    // output data of each row
    while($row = $resultUser->fetch_assoc()) {
        $idUser = $row['idUser'];
        $code = $row['code'];
        $saldo = $row['saldo'];
       // echo("<h3> code : $code  saldo = $saldo </h3>");
    }
} else {
    echo "0 results";
}

    if (isset($_SESSION['userCode'])) {
       
        $sql = "SELECT * FROM bakerijpol.broodlocatie where locatie = $machinenummer";
        $result = $conn->query($sql);

        if ($result->num_rows > 0) {
            $row = $result->fetch_assoc();
            $IDsoordBrood = $row['IDsoordBrood'];
        }


        $sqlUser = "SELECT * from user where code = $userCode ";
        if($resultUser = mysqli_query($conn, $sqlUser)){
            if(mysqli_num_rows($resultUser) > 0){
             $rowUser = mysqli_fetch_array($resultUser);
             $saldo = $rowUser['saldo'] ;
             $idUser = $rowUser['idUser'];
            
            }
        }

        $sqlBrood = "SELECT * FROM bakerijpol.soortbrood where idsoortBrood = $IDsoordBrood  ";

        if($resultBrood = mysqli_query($conn, $sqlBrood)){
            if(mysqli_num_rows($resultBrood) > 0){
                $rowBrood = mysqli_fetch_array($resultBrood);
             $broodprijs =   $rowBrood['prijs'];
             $_SESSION['broodprijs'] =  $broodprijs;
           //  echo('brood');
            }
        }




    }


} else {
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