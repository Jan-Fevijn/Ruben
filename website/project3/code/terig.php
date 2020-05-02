<?php 
$terigString = "<br><br> je krijgt het volgende terug : <br> ";
include("classMuntje.php");
while ($terig - 0 ) {
    include("selectMuntjes.php");
    if ($terig >= 10 && $m10->getAmount() > 0 ) {
        $terig = $terig - 10;

        $sql = "INSERT INTO `bakerijpol`.`muntjes` (`value`, `transactie`) VALUES ('10', '-10');";
        include("execute.php");

        $terigString = $terigString ."- een briefje van €10 <br> ";
    } else if ($terig >= 5 && $m5->getAmount() > 0) {
        $terig = $terig - 5;

        $sql = "INSERT INTO `bakerijpol`.`muntjes` (`value`, `transactie`) VALUES ('5', '-5');";
        include("execute.php");

        $terigString = $terigString ."- een briefje van €5 <br>";
    }else if ($terig >= 2 && $m2->getAmount() > 0) {
        $terig = $terig - 2;

        $sql = "INSERT INTO `bakerijpol`.`muntjes` (`value`, `transactie`) VALUES ('2', '-2');";
        include("execute.php");

        $terigString = $terigString ."- een muntje van €2 <br> ";
    }else if ($terig >= 1 && $m1->getAmount() > 0) {
        $terig = $terig - 1;

        $sql = "INSERT INTO `bakerijpol`.`muntjes` (`value`, `transactie`) VALUES ('1', '-1');";
        include("execute.php");

        $terigString = $terigString ."- een muntje van €1 <br> ";
    }
    else if ($terig >= 0.5 && $m050->getAmount() > 0) {
        $terig = $terig - 0.5;
        $sql = "INSERT INTO `bakerijpol`.`muntjes` (`value`, `transactie`) VALUES ('0.5', '-0.5');";
        include("execute.php");
        $terigString = $terigString ."- een muntje van €0,5 <br> ";
    }
    else if ($terig >= 0.2 && $m020->getAmount() > 0 ) {
        $terig = $terig - 0.2;
        $sql = "INSERT INTO `bakerijpol`.`muntjes` (`value`, `transactie`) VALUES ('0.2', '-0.2');";
        include("execute.php");
        $terigString = $terigString ."- een muntje van €0,2 <br> ";
    }else if ($terig >= 0.1 && $m010->getAmount() > 0) {
        $terig = $terig - 0.1;
        $terigString = $terigString .":". 0.1;
        $terigString = $terigString ."- een muntje van €0,1 <br> ";
    }else if ($terig >= 0.05 && $m005->getAmount() > 0) {
        $terig = $terig - 0.05;
        $sql = "INSERT INTO `bakerijpol`.`muntjes` (`value`, `transactie`) VALUES ('0.05', '-0.05');";
        include("execute.php");
        $terigString = $terigString ."- een muntje van €0,05 <br> ";
    }else if ($terig >= 0.02 && $m002->getAmount() > 0) {
        $terig = $terig - 0.02;
        $sql = "INSERT INTO `bakerijpol`.`muntjes` (`value`, `transactie`) VALUES ('0.01', '-0.01');";
        include("execute.php");
        $terigString = $terigString ."- een muntje van €0,02 <br> ";
    }else if ($terig >= 0.01 && $m001->getAmount() > 0) {
        $terig = $terig - 0.01;
        $sql = "INSERT INTO `bakerijpol`.`muntjes` (`value`, `transactie`) VALUES ('0.01', '-0.01');";
        include("execute.php");
        $terigString = $terigString ."- een muntje van €0,01 <br> ";
    } else {
        $terigString = $terigString ."<br> er zit geen geld genoeg in het automaat om terig te geeven, je hebt nog €$terig tegoet, gelieve de bakker te contacteeren.<br>";
        $terig = 0;
    }


   // $terigString = $terig . " terig <br>";

}


        // the falowing code is only made to debug, and does nothing else 
$debug = true ;
if ($debug) {


$terigString = $terigString ." -in de bak zitten nog ". $m10->getAmount() . " van 10<br>";
$terigString = $terigString ." -in de bak zitten nog ". $m5->getAmount() . " van 5<br>";
$terigString = $terigString ." -in de bak zitten nog ". $m2->getAmount() . " van 2<br>";
$terigString = $terigString ." -in de bak zitten nog ". $m1->getAmount() . " van 1<br>";
$terigString = $terigString ." -in de bak zitten nog ". $m050->getAmount() . " van 50<br>";
$terigString = $terigString ." -in de bak zitten nog ". $m020->getAmount() . " van 0.20<br>";
$terigString = $terigString ." -in de bak zitten nog ". $m010->getAmount() . " van 0.10<br>";
$terigString = $terigString ." -in de bak zitten nog ". $m005->getAmount() . " van 0.05<br>";
$terigString = $terigString ." -in de bak zitten nog ". $m002->getAmount() . " van 0.02<br>";
$terigString = $terigString ." -in de bak zitten nog ". $m001->getAmount() . " van 0.01<br>";
}
?>