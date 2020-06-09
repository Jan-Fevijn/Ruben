<html lang="en" xmlns="http://www.w3.org/1999/xhtml"><head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css.css">
    <style>
    h3 {
        background-color: lightgrey;
    }
    </style>
</head>
<body>
<?php 
include("dbconn.php");
include("checkIfLogedIn.php");
include("banner.php");

// echo($_SESSION['iduser']);
$iduser = $_SESSION['iduser'];


$sql = "SELECT * FROM event";
$result = $conn->query($sql);



if ($result->num_rows > 0) {
    // output data of each row
    echo("<div class='flexbox' >");
    while($row = $result->fetch_assoc()) {
    $idevent =    $row['idevent'];
    echo("<a class='flexItam' href='event.php?id=$idevent'>");
        echo("<h3>" . $row['naam']. "</h3>");
        echo("<img src='" . $row['img'] . " ' height='200'>");
        echo("<div class='info'>");
        echo("datum: " . $row['datumStart'] . " - " . $row['datumEnd']);
        echo("</div>");
        echo("</a>");
    }
    echo("</div>");
}
    ?>
</body>
</html>