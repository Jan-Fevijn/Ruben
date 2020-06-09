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
    include("adminBanner.html");
    
    ?>

    <form method='POST'>
        <label for='naam'> naam gerecht</label>
        <input type='text' name='naam' id='naam'>
        
        <label for='img'> url afbeelding </label>
        <input type='text' name='img' id='img'>

        <label for='v0'> <h2> vegitarishc / veganistisch </h2></label>
        <input type='radio' name='vegan' value='0' id='v0'><label for='v0'> niet vegitaris / veganistisch </label>
        <input type='radio' name='vegan' value='1' id='v1'><label for='v1'>vegitaris </label>
        <input type='radio' name='vegan' value='2' id='v2'><label for='v2'>  veganistisch </label>
  
      <?php
            $sql="select * from product";
            $result = $conn->query($sql);

if ($result->num_rows > 0) {
    echo("<h2> producten: </h2>");
    while($row = $result->fetch_assoc()) {
        $naam = $row['naam'];
        $idporduct = $row['idproduct'];
           echo(" <input type='checkbox' name='product$idporduct' value='$idporduct' id='v$idporduct'><label for='v$idporduct'> $naam </label>");
            echo("<label for='productHoeveelheid$idporduct' > hoeveelheid:  </label> <input type='text' hoeveelheid");
    }
}
      ?>
<input type='submit' value='add gerecht'>
    </form>




    <?php 
    if (isset($_POST['naam'])) {
        if (isset($_POST['vegan'])) {
        $naam = $_POST['naam'];
        $img = $_POST['img'];
       
        switch ($_POST['vegan']) {
            case 0:
              $vegan = 0;
              $veganistisch = 0;
                break;
            case 1:
                $vegan = 1;
                $veganistisch = 0;
                break;
            case 2:
                $vegan = 0;
                $veganistisch = 1;
                break;


        }

            $sql = "INSERT INTO `kokenvoorgroepen`.`gerecht` ( `naam`, `img`, `vegan`, `veganistisch`) VALUES ('$naam', '$img', '$vegan', '$veganistisch') ";
           
            if ($conn->query($sql) === TRUE) {
                    echo("inserted");


                    // add products to gerecht
                $sql =" SELECT idgerecht from gerecht where naam = '$naam'";
                $result = $conn->query($sql);
                $row = $result->fetch_assoc();
                $idgerecht = $row['idgerecht'];
              


                 

            }

        } else {
            echo("gelieve aan te duiden of het een vegitaris, veganistisch of geen van bijden is.");
        }
    }

?>
</body>
</html>