<html lang="en" xmlns="http://www.w3.org/1999/xhtml"><head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css.css">

    <style>
    .flexItam {
        background-color: unset;
    }
    </style>
</head>
<body>

<?php 
include("dbconn.php");
include("checkIfLogedIn.php");
include("banner.php");
?>
<div class='flexbox'>

<form class='flexItam' method='POST'>
<h3> event toevoegen </h3>

</form>

<form class='flexItam' method='POST'>
<h3> event wijzigen </h3>
</form>

<form class='flexItam' method='POST'>
<h3> event verwijderen </h3>
</form>



<form class='flexItam' method='POST'>
<h3> gerecht toevoegen </h3>
</form>

<form class='flexItam' method='POST'>
<h3> gerecht wijzigen </h3>
</form>

<form class='flexItam' method='POST'>
<h3> gerecht verwijderen </h3>
</form>
</div>
<h2> 
</body>
</html>