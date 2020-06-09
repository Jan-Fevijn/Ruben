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
        font-size:40%;
    }
    .info {
        font-size:20%;
    }
    </style>
</head>
<body>
    <?php
    include("dbconn.php");
    include("checkIfLogedIn.php");
    include("banner.php");
    include("adminBanner.html");
    echo("<h2> welk gerecht wil je verwijderen? </h2>");

    if (isset($_GET['id'])) {
        $id = $_GET['id'];
        $sql = " DELETE FROM `gerecht` WHERE (`idgerecht` = '$id')";
        if ($conn->query($sql) === TRUE) {
            $sql = " DELETE FROM `produtgerecht` WHERE (`gerechtid` = '$id')";
            if ($conn->query($sql) === TRUE) {
                header('Location: deletegerecht.php');  
            }     else {
                echo($sql . " error ".$conn->error);
            }
        }   else {
            echo($sql . " error " . $conn->error);
        }
    } else {

    
    $sql = "SELECT * FROM gerecht";
$result = $conn->query($sql);



if ($result->num_rows > 0) {
    // output data of each row
    echo("<div class='flexbox' >");
    while($row = $result->fetch_assoc()) {
    $idgerecht =    $row['idgerecht'];
    echo("<a class='flexItam' href='deleteGerecht.php?id=$idgerecht'>");
        echo("<h3>" . $row['naam']. "</h3>");
        echo("<img src='" . $row['img'] . " ' height='200'>");
       
        echo("</a>");
    }
    echo("</div>");
}
    }
    ?>
</body>
</html>