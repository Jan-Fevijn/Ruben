<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <title>koken voor groepen</title>
    <link rel="stylesheet" type="text/css" href="css.css">
</head>
<body>
<div id='login' class="midden" >
    <form method='POST' action='singIn.php'>
<h1> log in : </h1>
<h2> gebruikersnaam: <input type='text' name='username' > </h2>
<h2> wachtwoord: <input type='password' name='password' > </h2>
<input type='submit' name='singIn' value='log in ' id="loginSubmit" > <br> 
geen account ? <a href="singUp.php"> registreer </a> 
<?php 
 if (isset($_GET['msg'])) {
     echo("<br> error: ");
     echo($_GET['msg']);
 }

?>
</from> 
</div>
</body>
</html>