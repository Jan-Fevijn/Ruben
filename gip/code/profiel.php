<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../css/css.css" />
</head>
<body>
<?php 
include("checkIfLogedIn.php");
include("dbConnection.php");
$accType =  $_SESSION['accType'];
include("banner.php");

?>
<div class='container'>
<table border='1' id='registreerTable'>
    <tr>
        <td>
            functie: 
        </td>
        <td>
            <?php echo($accType);?> 
        </td>
    </tr>

    <tr>
        <td>
            naam: 
        </td>
        <td>
            <?php echo($row['naam'] ." ". $row['famielienaam'] );?> 
        </td>
    </tr>
    <tr>
        <td>
            email: 
        </td>
        <td>
            <?php echo($row['email'] );?> 
        </td>
    </tr>
    <tr>
        <td>
            wachtwoord: 
        </td>
        <td>
            
            <form method='POST' >
          
          <input  title="gelieve hier nieuw u wachtwoord in te vullen, indien je die wil veranderen, deze moet minstens 8 tekens bevatten." value="44" class='input'  size="30" name='password1' type='password' value=''> <br><br>
   
          
            <input title="gelieve hier nieuw u wachtwoord opnieuw in te vullen, indien je die wil veranderen, deze moet minstens 8 tekens bevatten en gelijk zijn aan het wachtwoord die je hierbooven ingevuld hebt." value="44" class='input' size="30"  name='password2' type='password' value=''> <br><br>
           
            <input class='input'  type='submit' value='wachtwoord wijzigen' >
            </form>
           
        </td>
    </tr>
    <?php  
    if ($accType == "ADMIN") {
        // specifieke info voor ADMIN 
    }
    if ($accType == "leerling") {
        // specifieke info voor leerling
        $sql = "SELECT oefeningid FROM leerlingen WHERE idleerlingen = '$id'";
        $result = $conn->query($sql);
        $row = $result->fetch_assoc();
        // oefiningnummer 
        echo ("<tr>  <td> ");
        echo("oefening nummer");
        echo("</td> <td> ");
        echo($row['oefeningid']);
        echo ("</td> </tr>"); 
    }
    if ($accType == "leerkracht") {
        // specifieke info voor leerkracht 
        $sql = " SELECT idoefeningen, tietel, naam, famielienaam, idleerlingen, idleerkrachten, oefeningid from oefeningen inner join (  select a.naam, a.famielienaam, a.idleerlingen, leerkrachten.idleerkrachten ,a.oefeningid from leerkrachten inner join ( select leerlingen.oefeningid, leerlingen.idleerlingen , klas.idklas ,klas.idleerkracht , leerlingen.naam, leerlingen.famielienaam from klas inner join leerlingen on klas.idklas = leerlingen.idklas ) as a on leerkrachten.idleerkrachten = a.idleerkracht ) as b on b.oefeningid = oefeningen.idoefeningen WHERE idleerkrachten = '$id'";
        $result = $conn->query($sql);
        
        echo ("<tr>  <td> ");
                echo("oefeningnummer leerlingen ");
        echo("</td> <td> ");
                echo ("<table border='1' > ");
                echo("<tr> <th> oefeningnummer </th> <th>naam</th> <th> familienaam </th> </tr>  ");
            while ($row = $result->fetch_assoc()) { 
                //echo("55555555555");
                echo("<tr> <td> " . $row['idoefeningen']. "</td> <td> " . $row['naam'] ."</td> <td> " . $row['famielienaam'] . "</td> </tr>");
            }
                
                echo("</table>");
        echo ("</td> </tr>");
    }
 

    ?>
</table>
</div>


<?php 
if(isset($_POST['password1'])){
   $password1 = $_POST['password1'];
   $password2 = $_POST['password2'];
 if ($password1 == $password2) {
     if ($accType == "ADMIN") {
        $password1 = md5($password1);
        $sql = "UPDATE admin set wachtwoord= '$password1'   WHERE idadmin = '$id'";
     } else if ($accType == "leerkracht") {
        $sql = "UPDATE leerkrachten set wachtwoord= '$password1'   WHERE idleerkrachten = '$id'";
     } else if ($accType == "leerling") {
        $sql = "UPDATE leerlingen set wachtwoord= '$password1'   WHERE idleerlingen = '$id'";
     }


     if ($conn->query($sql)) {
       if ($debug) echo "Record updated successfully";
    } else {
        echo "Error updating record: " . $conn->error;
    }

 }
}
?>
<?php
include("footer.php");
?>
   

</body>
</html>