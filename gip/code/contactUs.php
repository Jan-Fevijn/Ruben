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
 $s = true ; 
 session_start();
 include("dbConnection.php");
 $debug = false ;
        if (isset($_SESSION['accType'])) {
            $accType = $_SESSION['accType'];
        }
    
        include("checkIfLogedIn.php");
        include("banner.php");
   


?>
    <h2> contacteer ons:</h2>
    <div id="contact">
        <form method="POST" action="contactUs.php" id="contactForm">
            <div id="contactGeg">


                voornaam: <input type="text" name="voornaam" id="voornaam" />
                familienaam: <input type="text" name="naam" id="familienaam" /> 
                Email: <input name="email" id="email" type="Email"/>

            </div>
            <p  id="bericht">bericht: </p> <textarea name="bericht" id="berichtBox" rows="6" cols="70">
Schrijf hier uw bericht, we antwoorden zo snel mogelijk via uw ingegeven Emailadres.
</textarea> <br /> <input value="bericht verzenden" id="verzendBerciht" type="submit" />

        </form >
						<?php
                    
                        if (isset($_POST['email'])) {
	$email = $_POST['email'];
  
    $subject = 'from:' . $email . 'Your subject for email';
    $message = $_POST['bericht'];
    $naam = $_POST['naam'];
    $voornaam = $_POST['voornaam'];

    $sql = "INSERT INTO `dbarduinoeducatief`.`reports` ( `message`, `naam`, `voornaam`, `email`) VALUES ('$message', '$naam', '$voornaam', '$email')";
    
    if ($conn->query($sql) === TRUE) {
        if($debug) echo "New record created successfully";
      } else {
         echo "Error: " . $sql . "<br>" . $conn->error;
      }
}
			?>
    </div>
	
    <script type="text/javascript" src="js/js.js"></script>
    <?php
include("footer.php");
?>
   
</body>
</html>
    <script type="text/javascript" src="../js/js.js"></script>
</body>
</html>