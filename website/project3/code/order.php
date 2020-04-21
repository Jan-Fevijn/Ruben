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
   include("dbConn.php");
    if (isset($_POST['mb'])) {
       
        if(isset($_SESSION['machineNumber'])) {
            if ($_SESSION['machineNumber'] == 0) {
                $_SESSION['machineNumber'] = $_POST['mb'];
            } else {
                $_SESSION['machineNumber'] = $_SESSION['machineNumber'] . $_POST['mb'];
            }
        } else {
            $_SESSION['machineNumber'] = $_POST['mb'];
          
        }
           
      
    } else {
        $_SESSION['machineNumber'] = 0;
    }

    if (isset($_POST['c'])) {
        $_SESSION['machineNumber'] = 0;
    }
?>

    <form id = 'machineknoppen' method='POST'>
         <div id='machineNumber'>
         <?php
         if (isset($_SESSION['machineNumber'])) {
             echo($_SESSION['machineNumber']);
         }
         ?>
         </div>
         <input type='hidden' name='submited'>
         <input class='mb' type='submit' value='1' name='mb'>
         <input class='mb' type='submit' value='2' name='mb'>
         <input class='mb' type='submit' value='3' name='mb'>
         <input class='mb' type='submit' value='4' name='mb'>
         <input class='mb' type='submit' value='5' name='mb'>
         <input class='mb' type='submit' value='6' name='mb'>
         <input class='mb' type='submit' value='7' name='mb'>
         <input class='mb' type='submit' value='8' name='mb'>
         <input class='mb' type='submit' value='9' name='mb'>
         <input class='mb' type='submit' value='c' name='c'>
         <input class='mb'  type='submit' value='0' name='mb'>
    </form>

</body>
</html>