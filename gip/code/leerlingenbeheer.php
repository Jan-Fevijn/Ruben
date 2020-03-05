<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../../css/css.css" />
</head>
<body>
    <?php
    $accType="ADMIN";
    include("checkIfLogedIn.php");
    include("dbConnection.php");
    include("banner.php");
    echo ("<div id = 'midden'> <a href= 'admin.php'>back</a> </div>");
    $sql = "SELECT lln.idleerlingen,  lln.naam  as leerlingNaam , lln.famielienaam as leerlingFamilienaam,lln.oefeningid, lln.email as emailLeerling, sub1.naam as naamLeerkracht,sub1.email as emailLeerkracht, sub1.klasnaam as klasnaam, sub1.idklas as idklas, sub1.famielienaam as famielninaamLeerkracht from  (select lkr.idleerkrachten, lkr.naam, lkr.famielienaam, k.idklas, k.klasnaam, lkr.email from dbarduinoeducatief.leerkrachten as lkr inner join dbarduinoeducatief.klas as k on lkr.idleerkrachten = k.idleerkracht) as sub1 inner join dbarduinoeducatief.leerlingen as lln on lln.idklas = sub1.idklas ;";
    $result = $conn->query($sql);
    
    if ($result->num_rows > 0) {
        // output data of each row
        echo("<table border='5'  style='  background-color: white;'>");
        echo("<tr> <th>idleerlingen</th>  <th>voornaam leerling</th> <th>naam leerling</th> <th>email leerling</th> <th>voornaam leerkracht</th>  <th>naam leerkracht</th> <th>email leerkracht</th> <th>klasnaam</th> <th>klas ID</th> <th>oefening ID</th> </tr>");
        while($row = $result->fetch_assoc()) {
            echo " <tr> <td> " . $row["idleerlingen"]. " </td><td> " . $row["leerlingNaam"]. " </td><td> "  . $row["leerlingFamilienaam"]." </td><td> " . $row["emailLeerling"]." </td><td> " . $row["naamLeerkracht"] ." </td><td> " . $row["famielninaamLeerkracht"]. " </td><td> " . $row["emailLeerkracht"]." </td><td> " . $row["klasnaam"]. " </td><td> " . $row["idklas"]. " </td> <td> " . $row["oefeningid"]. " </td> </tr> " ;
        }
        echo("</table>");
    } else {
        echo "0 results";
    }

    ?>
    <?php
include("footer.php");
?>
   
    
</body>
</html>