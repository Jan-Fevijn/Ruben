<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</head>
<body>
<h1> in ons magazijn zitten de volgende producten. </h1>
    <form action='verwerking.php' method='POST'>
    <input type='hidden' name='idgebruiker' value='<?php echo($_GET['idgebruiker']); ?>'> 
<table class="table table-hover" >
<tr>
    <th>idonderdeel</th> <th>korteOmschrijving </th> <th> langeOmschrijving </th> <th> plaats </th><th> aantal </th> <th> aankopen </th>
</tr>
    <?php
    include("dbConn.php");
        $sql = "SELECT 
        aantalAanwezig, Plaats, onderdeel.idonderdeel, korteOmschrijving, langeOmschrijving, aantallenplaats.idaantallenPlaats
        FROM examenwdjuni2020.aantallenplaats
       inner join onderdeel 
       on aantallenplaats.idonderdeel = onderdeel.idonderdeel";
      
        $result = $conn->query($sql);
        
        if ($result->num_rows > 0) {
          // output data of each row
          while($row = $result->fetch_assoc()) {
            echo("<tr><td> ".$row['idonderdeel']." </td> <td> ".$row['korteOmschrijving']." </td> <td> ".$row['langeOmschrijving']." </td> <td> ". $row['Plaats']. " </td>");
            echo(" <td> ".$row['aantalAanwezig']);
            
            ?>
                <input type = 'submit' value='wijzigen' name='wijzig<?php echo($row['idaantallenPlaats']); ?>'> 
                <td><input type='submit' value='aankopen' name='koop<?php echo($row['idonderdeel']); ?>'> </td>
            <?php
            echo("</tr>");
        }
    } else {
      echo "0 results";
    }
    $conn->close();
    ?>

    </table>

  <?php 
    if(isset($_GET['wijzig'])) {
        ?>
            <form action='verwerking.php' method='POST'>
                <input type='hidden' name='idaantallenPlaats' value='<?php echo($_GET['wijzig']) ;?> '>
                <input type='hidden' name='idgebruiker' value='<?php echo($_GET['idgebruiker']); ?>'> 
                <label for='aantal'> hoeveel zijn er momenteel aanwezig? </label>
                <input type='text' id='aantal' name='aantal'><br>
                <input type='submit' value='wijzigen'>
            </form>
        <?php
    }

?>

</body>
</html>