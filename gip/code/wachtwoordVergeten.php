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
include("banner.php")
 session_start();
if (isset($_SESSION['id'])){
    echo($_SESSION["id"]);
    $id = $_SESSION["id"];
}else {
    echo("id not found");
}
?>
    <br /><br /><br /><br /><br /><br />
    <div>
        <h2>Email:</h2> <div id="midden">
    <input type="email" size="30" id="EmailF" /> <br /> <br />
    <input id="EmailF" type="submit" size="500" /><br /> <a href="../home.php" id="EmailF">home</a>

</div> 
    </div>
    <?php
include("footer.php");
?>
   
</body>
</html>