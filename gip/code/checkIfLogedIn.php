<?php 
if (isset($s)) { 

} else {
  session_start();
}

if (isset($_SESSION['id'])){
    $debug = false ;
  if ($debug)  echo($_SESSION["id"]);
    $id = $_SESSION["id"];
}else {
    //echo("id not found");
}
?>