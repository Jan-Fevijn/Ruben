<?php 
if (isset($_POST['EURO'])) {
 //   echo($_POST['EURO']);
    if (isset($_SESSION['geldinworp'])) {
        $_SESSION['geldinworp'] = $_SESSION['geldinworp'] + $_POST['EURO'] ;
        $geldinworp =$_SESSION['geldinworp'] ;
    } else {
        $_SESSION['geldinworp'] = $_POST['EURO'] ;
        $geldinworp =$_POST['EURO'] ;
    }
} else {
    if (isset($_SESSION['geldinworp'])) {
        $geldinworp = $_SESSION['geldinworp'] ;
       
    } else {
        $_SESSION['geldinworp'] = 0;
        $geldinworp = 0 ; 
    }
}
?>

<form method='POST' id='muntjes'>
<label id='lblgeldinworp'> <h2> geldinworp: </h2> </label> 
<label> <h2>  <?php  echo($geldinworp); ?> </h2> </label> 



<input type='submit' class = "muntje" name='EURO' value="0.05">
<input type='submit' class = "muntje" name='EURO' value="0.10">
<input type='submit' class = "muntje" name='EURO' value="0.20">
<input type='submit' class = "muntje" name='EURO' value="0.50">
<input type='submit' class = "muntje" name='EURO' value="1.00">
<input type='submit' class = "muntje" name='EURO' value="2.00">
<input type='submit' class = "muntje"name='EURO' value="5.00">
<input type='submit' class = "muntje" name='EURO' value="10.00">

</form>