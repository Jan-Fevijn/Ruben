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
    echo("<h2> welk event wil je verwijderen? </h2>");

    if (isset($_GET['id'])) {
        $id = $_GET['id'];
        $sql = " DELETE FROM `kokenvoorgroepen`.`event` WHERE (`idevent` = '$id')";
        if ($conn->query($sql) === TRUE) {
            $sql = " DELETE FROM `kokenvoorgroepen`.`eventgerecht` WHERE (`idevent` = '$id')";
            if ($conn->query($sql) === TRUE) {
                header('Location: deleteEvent.php');  
            }     
        }
    } else {

    
    $sql = "SELECT * FROM event";
$result = $conn->query($sql);



if ($result->num_rows > 0) {
    // output data of each row
    echo("<div class='flexbox' >");
    while($row = $result->fetch_assoc()) {
    $idevent =    $row['idevent'];
    echo("<a class='flexItam' href='deleteEvent.php?id=$idevent'>");
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
    ?>
</body>
</html>