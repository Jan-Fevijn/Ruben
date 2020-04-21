<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
    #machineknoppen {
        width:20%;
        position: fixed;
        top:0;
        left:80%;
    }
    #machineNumber {
        background-color: lightgray; 
    }
    .mb {
        width : 32%;
        height: 10%;
        margin-top: 2px;
    }
    #mb0 {
        margin-left:32%;
    }
    </style>
</head>
<body>
<?php 

?>

    <form id = 'machineknoppen' method='POST'>
         <div id='machineNumber'>10</div>
         <input class='mb' type='submit' value='1' name='mb1'>
         <input class='mb' type='submit' value='2' name='mb2'>
         <input class='mb' type='submit' value='3' name='mb3'>
         <input class='mb' type='submit' value='4' name='mb4'>
         <input class='mb' type='submit' value='5' name='mb5'>
         <input class='mb' type='submit' value='6' name='mb6'>
         <input class='mb' type='submit' value='7' name='mb7'>
         <input class='mb' type='submit' value='8' name='mb8'>
         <input class='mb' type='submit' value='9' name='mb9'>
         <input class='mb' id='mb0' type='submit' value='0' name='mb0'>
    </form>

</body>
</html>