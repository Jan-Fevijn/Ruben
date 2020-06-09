<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>kooken voor groepen</title>
    <link rel="stylesheet" type="text/css" href="css.css">
    <style>
        td,tr,th,table {
            padding:5px;
        }
        .event {
            color:black;
        }
        h3 {
            font-size: 180%;
        }
        h2 {
            font-size: 180%;
        }
    </style>
</head>
<body>
    <?php
    include("dbconn.php");
    include("checkIfLogedIn.php");
    include("banner.php");
    include("adminBanner.html");
    echo("<h2> admin lijsten </h2>");
    echo("<h3> eventen </h3>");
    $sql = 'select * from event';
    $result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    echo("<table border = '1'>");
    echo("<tr> <th> naam </th> <th> begindatum </th> <th> eintdatum </th> </tr>");
    while($row = $result->fetch_assoc()) {
        echo("<tr>");
        echo " <td> " . $row["naam"]. "</td><td> " . $row["datumStart"]. "</td> <td> " . $row["datumEnd"]. " </td> ";
        echo("<tr>");
       
    }
} else {
    echo "0 results";
}
echo("</table>");
echo("<h3>inschrijvingen </h3>");
$sql = "select idevent,datumStart, datumEnd, img, ie.naam as eventName,idinschrijving,u.iduser,voornaam,u.naam,u.vegan,veganistisch,u.username from user as u inner join ( select i.idevent,datumStart, datumEnd, img,naam,idinschrijving,iduser from event as e inner join (select * from inschrijving)as i on i.idevent =e.idevent) as  ie on ie.iduser =u.iduser order by idevent";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    echo("<table border = '1'>");
    echo("<tr> <th> naam event </th> <th> begindatum </th> <th> eintdatum </th> <th> voornaam </th> <th> naam </th></tr>");
    while($row = $result->fetch_assoc()) {
        echo("<tr>");
        echo " <td> " . $row["eventName"]. "</td><td> " . $row["datumStart"]. "</td> <td> " . $row["datumEnd"]. " </td><td> " . $row['voornaam'] . "</td> <td> " . $row['naam'] . "</td>";
        echo("<tr>");
    }
    echo("</table>");
} else {
    echo "0 results";
}


echo("<h3> ingredienten </h3>");
$sqlEvent = "SELECT * FROM kokenvoorgroepen.event";
$resultEvent = $conn->query($sqlEvent);

if ($resultEvent->num_rows > 0) {
    while($rowEvent = $resultEvent->fetch_assoc()) {
        echo("<h1 class='event'> event: " . $rowEvent['naam']. "</h1>");

        echo("<h2>inschrijvingen </h2>");
        $idevent = $rowEvent['idevent'];
$sql = "select idevent,datumStart, datumEnd, img, ie.naam as eventName,idinschrijving,u.iduser,voornaam,u.naam,u.vegan,veganistisch,u.username from user as u inner join ( select i.idevent,datumStart, datumEnd, img,naam,idinschrijving,iduser from event as e inner join (select * from inschrijving)as i on i.idevent =e.idevent) as  ie on ie.iduser =u.iduser where idevent = $idevent order by idevent ";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    echo("<table border = '1'>");
    echo("<tr> <th> naam event </th> <th> begindatum </th> <th> eintdatum </th> <th> voornaam </th> <th> naam </th></tr>");
    while($row2 = $result->fetch_assoc()) {
        echo("<tr>");
        echo " <td> " . $row2["eventName"]. "</td><td> " . $row2["datumStart"]. "</td> <td> " . $row2["datumEnd"]. " </td><td> " . $row2['voornaam'] . "</td> <td> " . $row2['naam'] . "</td>";
        echo("<tr>");
    }
    echo("</table>");
} else {
    echo "0 inschrijvingen";
}

$sqlGerechten = "SELECT g.idgerecht, naam, vegan ,veganistisch, idEvent FROM kokenvoorgroepen.gerecht as g inner join (select * from eventgerecht) as eg on g.idgerecht =eg.idgerecht where idEvent = $idevent ";
$resultGerechten = $conn->query($sqlGerechten);
echo("<h3>gerechten: </h3>");
 while($rowGerechten = $resultGerechten->fetch_assoc()) {
     
        echo " <h4> " . $rowGerechten["naam"]. "</h4> " ;
        $idgerecht = $rowGerechten['idgerecht'];

        $sqlGerechtProduct = "
        select gerechtid, naam as product, hoeveelheid, voluit as eenheidFull, eenheid as eenheidAfk, winkel from eenheden as e inner join (
            select w.naam as winkel, gerechtid, idproduct, eenheid, w.idwinkel, hoeveelheid, s.naam from winkel as w inner join(
            SELECT gerechtid, p.idproduct ,eenheid,idwinkel,pg.hoeveelheid,naam FROM kokenvoorgroepen.product as p
            inner join (select * from produtgerecht)pg on p.idproduct = pg.productid) as s
            on w.idwinkel = s.idwinkel) as a on a.eenheid = e.afkorting where gerechtid = $idgerecht
            
        ";
        // echo($sqlGerechtProduct);
        $resultGerechtProduct = $conn->query($sqlGerechtProduct);

        if ($resultGerechtProduct->num_rows > 0) {
            // output data of each row
            echo("<table border = '1'>");
            echo("<tr> <th> ingrediënt </th> <th> hoeveelheid </th> <th colspan='2'> eenheid </th>  <th> winkel </th></tr>");
            while($rowGerechtProduct = $resultGerechtProduct->fetch_assoc()) {
                echo("<tr>");
                echo("<td>". $rowGerechtProduct['product'] ."</td><td>".  $rowGerechtProduct['hoeveelheid']  ."</td><td>". $rowGerechtProduct['eenheidFull']  ."</td><td>".  $rowGerechtProduct['eenheidAfk'] ."</td><td>".  $rowGerechtProduct['winkel']);
               echo("</tr>");
            }
            echo("</table>");

    }
    }
}
}


echo ("<h1 class='event'> producten in stock : </h1> ");
$sqlStock = "select w.naam as winkel, sub.naam as product, hoeveelheid, voluit as eenheid from winkel as w inner join(
    SELECT naam, hoeveelheid, voluit, afkorting, idwinkel from product as p inner join 
    (SELECT * from eenheden) as e
    on e.afkorting = p.eenheid) as sub on sub.idwinkel = w.idwinkel";
if ($result = $conn->query($sqlStock) ) {



if ($result->num_rows > 0) {
    // output data of each row
    echo("<table border='1'>");
    echo("<tr> <th>product</th><th>hoeveelheid</th><th>eenheid</th> </tr>");
    while($row = $result->fetch_assoc()) {
        echo("<tr>");
        echo("<td>");
            echo($row['product']);
        echo("</td>");

        echo("<td>");
        echo($row['hoeveelheid']);
    echo("</td>");

    echo("<td>");
    echo($row['eenheid']);
echo("</td>");
        echo("<tr>");
    }
    echo("</table>");
}
} else {
   
}
    ?>
</body>
</html>