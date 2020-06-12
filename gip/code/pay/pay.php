<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../../css/css.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
</head>
<body>
<div id="banner">
        <h1>arduino educatief</h1><br />
        <a href="../../index.php" id="bannerBut">home</a>
        <a href="../ourService.php" id="bannerBut">onze service</a>
        <a href="../aboutUs.php" id="bannerBut">over ons</a>
        <a href="../contactUs.php" id="bannerBut">contacteer ons</a>

    </div>
<?php session_start();  ?>
<div id='midden2'>
<table border='1' class= 'tableCenter'>

<h3>betalen: </h3>
<tr>
<th> betaalmethode </th>
<th> betaling starten </th> 
<th> extra informatie over de betaalmethode </th>
</tr>
<tr> 
<td>
 paypall : 
 </td>
 <td>
 <form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top">
<input type="hidden" name="cmd" value="_s-xclick">
<input type="hidden" name="hosted_button_id" value="DZ2Y8NFBBS54G">
<input type="image" src="https://www.paypalobjects.com/nl_NL/BE/i/btn/btn_buynowCC_LG.gif" border="0" name="submit" alt="PayPal, de veilige en complete manier van online betalen.">
<img alt="" border="0" src="https://www.paypalobjects.com/nl_NL/i/scr/pixel.gif" width="1" height="1">
</form>

</td>
<td>
betaal veilig en vlot met paypal , het maakt niet uit waar u shopt, uw bankgegevens worden nooit met de webshop gedeeld.
</td>
</tr>
</table>
</body>
</html>
