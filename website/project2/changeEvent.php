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

    if (isset($_POST['naam'])){
        $naam = $_POST['naam'];
        
        $idEvent =  $_GET['idEvent'];

        $img = $_POST['img'];
        $datVan = $_POST['dateVan'];
        $datTot = $_POST['dateTot'];

            $sql = "UPDATE `kokenvoorgroepen`.`event` SET `datumStart` = '$datVan', `datumEnd` = '$datTot', `img` = '$img', `naam` = 'kokedn voor beginners' WHERE (`idevent` = $idEvent)  ";
            echo($sql . "<br>");
        if ($conn->query($sql) === TRUE) {
            echo "Record deleted successfully";
        } else {
            echo("update failed");
        }

        $sql = "DELETE FROM `kokenvoorgroepen`.`eventgerecht` WHERE (`idEvent` = '$idEvent')";
    
        if ($conn->query($sql) === TRUE) {
                      // insert gerechten 
                     
                      $sql2 = "SELECT count(*) FROM gerecht";
                         if ($conn->query($sql2)) {
                            $result2 = $conn->query($sql2);
                            $row2 = $result2->fetch_assoc();
                             $countOfGerecht = $row2['count(*)'];
                            // echo($countOfGerecht);
                             for ($x = 1; $x <= $countOfGerecht; $x++) {
                                 if (isset($_POST['i'.$x])) {
                                   //  echo($x . "    " . $_POST['i'.$x] . "<br>");
                                     $sqlEventGerecht = "INSERT INTO `kokenvoorgroepen`.`eventgerecht` ( `idEvent`, `idGerecht`) VALUES ( '$idEvent', '$x')  ";
                                     if ($conn->query($sqlEventGerecht) === TRUE) {
                                         echo "New record created successfully line 55";
                                     } else {
                                         echo "Error: " . $sql . "<br>" . $conn->error;
                                     }
                                     
                                     
                                 }
                                
                 
                 
                 
                             }
                     } 


        }
    }

    if (isset($_GET['idEvent'])) {
            // event already selected 
            $idEvent = $_GET['idEvent'];
        ?>
        <form method='POST'>
        <input type='hidden' name='idEvent' value='<?php $idEvent ?>'>
        <label for='naam'> naam </label>
        <input id='naam' type='text' name='naam'>
        <label for='dateVan'> van </label>
    <input type='datetime-local' id='dateVan' name='dateVan'>
<label for='dateTot'> tot </label>
<input type='datetime-local' id='dateTot' name='dateTot'>
<label for='img'> url afbeelding </label>
<input type='text' id='img' name='img'>
<label > selecteer alle gerechten die je wil toevoegen (ook deze die er al in zaaten indien je ze wil behouden). </label>

        <?php
$sql = 'select * from gerecht';
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
        $naam = $row['naam'];
        $idGerecht = $row['idgerecht'];
      echo("  <h4 class='select'> <input type='checkbox' id='idGerecht' value='$idGerecht' name='i$idGerecht'> $naam</h4>");

    }
}
    } else {
                    // select an event
        $iduser = $_SESSION['iduser'];


$sql = "SELECT * FROM event";
$result = $conn->query($sql);



if ($result->num_rows > 0) {
    // output data of each row
    echo("<div class='flexbox' >");
    while($row = $result->fetch_assoc()) {
    $idevent =    $row['idevent'];
    echo("<a class='flexItam' href='changeEvent.php?idEvent=$idevent'>");
        echo("<h3>" . $row['naam']. "</h3>");
        echo("<img src='" . $row['img'] . " ' height='200'>");
        echo("<div class='info'>");
        echo("datum: " . $row['datumStart'] . " - " . $row['datumEnd']);
        echo("</div>");
        echo("</a>");
    }
    echo("</div>");
}
    }
    if (isset($_GET['idEvent'])) {
        echo("<input type='submit' value='event wijzigen'>");
    }
  
    ?>
  
    </form>

    
 

</body>
</html>