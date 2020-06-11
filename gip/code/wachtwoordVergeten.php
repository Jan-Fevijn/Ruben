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
include("dbConnection.php");
include("banner.php");
 session_start();

?>
    <br /><br /><br /><br /><br /><br />
    <div> <form method='POST'>
        <h2>Email:</h2> <div id="midden">
    <input type="email" name='email' size="30" id="EmailF" /> <br /> <br />
    <input id="EmailF" type="submit" size="500" /><br /> <a href="../home.php" id="EmailF">home</a>

</div> 
    </div>
    <?php
//include("footer.php");



        // send email
use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception; 
require("PHPMailer-master/src/Exception.php");
require("PHPMailer-master/src/PHPMailer.php");
require("PHPMailer-master/src/SMTP.php");



    // create verevication code
if (isset($_POST['email'])) {
    $email = $_POST['email'];
$xx = 0;
   
        $number_1 = rand(1, 9);
        $number_2 = rand(1, 9);
        $answer = substr(md5($number_1+$number_2),5,10);
      $_SESSION['verivicatiecode'] = $answer;
      $_SESSION['email'] = $_POST['email'];
   
        // send email

    $bericht = "uw verificatiecode is : $answer ";
    $jouwNaam = "Ruben";
    $naar = $_POST['email'];
    $onderwerp = "uw verificatiecode is : $answer ";
    $contact_submitted = 'Je bericht werd verstuurd.';
 
        $return = "\r";
        $jouwNaam = stripslashes(strip_tags($_POST['email']));
     
        $contact_naam = "Name: ".$jouwNaam;
        
        $bericht_text = "Message: " .$bericht;
        if ($jouwNaam != "" && $bericht != "" ) {
            $jouwNaam = '';
            $mail = new PHPMailer();
            $mail->IsSMTP();
            $mail->Mailer = "smtp";
            $mail->SMTPDebug  = 0;  
            $mail->SMTPAuth   = TRUE;
            $mail->SMTPSecure = "tls";
            $mail->Port       = 587;
            $mail->Host       = "smtp.gmail.com";
            $mail->Username   = "rubenaspeslag@atheneumjanfevijn.be";
            $mail->Password   = "pcNert20012001";
            $mail->IsHTML(true);
            $mail->AddAddress($_POST['email'], "rubenaspeslag");
            $mail->SetFrom("no-replay@atheneumjanfevijn.be", "ARDUINOEDUCATIEF");
            $mail->Subject = $onderwerp;
            $content = "<b>" . $bericht . "</b>";
            
            $mail->MsgHTML($content); 
            if(!$mail->Send()) {
                echo "gelieve een geldig e-mailadres in te geven.<br>";
                var_dump($mail);
            } else {
               // echo '<p style="color: green;"><strong>'.$contact_submitted.'</strong></p>';
               header('Location: emailverification.php');
            }
        }
        else echo '<p style="color: red;">Vul aub je naam, een geldig email addres, je bericht en het antwoord op het simpele rekenvraagje in voor het verzenden van je bericht.</p>';
    
    $number_1 = rand(1, 9);
    $number_2 = rand(1, 9);
    $answer = substr(md5($number_1+$number_2),5,10);
  //  echo("<br> $answer");
}

				
				
			
?>
   
</body>
</html>