<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <!----- link boodstrap ----->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <style>
        label , input {
            display: block;
            

        }
    </style>
</head>
<body>

<?php 
include("code/dbConn.php");
?>
<div class='container pt-2'>
<div class='row'>
 
              <?php
                if (isset($_POST['idproduct'])) {
                    $idproduct = $_POST['idproduct'];
                    $prijs = $_POST['prijs'];
                    $vn = $_POST['voornaam'];
                    $fn = $_POST['naam'];

                    $sql = "SELECT * FROM buyers WHERE voornaam = '$vn' and famielinaam = '$fn' " ;
                    $result = $conn->query($sql);
                    if ($result->num_rows > 0) {
                        $row = $result->fetch_assoc();
                     $idbuyers =  $row['idbuyers'];
                } else {
                   $sql = " INSERT INTO `babylijst`.`buyers` (`voornaam`, `famielinaam`) VALUES ('$vn', '$fn') ";
                   if ($conn->query($sql) === TRUE) {
                //    echo "New record created successfully";
                  } else {
                    echo "Error: " . $sql . "<br>" . $conn->error;
                  }
                  $sql = "SELECT * FROM buyers WHERE voornaam = '$vn' and famielinaam = '$fn' " ;
                  $result = $conn->query($sql);
                  $row = $result->fetch_assoc();
                  $idbuyers =  $row['idbuyers'];
                


                }
              //  echo( $idbuyers);
                }         
                 ?>
                    
                         <form class='col-sm-3'  action='index.php'  method='POST'>
                         <label for='voornaam'> voornaam </label> 
                          <input id='voornaam' name='voornaam' type='text'>

                         <label for='naam'> naam </label> 
                         <input id='naam' name='naam' type='text'>

                          <label for='idproduct'> productnummer </label> 
                         <input id='idproduct' name='idproduct' type='text'>


                         <label for='prijs'> hoeveel wilt u hieraan spendeeren , indien u slechts een deel van de prijs geeft kan iemant anders de rest bijleggen of krijg je een kortingsbon ter waarde van het uitgegeven bedrag  </label> 
                         <input id='prijs' name='prijs' type='text'>


                       <input type='submit' >
                          </form>
                    <?php

               




       
      if (isset($idbuyers)) {
    $sql = "INSERT INTO `babylijst`.`orders` (`idbuyer`, `idproduct`, `prijs`) VALUES ('$idbuyers', '$idproduct', '$prijs')";   


if ($conn->query($sql) === TRUE) {
   // echo "New record created successfully";
  } else {
    echo "Error: " . $sql . "<br>" . $conn->error;
  }
      }
?>



<table border = '1' class='table table-hover table-bordered  col-sm-3'>
        <tbody>
           <tr>
           <th>
                productnummer
           </th>
           <th>
                productnaam
           </th>

           <th>
                prijs
           </th>
           </tr>



<?php 
               $sql = "SELECT * from products ";
               $result = $conn->query($sql);
               while($row = $result->fetch_assoc()) {

                $sql2 = "select sum(prijs) as betaald from orders where idproduct = " . $row['idproduct'] ;
            //    echo($sql);
                $result2 = $conn->query($sql2);
                $row2 = $result2->fetch_assoc();
              //  echo( "<br>"  .  $row2['betaald'] );
                if ($row2['betaald'] <  $row['prijs']) {
                    $toPay = $row['prijs'] - $row2['betaald'];
                    echo("<tr> <td> " . $row['idproduct'] ." </td> <td> " . $row['naam'] ." </td> <td>$toPay </td> </tr>" );
                }
               
              }
            ?>

            
        </tbody>
    </table> 
    </div>
</div>

</body>
</html>