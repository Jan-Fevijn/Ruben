<html lang="en" xmlns="http://www.w3.org/1999/xhtml"><head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css.css">

    <style>
    .flexItam {
        background-color: unset;
    }
    a {
        color:black;
        text-decoration: none;
        font-size: 100%;
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
<a href='addEvent.php'> <h3> event toevoegen </h3></a>

</form>

<form class='flexItam' method='POST'>
<a href='changeEvent.php'> <h3> event wijzigen </h3></a>
</form>

<form class='flexItam' method='POST'>
<a href='deleteEvent.php'> <h3> event verwijderen </h3></a>
</form>



<form class='flexItam' method='POST'>
<a href='addGerecht.php'> <h3> gerecht toevoegen </h3></a>
</form>

<form class='flexItam' method='POST'>
<a href='changeGerecht.php'> <h3> gerecht wijzigen </h3></a>
</form>

<form class='flexItam' method='POST'>
<a href='deleteGerecht.php'> <h3> gerecht verwijderen </h3></a>
</form>
<form class='flexItam' method='POST'>
<a href='adminVieuws.php'> <h3> gerecht verwijderen </h3></a>
</form>
</div>
<h2> 
</body>
</html>