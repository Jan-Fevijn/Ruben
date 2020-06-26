<?php
 include("dbConn.php");
// login 
if (isset($_POST['login']) ) {
    $username = $_POST['login'];
    $password = $_POST['password'];
    $sql = "select idgebruiker from gebruiker where gebruikernaam ='$username'  and wachtwoord = '$password'";
    $result = $conn->query($sql);
    if ($result->num_rows > 0) {

    $row = $result->fetch_assoc();
    $idgebruiker =  $row['idgebruiker'];
    header('Location: magazijn.php?idgebruiker='.$idgebruiker);
    } else {
        echo($sql);
        header('Location: index.php?m=foutieve gebruikersnaam of wachtwoord');
    }
}

// aankopen 

for ($x = 0; $x <= 10; $x++) {
    if (isset($_POST['koop' . $x])) {
        $idgebruiker = $_POST['idgebruiker'];
        $koop =$x;
        echo($x);

        $sql = "INSERT INTO `examenwdjuni2020`.`winkelmand` (`idgebruiker`, `idonderdeel`, `aantaalAankoop`) VALUES ('$idgebruiker', '$x', '1');";

        if ($conn->query($sql) === TRUE) {
            header('Location: winkelmantje.php?koop='.$x.'&idgebruiker='. $idgebruiker);
          } else {
            echo "Error: " . $sql . "<br>" . $conn->error;
            echo "please try again";
          }
          
      

        
    }

}





// wijzig hoeveelheid

for ($x = 0; $x <= 10; $x++) {
    if (isset($_POST['wijzig' . $x])) {
        $idgebruiker = $_POST['idgebruiker'];
        echo($x);
        header('Location: magazijn.php?wijzig='.$x . '&idgebruiker='. $idgebruiker);
    }

  }
if (isset($_POST['idaantallenPlaats']) && isset($_POST['aantal'])) {
    $idgebruiker = $_POST['idgebruiker'];
    $count = $_POST['aantal'];
    $idaantallenPlaats = $_POST['idaantallenPlaats'];
    $sql = "UPDATE `aantallenplaats` SET `aantalAanwezig` = '$count' WHERE (`idaantallenPlaats` = '$idaantallenPlaats')";
    $conn->query($sql);
    echo($sql);
    header('Location: magazijn.php?idgebruiker='. $idgebruiker);
}






?>