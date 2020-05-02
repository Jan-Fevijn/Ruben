<?php 
 class muntje {
    public $value;
    public $amount;
    
   function set($value, $amount) {
      $this->value = $value ;
      $this->amount = $amount;  
   }
   function getAmount() {
    return($this->amount);
   }
}


?>