<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet"
          type="text/css"
          href="../css/css.css" />
          <style>
            label, input {
                display: block;
                font-size:200%;
                margin-top:7%;
            }
            form {
               position:fixed;
               top:30%;
               left:33%;

            }
          </style>
</head>
<body>
<?php
include("dbConnection.php");
include("banner.php");
 session_start();
  ?>
 <form method='POST'>
  <label for='password1'> wachtwoord : </label>
  <input type='password' id='password1' name='password1' />
  <label for='password2'> herhaal uw wachtwoord : </label>
  <input type='password' id='password2' name='password2'/>
  <input type='submit' value='wachtwoord wijzigen'>
  </form>

  <?php 
  if (isset($_POST['password1'])) {
   // echo($_SESSION['id'] ."<br>");
   // echo($_SESSION['accType'] ."<br>");
   if ($_POST['password1'] == $_POST['password2']) {
       $password = md5($_POST['password1']);
       $id = $_SESSION['id'];
    switch ($_SESSION['accType']) {
        case "leerling":
          $sql = "UPDATE `dbarduinoeducatief`.`leerlingen` SET `wachtwoord` = '$password' WHERE (`idleerlingen` = '$id')";
            break;
        case "leerkracht":
            $sql = "UPDATE `dbarduinoeducatief`.`leerkrachten` SET `wachtwoord` = '$password' WHERE (`idleerkrachten` = '$id');            ";
            break;
        case "admin":
            $sql = "UPDATE `dbarduinoeducatief`.`admin` SET `wachtwoord` = '$password' WHERE (`idadmin` = '$id')";
            break;
    }

    if ($conn->query($sql) === TRUE) {
        echo "New record created successfully <br>";
        echo($sql);


        switch ($_SESSION['accType']) {
            case "leerling":
              header('Location: oefeningen.php');
                break;
            case "leerkracht":
                header('Location: leerkrachten.php');
                break;
            case "admin":
                header('Location: admin.php');
                break;
        }


    } else {
        echo "Error: " . $sql . "<br>" . $conn->error;
    }
   } else {
       echo("de 2 wachtwoorden koomen niet overeen");
   }
}
  ?>
</body>
</html>