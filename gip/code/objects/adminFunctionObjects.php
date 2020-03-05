<?php 
 class functie {
    public $name;
    public $imgPath;
    public $price;
   public $urlGoto;

   function set($name, $imgPath, $urlGoto, $imgBreed , $imgHoog) {
      $this->name = $name ;
      $this->imgPath = $imgPath;
      $this->urlGoto = $urlGoto;
      $this->imgBreed = $imgBreed;
      $this->imgHoog = $imgHoog;
   }
   function write() {
   echo(" <a href='" . $this->urlGoto. ".php' id='midden2' class='flexListOfAdminFunctionsItems'>");
   echo(" <h2> ". $this->name ."</h2> "); 
 
     echo(" <img  src='../../img/" . $this->imgPath ."' height='". $this->imgHoog."' width='". $this->imgBreed."' />");
  echo ("</a>");
   }

}
$functie = new functie;
?> 