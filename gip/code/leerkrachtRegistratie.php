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
session_start();

$errors = array();
$errors = array();
	 $row = 0;
include("banner.php");
?>

   
    <div id="registreerContainer">


        <div id="regestratieVraag3">
           
          
        </div>
<div id="leerkrachtRegistratie">
<form method="post" action="leerkrachtRegistratie.php">

				
				<table border="1" id="registreerTable">
				<tr>
				<th  colspan="2">
				registreer
				</th>
				<td rowspan="6"></td>
				<th>
				voor welke formule ga je (voor je eerste klas)
				</th>
				</tr>

				<tr>
				<td>
				Email: 
				</td>
				<td>
				<input title='voer hier een geldig email adres in die nog niet in gebruik is.' class='input' name="email" type="email" value="" />
				</td>

				<td>
				 <input title='' value="freeTrail:" type="radio" name="formule">eerste 3 oefeningen gratis  voor 3 leerlingen 
				</td>
				</tr>

				<tr>
				<td>voornaam:
				</td>
				<td><input  title='voer hier u voornaam in' class='input' type="text" name="voornaam" value="" />
				</td>

				<td>
				<input  class='input' value="pay:" onselect="pay()" type="radio" name="formule">betaal 6 euro per klas (max 20 leerlingen) per schooljaar 
				</td>
				</tr>

				<tr>
				<td>familienaam:
				</td>
				<td><input  title='voer hier u famielinaam in' class='input' type="text" name="famielienaam" value=""/>
				</td>

				<td>
				 <input  class='input' type="radio" value="freeCode:" name="formule">voer een schoolregistratiecode in en krijg het volledige pakket gratis. Dit geldt alleen voor leerkrachten van Jan Fevijn. <br>  <input  title='voer hier de school code in indien je een leerkracht bent van JAN FEVIJN.' class='input' name="freeCode" type="numeric" >
				</td>
				</tr>

				<tr>
				<td>wachtwoord:
				</td>
				<td><input  title='voer hier u wachtwoord in, deze moet 8 tekens bevatten.' class='input' type="password" name="password1" value="" />
				</td>
				<td>klasnaam (voor je eerste klas) : <input  title='voer hier de klasnaam aan van de 1e klas die je wil toevoegen, je leerlingen kunnen dit zien. Als je geregistreerd bent kan je er altijd nog toevoegen (mits betaaling indien geen Jan Fevijn leerkracht.)' class='input' type="text" name="klasNaam" value="" />
				</td>
				</tr>
				
					
           	<tr>
				<td>herhaal uw wachtwoord:
				</td>
				<td><input  title='voer hier u wachtwoord in, deze moet identiek gelijk zijn aan het wachtwoord die je hier boven hebt ingevoerd' class='input' type="password" name="password2" value="">
				</td>
				<td>
					gelieve dit formulier in te vullen indien u nog <b> geen </b> account hebt .				</td>
				</tr>
				</table>
			
			
			<input class='input' type="submit" value="registreer" id="submid2" name="reg_user" />
            <br />  
				</form>

		
    </div>
	<?php
	


	// connect to the database
 include("dbConnection.php");
		$debug = false; 

// REGISTER USER
if (  isset($_POST['email']) and isset($_POST['password1']) and isset($_POST['password2']) and isset($_POST['voornaam']) and isset($_POST['famielienaam']) and isset($_POST['klasNaam']) ) {
if (isset($_POST['voornaam'])) {
  // receive all input values from the form
  $voornaam = mysqli_real_escape_string($conn, $_POST['voornaam']);
  $famielienaam = mysqli_real_escape_string($conn, $_POST['famielienaam']);
  $password1 = mysqli_real_escape_string($conn, $_POST['password1']);
  $password2 = mysqli_real_escape_string($conn, $_POST['password2']);
  $email = mysqli_real_escape_string($conn, $_POST['email']);
   $klasnaam = mysqli_real_escape_string($conn, $_POST['klasNaam']);
  // form validation: ensure that the form is correctly filled ...
  // by adding (array_push()) corresponding error unto $errors array
  if (strlen($password1) > 8) {
	
  
  if (empty($email)) { array_push($errors, "Email is required"); }
  if (empty($password_1)) { array_push($errors, "Password is required"); }

 
  $leerkrachten = "";

  if ($password1 == "") { echo("geef een wachtwoord in"); } else {
  	$password = md5($password1);//encrypt the password before saving in the database

	// look for eatch radio butten is selected, for the pay
	if (isset($_POST['formule'])) {
	$answer = $_POST['formule']; 
	
	// check eatch formule you chosed 
	$ok = true ;
if ($answer == "freeCode:") {   
if ($_POST['freeCode'] == "janfevijnx") {
 $formule = 3;
if ($debug) echo("the jan fevijn password was correct");
   }else {
   	   echo ("voer de juiste jan fevijncode in. als je geen leerkrach van de school jan fevijn (in brugge, assebroek) kun je dit niet doen<br>" );
	   $ok = false ;
   }   
} 
if  ($answer == "pay:")  {
   $formule = 1;
}
if ($answer == "freeTrail:")  {
   $formule = 2;
}

if ($ok == true) {
  	$query = "INSERT INTO leerkrachten (naam, famielienaam, wachtwoord, email, actief)  VALUES ('$voornaam', '$famielienaam', '$password', '$email' ,1)";
	
  if(mysqli_query($conn, $query)) {
  


	
  	$_SESSION['voornaam'] = $voornaam;
  	$_SESSION['success'] = "You are now logged in";
	$sql = "SELECT idleerkrachten FROM leerkrachten WHERE email= '$email'";
	$result = $conn->query($sql);
	$ide = $result->fetch_assoc();
	$id = $ide['idleerkrachten'];
	 if ($debug)  echo($id);


	if ($ok == true) {
	$code = rand(100000,1000000);
  	$query = "INSERT INTO klas (code, klasnaam, idleerkracht,formule)  VALUES ('$code', '$klasnaam', '$id','$formule')";
	
  if(mysqli_query($conn, $query)) {
  
   echo "Records added successfully.";
} else{
    echo "u kunt niet registreeren, het email adres is moogelijk in gebruik , of er is een andere fout opgetreeden." ;
}
$_SESSION['id'] = $id ;
if ($debug) {

}else {
	if ($formule == 1) {
	// pay ----------------------------------------
	$_SESSION['voornaam'] = $_POST['voornaam'];
	$_SESSION['famielienaam'] = $_POST['famielienaam'];
	$_SESSION['password'] = $_POST['password1'];
	$_SESSION['email'] = $_POST['email'];
	$_SESSION['klasNaam'] = $_POST['klasNaam'];
	$_SESSION['accType'] = "leerkracht" ;
	$_SESSION['formulle'] = 1;
	 header('location: pay/pay.php ');  

	} else {
	
		header('location: leerkrachten.php '); 
	}
 
}
                         
}
  // verwijzing site 


  
  if ($debug) echo "Records added successfully.";
} else{
	// controlleeren of het e-mailadres al in gebruik is 
	if (strpos(mysqli_error($conn), 'email_UNIQUE') !== false) {
		echo("het ingegeven e-mailadres is al in gebruik.");
	} else {

	
	echo "ERROR: Could not able to execute $query. " . mysqli_error($conn);
	}
}


}  else {
  	  echo("je moet wel een formule kiezen");
  }
  } 

 
  }
}else {
	echo("je wachtwoord moet 8 tekens bevatten");
	}
} 

  }
  
	?>
	
	<?php
include("footer.php");
?>
   
	
</body>
</html>