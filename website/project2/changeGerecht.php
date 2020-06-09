<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>kooken voor groepen</title>
    <link rel="stylesheet" type="text/css" href="css.css">
    <style>
    h3 {
        background-color: lightgrey;
    }
    h2 {
        font-size:180%;
    }
    label {
        display: block;
        text-align: center;
    }
    input {
        display: block;
        margin-left:42%;
    }
    .select {
        display: block;
    }
    </style>
</head>
<body>
    <?php
    include("dbconn.php");
    include("checkIfLogedIn.php");
    include("banner.php");
    include("adminBanner.html");
    if (isset($_POST['naam'])){
        $naam = $_POST['naam'];
        $img = $_POST['img'];
        $idgerecht =  $_GET['idgerecht'];
     
     
            $sql = "UPDATE `gerecht` SET  `naam` = '$naam',  `img` = '$img' WHERE (`idgerecht` = $idgerecht)  ";
            echo($sql . "<br>");
        if ($conn->query($sql) === TRUE) {
            echo "Record deleted successfully";
        } else {
            echo("line 45 update failed" . $conn->error );
        }
            $sqlaaa = " SELECT * from `produtgerecht`  WHERE (`gerechtid` = '$idgerecht' ) ";
            echo("<br> " . $sqlaaa);
            $resultaaa = $conn->query($sqlaaa);

if ($resultaaa->num_rows > 0) {
    // output data of each row
    while($rowaaa = $resultaaa->fetch_assoc()) {
       $idprodutGerecht = $rowaaa['idprodutGerecht'];
        $sql = "DELETE FROM `produtgerecht` WHERE (`idprodutGerecht` = '$idprodutGerecht')";
    
        $conn->query($sql) ;
        }
    }
                      // insert gerechten 
                     
                      $sql2 = "SELECT count(*) FROM gerecht";
                         if ($conn->query($sql2)) {
                            $result2 = $conn->query($sql2);
                            $row2 = $result2->fetch_assoc();
                             $countOfGerecht = $row2['count(*)'];
                             echo( $countOfGerecht);
                            // echo($countOfGerecht);
                             for ($x = 1; $x <= $countOfGerecht; $x++) {
                                 if (isset($_POST['hoeveelheid'.$x])) {

                                echo( "<br>". $x . "<br> ");
                                   //  echo($x . "    " . $_POST['i'.$x] . "<br>");
                                   $hoeveelheid = $_POST['hoeveelheid'.$x];
                                   if ($_POST['hoeveelheid' . $x]) {
                                     $sqlproducgerecht = "INSERT INTO `produtgerecht` ( `gerechtid`, `productid` , `hoeveelheid`) VALUES ( '$idgerecht', '$x','$hoeveelheid' )  ";
                                     if ($conn->query($sqlproducgerecht) === TRUE) {
                                         echo "New record created successfully line 78 <br>" .$sqlproducgerecht ;
                                     } else {
                                         echo " <br> line 77 Error: " . $sqlproducgerecht . "<br>" . $conn->error;
                                     }
                                    } else {

                                    }
                                 }
                                     
                                     
                     } 


        } else {
            echo(" <br>" .$conn->error);
        }
    
      
    }
 //   ////////////////////////////

    if (isset($_GET['idgerecht'])) {
            // gerecht already selected 
            $idgerecht = $_GET['idgerecht'];
        ?>
        <form method='POST'>
        <input type='hidden' name='idgerecht' value='<?php $idgerecht ?>'>
        <label for='naam'> naam </label>
        <input id='naam' type='text' name='naam'>

        <label for='img'> afbeelding url:  </label>
        <input id='img' type='img' name='img'>

       
       
<label > selecteer alle gerechten die je wil toevoegen (ook deze die er al in zaaten indien je ze wil behouden). </label>

        <?php
$sql = 'select * from product';
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
        $naam = $row['naam'];
        $idGerecht = $row['idproduct'];
      echo("  <h4 class='select'> <input type='checkbox' id='idGerecht' value='$idGerecht' name='i$idGerecht'> $naam</h4>");
     echo(" <label for='hoeveelheid$idGerecht'> hoeveelheid </label>");
     echo("  <input id='hoeveelheid$idGerecht' type='text' name='hoeveelheid$idGerecht'>");
    }
}
    } else {
                    // select an gerecht
        $iduser = $_SESSION['iduser'];


$sql = "SELECT * FROM gerecht";
$result = $conn->query($sql);



if ($result->num_rows > 0) {
    // output data of each row
    echo("<div class='flexbox' >");
    while($row = $result->fetch_assoc()) {
    $idgerecht =    $row['idgerecht'];
    echo("<a class='flexItam' href='changegerecht.php?idgerecht=$idgerecht'>");
        echo("<h3>" . $row['naam']. "</h3>");
        echo("<img src='" . $row['img'] . " ' height='200'>");
       
        echo("</a>");
    }
    echo("</div>");
}
    }



    if (isset($_GET['idgerecht'])) {
        echo("<input type='submit' value='gerecht wijzigen'>");
    }
  
    ?>
  
    </form>

    
 

</body>
</html>