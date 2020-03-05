<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet" type="text/css" href="css.css">
</head>
<body>
<div id='login' class="midden" >
<form method='POST' action='singUp.php'>
<h1> sing up : </h1>
<h2> username: <input type='text' name='username' > </h2>
<h2> voornaam: <input type='text' name='voornaam' > </h2>
<h2> naam: <input type='text' name='naam' > </h2>
<h2> password: <input type='password' name='password1' > </h2>
<h2> repeat your password: <input type='password' name='password2' > </h2>
<input type="radio" id='vegitaris' name='ex' value='1'> vegitaris <input type="radio" id='veganistisch' name='ex' value='0'> veganistisch <input type="radio" id='geen' name='ex' value='3'> geen van bijde  <br>
<input type='submit' name='singIn' value='registreer' id="loginSubmit" > <br> 

</from> 

<?php 
session_start();
$debug = false;
include("dbConn.php");
if (isset($_POST['username'])) {
    $username = $_POST['username'];
    $voornaam = $_POST['voornaam'];
    $naam = $_POST['naam'];
  $password1 =  $_POST['password1'];
  $password2 = $_POST['password2'];
  if ($password1 == $password2) {
       if ($debug) echo("redy to insert");
if (isset($_POST['ex'])){
  $ex = $_POST['ex'];
 if ($ex == 1) {
    $vegitarisch = 1;
    $veganistisch = 0;
 } else if ($ex == 0) {
    $vegitarisch = 0;
    $veganistisch = 1;
 } else {
    $vegitarisch = 0;
    $veganistisch = 0;
 }

} else {
 $vegitarisch = 0;
 $veganistisch = 0;
}
$sql = "INSERT INTO user (voornaam,naam, password,vegan,veganistisch,admin,username ) VALUES ('$voornaam','$naam', '$password1',$vegitarisch,$veganistisch,0,'$username')";

if ($conn->query($sql) === TRUE) {
    if ($debug)  echo "New record created successfully";

    $sql = "SELECT iduser FROM user WHERE username = '$username'";
    $result = $conn->query($sql);
    $row = $result->fetch_assoc();

    $_SESSION['iduser'] = $row['iduser'];
    echo($_SESSION['iduser']);
   
    header('location: user.php ');

} else {
  if ($debug)  echo "Error: " . $sql . "<br>" . $conn->error;
   if (strpos($conn->error , "'username_UNIQUE'")){
       echo("the username  " . $username . " is already taken. ");
   }
}
  } else {
      echo("the passworts are not equal");
  }
  
}

?>
</div>
</body>
</html>