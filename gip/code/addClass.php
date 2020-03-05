<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../../css/css.css" />
</head>
<body>
<?php
include("checkIfLogedIn.php");
include("dbConnection.php");
$accType = "leerkracht";
include("banner.php");
                   
				
			?>
	<h2> maak een nieuwe klas aan </h2> 
	<form action="addClass.php" method="post">
    klasnaam: <input type="text" name="klasnaam"> <br>
	<input value="pay"  type="radio" name="formule">betaal 6 euro per klas (max 20 leerlingen) per schooljaar <br>
	 <input type="radio" value="freeCode" name="formule">voer een schoolregistratiecode in en krijg het volledige pakket gratis. Dit geldt alleen voor leerkrachten van Jan Fevijn. <br>  <input name="freeCode" type="numeric" > <br>
     <input type='text' style='display: none' name='id' value='<?php echo($id); ?>'  >
	 <input type="submit" value="verzenden" >
		</form>	 
       
        
       
<?php 
$ok = true;
if (isset($_POST['klasnaam']) and  isset($_POST['formule'])) {
$answer = $_POST['formule']; 
if ($answer == "freeCode") {   
if ($_POST['freeCode'] == "janfevijnx") {
 $formule = 3;
 echo("the jan fevijn password was correct");
   }else {
   	   echo ("Voer de juiste jan fevijncode in. Als je geen leerkracht bent van de school Jan Fevijn (in Brugge, Assebroek), kun je dit niet doen!<br>" );
	   $ok = false ;
   }   
}
elseif ($answer == "pay")  {
   $formule = 1;
}
if ($ok) {


	$code = rand(100000,1000000);
	$klasnaam = $_POST['klasnaam'];
  	$query = "INSERT INTO klas (code, klasnaam, idleerkracht,formule)  VALUES ('$code', '$klasnaam', '$id','$formule')";
	
  if(mysqli_query($conn, $query)) {
  
   echo "Records added successfully.";
   $_SESSION["id"] = $id ;

    if ($formule == 1) {
      $_SESSION['makeKlas'] = true ;
      $_SESSION['klasNaam'] = $klasnaam;
      header('location: pay/pay.php' );
    } else {
   header('location: leerkrachten.php' );
    }              
} else{
    echo "ERROR: Could not able to execute $query. " . mysqli_error($conn);
}
  }
}


?>
<?php
include("footer.php");
?>
   
</body>
</html>