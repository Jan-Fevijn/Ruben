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
    <table class="table table-hover" >
        <tr> <th> idproduct <th> <th> prduct </th> <th> omschrijving </th> <th> aantal </th> </tr>
            <?php 
             include("dbConn.php");
                $sql = "SELECT winkelmand.idonderdeel, aantaalAankoop,  korteOmschrijving, langeOmschrijving FROM winkelmand inner join onderdeel on winkelmand.idonderdeel = onderdeel.idonderdeel;";
                $result = $conn->query($sql);

                if ($result->num_rows > 0) {
                    // output data of each row
                    while($row = $result->fetch_assoc()) {
                        echo("<tr> <td>". $row['idonderdeel'] ."<td> <td> ".$row['aantaalAankoop']." </td> <td> ".$row['korteOmschrijving']." </td> <td>". $row['langeOmschrijving'] ." </td></tr>");
                    }
                } else {
                  echo "je winkelmantje is nog leeg";
                }


                

            ?>
</table>
            <form method='POST' action='verwerking.php'>
                <label for='email'>email </label>
                <input type='text' name='email' id='email'>
                <input type='submit' value='stuur email' >
            </form>
    </table>


</body>
</html>