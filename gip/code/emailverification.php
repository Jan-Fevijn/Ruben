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
    <input id="EmailF" type="submit" size="500" /><br /> 
    
    <?php
        if (isset( $_SESSION['verivicatiecode'])) {
            if (isset( $_SESSION['email'])) { 
                
                if (isset( $_POST['verivicatiecode'])) {  
                    if ($_POST['verivicatiecode'] ==  $_SESSION['verivicatiecode']) {
                        echo("juist!<br>");

                        
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