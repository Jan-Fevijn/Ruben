<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet"
          type="text/css"
          href="../css/css.css" />
</head>
<body>
<?php
include("dbConnection.php");
include("banner.php");
 session_start();
  ?>  

<br /><br /><br /><br /><br /><br />
    <div> <form method='POST'>
    
        <h2>u hebt een email ontvangen, gelieve die hier in te voeren.</h2>  <div id="midden">
       ( indien u hem niet vindt kunt u altijd nog tussen de reclame, spam en sociaal kijken.)<br><br>
       <?php 
    // echo("verivicatiecode =". $_SESSION['verivicatiecode'] ."<br>");
    echo("email = ".$_SESSION['email'] ." <br>");
       ?>
    <input type="code" name='verivicatiecode' size="30" id="EmailF" /> <br /> <br />
    <input id="EmailF" type="submit" size="500" /><br /> <label> bent u een : <br>
    <input type ='radio' id='accType0' value ='leerling' name= 'accType'> <label for='accType0'> leerling <label>
    <input type ='radio' id='accType1' value ='leerkracht' name= 'accType'> <label for='accType1'> leerkracht <label>
    <input type ='radio' id='accType2' value ='admin' name= 'accType'>  <label for='accType2'>admin <label> <br>
    <?php
        if (isset( $_SESSION['verivicatiecode'])) {
            if (isset( $_SESSION['email'])) { 
                $email = $_SESSION['email'];
                if (isset( $_POST['verivicatiecode'])) {  
                    if ($_POST['verivicatiecode'] ==  $_SESSION['verivicatiecode']) {
                        echo("juist!<br>");

                        // log in
                        $_SESSION['accType'] = $_POST['accType'];
                        switch ($_POST['accType']) {
                            case "leerling":
                              $sql = "SELECT idleerlingen as id FROM dbarduinoeducatief.leerlingen where email ='$email'";
                                break;
                            case "leerkracht":
                                $sql = "SELECT idleerkrachten as id FROM dbarduinoeducatief.leerkrachten where email ='$email'";
                                break;
                            case "admin":
                                $sql = "SELECT idadmin as id FROM dbarduinoeducatief.admin where email ='$email'";
                                break;
                        }

                        $result = $conn->query($sql);
                        if ($result->num_rows > 0) { 
                            $row = $result->fetch_assoc();
                            $id = $row['id'];
                            $_SESSION['id'] = $id;
                            echo($id . " as " .$_POST['accType'] );
                            header('Location: changePassword.php');
                        } else {
                            echo("uw email adress is mogelijk niet in gebruik als " . $_POST['accType']. "<br>");
                        }

                    } else {
                        echo("uw verivicatiecode is foutief , probeer nog een keer <br> ");
                    }
                }
                
                
            } else  echo('kkk');
        } else echo('ddd');

?>
    
    <a href="wachtwoordVergeten.php" id="EmailF">email opnieuw verzenden</a>

</div> 
    </div>

 
</body>
</html>