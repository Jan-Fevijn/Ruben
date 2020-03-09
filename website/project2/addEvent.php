<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>kooken voor groepen</title>
    <link rel="stylesheet" type="text/css" href="css.css">
    <style>
    h2 {
        font-size:180%;
    }
    label {
        display: block;
        text-align: center;
    }
    input {
        display: block;
        margin-left:42%;
    }
    </style>
</head>
<body>
    <?php
    include("dbconn.php");
    include("checkIfLogedIn.php");
    include("banner.php");
    
    ?>
    <h2> event toevoegen </h2>
   
        <form>
        <label for='naam'>naam</lablel>
        <input type='text' id='naam' name='naam'>
    <label for='dateVan'> van </lablel>
    <input type='datetime-local' id='dateVan' name='dateVan'>
<label for='dateTot'> tot </lablel>
<input type='datetime-local' id='dateTot' name='dateTot'>
<label for='img'> url afbeelding </lablel>
<input type='text' id='img' name='img'>
<label for='idGerecht'> id gerecht geschijden door een koma <br>(indien gerecht al toegevoegd is) </lablel>

<input type='text' id='idGerecht' name='idGerecht'>
       
        </form>
    
</body>
</html>