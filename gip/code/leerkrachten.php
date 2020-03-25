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
   try {
   include("checkIfLogedIn.php");
   $accType= "leerkracht";
   include("banner.php");
   } catch (Expection $e){
		if (isset($_SESSION['id'])) {
			
		} else {
			if (isset($_SESSION['voornaam'])) {
				  // account not made yet 
				 $voornaam = $_SESSION['voornaam'];
				 $famielienaam = $_SESSION['famielienaam'];
				 $password = md5($_SESSION['password']);
				 $email = $_SESSION['email'];
				 $klasNaam = $_SESSION['klasNaam'];
				 $formulle = $_SESSION['formulle'];


				 // maak acc aan 

				 if ($ok == true) {
					$query = "INSERT INTO leerkrachten (naam, famielienaam, wachtwoord, email)  VALUES ('$voornaam', '$famielienaam', '$password', '$email')";
				  
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

			}
		

		} else {
			if(  (strpos(mysqli_error($conn), 'email'))   ) {
				echo (" het emailadres is al in gebruik ");
			 } else {
			 echo "ERROR: Could not able to execute $query. " . mysqli_error($conn);
			 }
		}
   }
} 
		}
	}



    ?>

   

    <div id="instructie2">
	<h2>klassen: </h2>
        <table border="1">
            <tr>
                <th>
				klasnaam
                    
                </th>
                <th>
				klasCode (Geef die aan alle leerlingen in je klas. Dit hebben ze nodig om in te loggen.)
                </th>
				 <th>
				formule
                </th>
				
            </tr>
			<?php 

			// get the klas data
					$sql2 ="SELECT * FROM klas WHERE idleerkracht = '$id'";
					
					
					  $result2 = $conn->query($sql2);

			 while($row2 = $result2->fetch_assoc()){
				$klasid = $row2['idklas'];
			 echo ("<tr> <td> <a href='leerlingVieuw.php?id=$klasid' > ". $row2["klasnaam"] . "</a> </td> <td>" . $row2["code"] . "</td> " );
			if ($row2["formule"] == 3) {
			echo ("<td> janfevijn leerkracht </td> </tr>");
			}
			if ($row2["formule"] == 2) {
			echo ("<td> free trial  </td> </tr>");
			}
			if ($row2["formule"] == 1) {
			echo ("<td> betaalde klas  </td> </tr>");
			}
			
			 }
			 $conn->close();
			 ?>
        </table>
		<?php 
		echo ("    <form method='POST' action='addClass.php'> ");
                                echo(" <input type='text' style='display: none' name='id' value='$id'  >");
                                echo("  <input class='nextBut' type='submit' value='maak nieuwe klas aan'> "); ?>
    </div>
	<?php
include("footer.php");
?>
   
</body>
</html>