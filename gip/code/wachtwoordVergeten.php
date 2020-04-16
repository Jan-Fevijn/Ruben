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
include("footer.php");

if (isset($_POST['email'])) {
    $_SESSION["bericht"] = "";
    $yourmessage = "de registratiecode is ....";
    $jouwNaam = "";
    $naar = $_POST['email'];
    $onderwerp = 'registratiecode ARDUINOEDUCATIEF';
    $contact_submitted = 'Je bericht werd verstuurd.';
 
        $return = "\r";
        $jouwNaam = stripslashes(strip_tags($_POST['email']));
        $_SESSION["bericht"] = stripslashes(strip_tags($yourmessage));
        $contact_naam = "Name: ".$jouwNaam;
        $bericht_text = "Message: " . $_SESSION["bericht"];
      //  $user_answer = trim(htmlspecialchars($_POST['user_answer']));
      //  $answer = trim(htmlspecialchars($_POST['answer']));
        $bericht = $contact_naam . $return . $bericht_text;
        if ($jouwNaam != "" && $_SESSION["bericht"] != "" ) {
            include("/PHPMailer-master/src/PHPMailer.php");
            include("/PHPMailer-master/src/SMTP.php");
            include("/PHPMailer-master/src/Exception.php");
            $jouwNaam = '';
            $_SESSION["bericht"] = '';
            $mail = new PHPMailer();
            $mail->IsSMTP();
            $mail->Mailer = "smtp";
            $mail->SMTPDebug  = 0;  
            $mail->SMTPAuth   = TRUE;
            $mail->SMTPSecure = "tls";
            $mail->Port       = 587;
            $mail->Host       = "smtp.gmail.com";
            $mail->Username   = "sendmail@atheneumjanfevijn.be";
            $mail->Password   = "sendmail123!";
            $mail->IsHTML(true);
            $mail->AddAddress("sendmail@atheneumjanfevijn.be", "sendmail");
            $mail->SetFrom("no-replay@atheneumjanfevijn.be", "info");
            $mail->Subject = "Test";
            $content = "<b>" . $bericht . "</b>";
            
            $mail->MsgHTML($content); 
            if(!$mail->Send()) {
                echo "Fout bij het zenden van email.";
                var_dump($mail);
            } else {
                echo '<p style="color: green;"><strong>'.$contact_submitted.'</strong></p>';
            }
        }
        else echo '<p style="color: red;">Vul aub je naam, een geldig email addres, je bericht en het antwoord op het simpele rekenvraagje in voor het verzenden van je bericht.</p>';
    
    $number_1 = rand(1, 9);
    $number_2 = rand(1, 9);
    $answer = substr(md5($number_1+$number_2),5,10);
}
				
				
			
?>
   
</body>
</html>