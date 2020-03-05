<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>
<link rel="stylesheet"
          type="text/css"
          href="../css/css.css" />
          <link rel="stylesheet"
          type="text/css"
          href="../css/cssLogin.css" />
      
<?php 
$debug = false  ;
$save = true ;

session_start();
if (isset($_SESSION['id'])) {
  session_destroy();
  unset($$_SESSION['id']);
}
include("dbConnection.php");
include("banner.php");
?>
	    

      <div class="login">
  <div class="heading">
   <label for='email'> <h2>inloggen:</h2> </label>
    <form  method="POST" action="login.php">

      <div class="input-group input-group-lg">
        <span class="input-group-addon"><i class="fa fa-user"></i></span>
        <input id='email'  name="email" type="email" class="form-control" placeholder="email">
          </div>

        <div class="input-group input-group-lg">
          <span class="input-group-addon"><i class="fa fa-lock"></i></span>
          <input  name="password" type="password" class="form-control" placeholder="wachtwoord">
        </div>
          <a href="wachtwoordVergeten.php">wachtwoord vergeten?</a><br />
            of heb je nog geen account?  <a href="registreer.php">registreer</a> <br>
        <button type="submit" class="float">Login</button>
       </form>
 		</div>
 </div>







         
						 </div>
<?php
	if (isset($_POST['email'])) {
        //	echo("azerty");
            $email = $_POST['email'];
           
            $password =  $_POST['password'];
            echo($password); echo ("<br>");
            $password = md5(  $password);
            echo($password); echo ("<br>");
            echo($email); echo ("<br>");
            $sql = "SELECT * FROM admin WHERE wachtwoord= '$password' and email='$email'";
    
         
    
            $resultaat = $conn->query($sql);
    
         
            $row = $resultaat->fetch_assoc();
            if (isset($row['idadmin'])) {
            $id =  $row['idadmin'];
               // echo("admin : <br>id = " . $id);
               $_SESSION["id"] = $id;
               header('Location: admin.php');
          
                }
                else {
                  //  echo("geen admin (check if leerling <br>"); 
                   // geen admin check if leerling
                    
                    $sql = "SELECT * FROM leerlingen WHERE wachtwoord= '$password' and email='$email'";
                    $resultaat = $conn->query($sql);
                    $row = $resultaat->fetch_assoc();
                    if (isset($row['idleerlingen'])) {
                    $id =  $row['idleerlingen'];
                    $_SESSION["id"] = $id;
                    header('Location: oefeningen.php');
                        
                    } else {
                        // geen admin of leerling, check if leerkracht 
                          if ($debug)  echo("<br> no leerling");
                            if ($save == true ) {
                            $sql = "SELECT * FROM leerkrachten WHERE wachtwoord= '$password' and email='$email'";
                            echo($sql);
                            $resultaat = $conn->query($sql);
                          while (  $row = $resultaat->fetch_assoc()) {
                              echo($row['idleerkrachten']. $row['naam']);

                              if (isset($row['idleerkrachten'])) {
                                $id =  $row['idleerkrachten'];
                                $_SESSION["id"] = $id;
                                header('Location: leerkrachten.php');
                                     
                                } else { 
                                    echo("foutief email of wachtwoord ");
                                }

                          }
                          
                            }
                    }

    
                }
            }
    
           
?>


</body>
</html>