<?php 

if (strpos($value, "'") !== false) {
    $save = false ;
}



if ($save == false ) {
   $err = "je mag geen ', ... invoeren.";
}
?>