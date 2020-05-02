<?php
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
       if (isset($_SESSION['machineNumber'])) {
        
       } else {
        $_SESSION['machineNumber'] = 0;
       }
     
   }

   if (isset($_POST['c'])) {
       $_SESSION['machineNumber'] = 0;
   }
?>

   <form id = 'machineknoppen' method='POST' action='
   
   <?php 
   if (isset($_SESSION['usercode'])) {
    echo("order.php");
} else {
    echo("contant.php");
}
   ?>
  ' >
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
        <input class='order'  type='submit' value='bestellen' name='order'>
   </form>
