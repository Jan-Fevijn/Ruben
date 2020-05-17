<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../css/css.css" />
          <style>
            .listInMidden{
                padding-left :20%;
            }
           table {
                margin-left:20%;
            }
          </style>
</head>
<body>
<?php 
 $accType = "ADMIN";
 include("dbConnection.php");
 include("checkIfLogedIn.php");
 include("banner.php");
 ?>
<div id='container'>
 <table border='1'> 
 <!-------------  header                                           --->
<tr>
    <th>
        datum
    </th>
    <th>
        planning
    </th>
    <th>
        afgewerkt ?
    </th>
</tr>
 <!-------------  row 1                                           --->
<tr>
    <td>
        september
    </td>
    <td>
   
    <ul class='listInMidden'>
    <li>webserver  </li>
<li> de homepage (home.php)</li>
<li>onze service (ourService.php)</li>
<li>over ons (aboutUs.php)</li>
<li>contacteer ons  (contactUs.php)</li>
<li>registreer (registreer.php)</li>
<li>wachtwoord vergeten(wachtwoordVergeten.php)</li>
</ul>
    </td>
    <td>
       v
    </td>
</tr>
<!-------------------- row 2 ------------>
<tr>
    <td>
        oktober - november
    </td>
    <td>
    <ul class='listInMidden'>
  <li>  mysql database aanmaken</li>
  <li>verbinden met de website</li>
  <li>inlogsysteem koppelen (zonder betaalsysteem)</li>
</ul
    </td>
    <td>
        v
    </td>
</tr>


<!-------------------- row 3 ------------>
<tr>
    <td>
    december
    </td>
    <td>
    <ul class='listInMidden'>
    <li> inlogsysteem zonder betaalsysteem  </li>
    </ul>
    </td>
    <td>
       v
    </td>
</tr>
<!-------------------- row 4 ------------>
<tr>
    <td>
    januari
    </td>
    <td>
    <ul class='listInMidden'>
         <li>
              inlogsysteem zonder betaalsysteem , een admin kan instructies toevoegen  
        </li>
    </ul>
    </td>
    <td>
    
      v
   
    </td>
</tr>


<!-------------------- row 5 ------------>
<tr>
    <td>
    februari
    </td>
    <td>
         <ul class='listInMidden'>
    <li> oefeningen en instructies maken over arduino   </li>
    <li>betaalsysteem   </li>
    </ul>
    </td>
    <td>
        v
    </td>

</tr>


<!-------------------- row 6 ------------>
<tr>
    <td>
        maart - april
    </td>
    <td>
         <ul class='listInMidden'>
    <li> adminfuncties  </li>
    <li> leerkracht kan klassen aanmaken  </li>
    <li> leerkracht kan zijn eigen klassen zien  </li>
    <li> leerling kan oefeneningen maken / instructies bekijken </li>
    <li> leerkracht kan klassen aanmaken  </li>
    <li> debuging  </li>
    
    </ul>
    </td>
    <td>
       v
    </td>
</tr>

<!-------------------- row 7 ------------>
<tr>
    <td>
        mei - juni
    </td>
    <td>
         <ul class='listInMidden'>
         <li> debuging (indien nodig) </li>
         <li> planning op website plaatsen </li>
        <li> handleiding  </li>
       
    </ul>
    </td>
    <td>
        
    </td>
</tr>
 </table>
 </div >
 <?php
 include("footer.php");
 ?>
    
 </body>
 </html>