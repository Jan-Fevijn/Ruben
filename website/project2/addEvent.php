<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>kooken voor groepen</title>
    <link rel="stylesheet" type="text/css" href="css.css">
    <style>
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
    
    ?>
    <h2> event toevoegen </h2>
   
        <form method='POST'>
        <label for='naam'>naam </label>
        <input type='text' id='naam' name='naam'>
    <label for='dateVan'> van </label>
    <input type='datetime-local' id='dateVan' name='dateVan'>
<label for='dateTot'> tot </label>
<input type='datetime-local' id='dateTot' name='dateTot'>
<label for='img'> url afbeelding </label>
<input type='text' id='img' name='img'>
<label > selecteer alle gerechten die je wil toevoegen </label>


<?php
$sql = 'select * from gerecht';
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {
        $naam = $row['naam'];
        $idGerecht = $row['idgerecht'];
      echo("  <h3 class='select'> <input type='checkbox' id='idGerecht' value='$idGerecht' name='i$idGerecht'> $naam</h3>");

    }
} else {
    echo "0 results";
}
?>
<input type='submit' value='add event'>

       
        </form>
    
<?php

    if (isset($_POST['naam'])) {
       // echo("eee");
        $naam = $_POST['naam'];
        $img = $_POST['img'];
        $dateVan = $_POST['dateVan'];
        $dateTot = $_POST['dateTot'];
      
        $sql = "INSERT INTO `kokenvoorgroepen`.`event` ( `datumStart`, `datumEnd`, `img`, `naam`) VALUES ( '$dateVan', '$dateTot', '$img', '$naam')";
       
        if ($conn->query($sql) === TRUE) {
           $sql = "SELECT * FROM event WHERE datumStart ='$dateVan'  AND datumEnd = '$dateTot' AND  img ='$img' AND naam = '$naam' ";

           $result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row

    while($row = $result->fetch_assoc()) {
      
                     // insert gerechten 
                     $idEvent = $row['idevent'];
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
                        echo "New record created successfully";
                    } else {
                        echo "Error: " . $sql . "<br>" . $conn->error;
                    }
                    
                    
                }
               



            }
    } else {
        echo "Error: " . $sql2 . "<br>" . $conn->error;
    }

    }
} else {
    echo "0 results";
}
        } else {
            echo "Error: " . $sql . "<br>" . $conn->error;
        }
    }

?>


</body>
</html>