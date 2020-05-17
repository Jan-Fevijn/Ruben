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
                padding-left :5%;
            }
           table {
                margin-left:    10%;
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
       tijd
    </th>
</tr>



<!-------------------- row 1 ------------>
<tr>
    <td>
        september
    </td>
    <td>
         <ul class='listInMidden'>
    <li> webserver  </li>

    <li> de homepage (home.php)
    <li>onze service (ourService.php)
    <li>over ons (aboutUs.php)
    <li>contacteer ons  (contactUs.php)
    <li>registreer (registreer.php)
    <li>wachtwoord vergeten(wachtwoordVergeten.php)

    <li> een contact, login en registratie formulier die nog niet werkt. (nog geen background code) </li>
    <li> een banner  </li>
   
    <li>de homepage (home.php)</li>
    <li> onze service (ourService.php)</li>
    <li>over ons (aboutUs.php)</li>
    <li>contacteer ons  (contactUs.php)</li>

    <li>een inlogformulier die nog niet werkt </li>
    <li> bijna alle css voor alle websites zit in een file (css.css)</li>

    </ul>
    </td>
    <td>
        
    </td>
</tr>


<!-------------------- row 2 ------------>
<tr>
    <td>
    08/10/2019
    </td>
    <td>
         <ul class='listInMidden'>
    <li> My SQL databank aanmaken, en tables toevoegen   </li>
    </ul>
    </td>
    <td>
       3u
    </td>
</tr>

    <!-------------------- row 3 ------------>
<tr>
    <td>
    10/10/2019
    </td>
    <td>
         <ul class='listInMidden'>
    <li> deel leerkrachtenregistratie.php programmeren </li>
    
    <li>  link gemaakt naar databank, gegevens input</li>
<li> op te lossen problemen:<br>
 undefined variables (leerkrachten en password_1, line 100 en 112)  </li>
    </ul>
    </td>
    <td>
        3u
    </td>

</tr>

<!-------------------- row 4 ------------>
<tr>
    <td>
    4/11/2019
    </td>
    <td>
         <ul class='listInMidden'>
    <li> Instructie 1 en 2  </li>
    <li>  de banner voor wanneer je aan het oefenen bent. </li>
    <li> layout </li>
    </ul>
    </td>
    <td>
       3u
    </td>
</tr>


<!-------------------- row 5 ------------>
<tr>
    <td>
    5/11/2019
    </td>
    <td>
         <ul class='listInMidden'>
    <li> instructie 3 en 4  </li>
    </ul>
    </td>
    <td>
        3u
    </td>
</tr>


<!-------------------- row 6 ------------>
<tr>
    <td>
        6/11/2019
    </td>
    <td>
         <ul class='listInMidden'>
    <li> Instructie 5 en 6 maken </li> 
   
    <li>  het leerkrachtenregistratiesysteem debuggen<br> (werkt nog steeds niet) -->
     geen errors maar er komt niks in de database  </li>
    </ul>
    </td>
    <td>
      3u
    </td>
</tr>


<!-------------------- row 7 ------------>
<tr>
    <td>
    13/11/2019
    </td>
    <td>
         <ul class='listInMidden'>
    <li> addinstructie.php maken (is nog niet af) </li>
    <li> input velden plaatsen </li>
    <li>  layout 
    <li> zoeken naar een ritch text box  </li>
    </ul>
    </td>
    <td>
        2u
    </td>
</tr>
<tr>
    <td>
    14/11/2019
    </td>
    <td>
         <ul class='listInMidden'>
    <li> addinstructie.php maken (is nog niet af) </li>
    <li> input velden plaatsen </li>
    <li>  layout 
    <li> zoeken naar een ritch text box  </li>
    </ul>
    </td>
    <td>
        2u
    </td>
</tr>

<!-------------------- row 8 ------------>
<tr>
    <td>
    15/11/2019
    </td>
    <td>
         <ul class='listInMidden'>
    <li> leerkrachten registratiesysteem afgewerkt  </li>
    </ul>
    </td>
    <td>
        3u
    </td>
</tr>


<!-------------------- row 9 ------------>
<tr>
    <td>
    16/11/2019
    </td>
    <td>
         <ul class='listInMidden'>
    <li> leerkrachten.php gemaakt </li> 
   <li> leerkracht ziet  tabel met klassen die de leerkracht heeft aangemaakt  </li>
    </ul>
    </td>
    <td>
        4u
    </td>
</tr>



<!-------------------- row 10 ------------>
<tr>
    <td>
    december - januari- februari
    </td>
    <td>
         <ul class='listInMidden'>
    <li> inlogsysteem afgewerkt <li> 
    <li> een admin kan instructies toevoegen en wijzigen. <li>
     <li>  admin kan een lijst zien van alle leerlingen. <li>
      <li> admin kan  alle leerkrachten zien. <li>
      <li> admin forum <li>
      <li> admin kan de repords lezen (gebruikers kunnen die nu ook plaatsen) <li>
      <li>  admin kan een qeury uitvoeren . <li>
      <li>het betaalsysteem is nu ook al in orde .<li>
<li> leerlingen kunnen zien welke leerlingen in hun klassen zitten .</li>
  </li>
    </ul>
    </td>
    <td>
       +-20u
    </td>
</tr>






<tr>
    <td>
        25/03/2020
    </td>
    <td>
         <ul class='listInMidden'>
    <li> werken aan gebruiksaanwijzing  </li>
    <li> betaalsysteem aanpassen  </li>
    <li>debugging gebruiker activatiesysteem </li>
    </ul>
    </td>
    <td>
     
    </td>
</tr>






<tr>
    <td>
        26/03/2020
    </td>
    <td>
         <ul class='listInMidden'>
    <li> een leerling in een klas waarvoor de leerkracht <br> niet betaalt heeft , kan maar 3 instructies zien  </li>
    <li> een leerkracht die geen betaalde klassen bezit kan maar 3 instructies zien </li>
    </ul>
    </td>
    <td>
     
    </td>
</tr>


<tr>
    <td>
        27 - 31/03/2020 
    </td>
    <td>
         <ul class='listInMidden'>
    <li>gebruiker kan actief en inactief zijn + admin kan dit wijzigen </li>
    
    </ul>
    </td>
    <td>
     
    </td>


<tr>
    <td>
        01/04/2020 
    </td>
    <td>
         <ul class='listInMidden'>
    <li>spellingscorrectie website </li>
    <li> zoekfunctie in leerlingenBeheer.php  (enkel voor admins)  </li>
    <li> zoekfunctie in leerkrachtenBeheer.php  (enkel voor admins)  </li>
    </ul>
    </td>
    <td>
     
    </td>
</tr>



<tr>
    <td>
        16/04/2020 - 18/04/2020
    </td>
    <td>
         <ul class='listInMidden'>
    <li>wachtwoord vergeten met e-mail verificatie </li>
    
    </ul>
    </td>
    <td>
     
    </td>
</tr>




<tr>
    <td>
        17/05/2020 
    </td>
    <td>
         <ul class='listInMidden'>
    <li>planning op website plaatsen </li>
    <li> logboek op website plaatsen </li>
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