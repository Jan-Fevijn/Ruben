<html lang="en" xmlns="http://www.w3.org/1999/xhtml"><head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css.css">
    <style>
    h3 {
        background-color: lightgrey;
    }
    .noSpaceBetween {
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





$idEvent = $_GET['id'];
$sql = "SELECT * FROM event where idEvent = '$idEvent'";
$result = $conn->query($sql);



if ($result->num_rows > 0) {
    // output data of each row
    echo("<div class='flexbox' >");
   $row = $result->fetch_assoc();
    $idevent =    $row['idevent'];
    echo("<div class='flexItam' ");
        echo("<h3>" . $row['naam']. "</h3>");
        echo("<img src='" . $row['img'] . " ' height='100'>");
       

       ?>
       <br>
       <form class='noSpaceBetween'>
        <input class='noSpaceBetween' value='inschrijven' name='inschrijven' type='submit'>
       </form>
       <?php
        




        echo("</div>");
   
    echo("</div>");
}
echo("<br><br><br>");
$sql2 = " select egg.naam,egg.img, event.idEvent, egg.idGerecht, egg.vegan ,egg.veganistisch from event inner join ( SELECT  naam,img,vegan,veganistisch,idEvent, g.idGerecht FROM kokenvoorgroepen.gerecht as g inner join kokenvoorgroepen.eventgerecht as eg on g.idgerecht = eg.idgerecht ) as egg on egg.idEvent =  event.idEvent WHERE event.idEvent = '$idEvent' ";
$result2 = $conn->query($sql2);



if ($result2->num_rows > 0) {
    // output data of each row
    echo("<div class='flexbox' >");
    while($row2 = $result2->fetch_assoc()) {
   // $idevent =    $row2['idevent'];
    echo("<div class='flexItam' >");
        echo("<h3>" . $row2['naam']. "</h3>");
        echo("<img src='" . $row2['img'] . " ' height='200'>");
       
        echo("<div class='info'>");
       if ($row2['vegan'] == 1) {
           $string = "vegitarisch gerecht"; 
       } else if ($row2['veganistisch'] == 1) {
        $string = "veganistisch gerecht"; 
       } else {
           $string = "niet vegitaris / veganistisch";
       }
       echo($string);
       echo("<div class='noSpaceBetween'>");
       echo("<br> ingrediënten : ");
       $gerechtid = $row2['idGerecht'];
       $sql3 = "  select naam from product  inner join  ( SELECT productid ,gerechtid FROM gerecht as g inner join produtgerecht as pg on pg.gerechtid = g.idgerecht ) as a on product.idproduct = a.productid where a.gerechtid = '$gerechtid'; ";
       $result3 = $conn->query($sql3);
       while($row3 = $result3->fetch_assoc()) {
           echo($row3['naam'] . ", ");
       }
       echo("</div>");
        echo("</div>");
        echo("</div>");
    }
    echo("</div>");
}

    ?>
</body>
</html>