<?php 
    if (isset($accType) === false ) {
        if (isset($_SESSION['accType'])) {
            $accType = $_SESSION['accType'];
          //  echo($accType);
          //  echo("dddd");
        } 

    }
        if (isset($_SESSION['id']) and isset($accType)) {
 echo ("<div id='banner'>");
 $id = $_SESSION['id'];

if ($accType == "ADMIN"){
    $result = mysqli_query($conn,"SELECT * FROM admin WHERE idadmin = '$id'");
} else if ($accType == "leerling"){
    $result = mysqli_query($conn,"SELECT * FROM leerlingen WHERE idleerlingen = '$id'");
} else if ($accType == "leerkracht"){
    $result = mysqli_query($conn,"SELECT * FROM leerkrachten WHERE idleerkrachten = '$id'");
    
}
echo("</div>");
$_SESSION['accType'] = $accType;
    
$row = $result->fetch_assoc();

echo("<div id='banner'> <h1>ARDUINO EDUCATIEF</h1> ");
echo ("<a id='naamInBanner' href='profiel.php' >". $row['naam'] ." ". $row['famielienaam'] . "</a>" ); 
echo("<a id='logoutInBanner' href='../index.php'> uitloggen </a> ");
      

// home button 
     echo("  <a href='");
if ($accType == "ADMIN") {
    echo("admin.php");
}
if ($accType == "leerling") {
    echo("oefeningen.php");
}

if ($accType == "leerkracht") {
    echo("leerkrachten.php");
}

      
       
   echo(" 'id='bannerBut'>home</a>");
     echo("  <a href='ourService.php' id='bannerBut'>onze service</a>");
     echo("  <a href='aboutUs.php' id='bannerBut'>over ons</a>");
      echo(" <a href='contactUs.php' id='bannerBut'>contacteer ons</a>");

  echo(" </div>");
} else {
    
    if (isset($index)) {
       
      echo("  <div id='banner'>");
      echo("  <h1>ARDUINO EDUCATIEF</h1>");
      echo("<a id='logoutInBanner' href='code/login.php'> inloggen </a> ");
      echo("  <a href='index.php' id='bannerBut'>Home</a>");
      echo("  <a href='code/ourService.php' id='bannerBut'>Onze service</a>");
      echo("  <a href='code/aboutUs.php' id='bannerBut'>Over ons</a>");
      echo(" <a href='code/contactUs.php' id='bannerBut'>Contacteer ons</a>");

   echo(" </div>");
    } else {
  echo("  <div id='banner'>"); 
      echo("  <h1>ARDUINO EDUCATIEF</h1><br />");
      echo("<a id='logoutInBanner' href='login.php'> inloggen </a> ");
       echo(" <a href='../index.php' id='bannerBut'>home</a>");
      echo("  <a href='ourService.php' id='bannerBut'>onze service</a>");
      echo("  <a href='aboutUs.php' id='bannerBut'>over ons</a>");
       echo(" <a href='contactUs.php' id='bannerBut'>contacteer ons</a>");
   echo(" </div>");
    }
    
}



   ?>