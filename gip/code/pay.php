<!DOCTYPE HTML>
<html lang="nl">

<head>
    <meta charset="utf-8" />
    <title>Bestelformulier game</title>
</head>
<body>
<?php
include("bannerphp");
 session_start();
if (isset($_SESSION['id'])){
    echo($_SESSION["id"]);
    $id = $_SESSION["id"];
}else {
    echo("id not found");
}
?>
 paypal:
<form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top">
<input type="hidden" name="cmd" value="_s-xclick">
<input type="hidden" name="hosted_button_id" value="LTJV5HH286ZXJ">
<input type="image" src="https://www.paypalobjects.com/en_US/i/btn/btn_buynowCC_LG.gif" border="0" name="submit" width="200" height="100" alt="PayPal - The safer, easier way to pay online!">
<img alt="" border="0" src="https://www.paypalobjects.com/en_US/i/scr/pixel.gif">
</form>


<?php
include("footer.php");
?>
   
</body>
</html>