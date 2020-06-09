<?php 
            //€10
$sql = "SELECT sum(transactie) as amount FROM bakerijpol.muntjes where value = 10 ;";
$result = $conn->query($sql);
    while($row = $result->fetch_assoc()) {
        $m10 = new muntje;
        $amount = $row['amount'] / 10;
        $m10->set(10,$amount);
    }

                //€5
$sql = "SELECT sum(transactie) as amount FROM bakerijpol.muntjes where value = 5 ;";
$result = $conn->query($sql);
    while($row = $result->fetch_assoc()) {
        $m5 = new muntje;
        $amount = $row['amount'] / 5;
        $m5->set(5,$amount);
    }


                //€2
$sql = "SELECT sum(transactie) as amount FROM bakerijpol.muntjes where value = 2 ;";
$result = $conn->query($sql);
    while($row = $result->fetch_assoc()) {
        $m2 = new muntje;
        $amount = $row['amount'] / 2;
        $m2->set(2,$amount);
    }


                //€1
$sql = "SELECT sum(transactie) as amount FROM bakerijpol.muntjes where value = 1 ;";
$result = $conn->query($sql);
    while($row = $result->fetch_assoc()) {
        $m1 = new muntje;
        $amount = $row['amount'] / 1;
        $m1->set(1,$amount);
    }

                //€0.5
$sql = "SELECT sum(transactie) as amount FROM bakerijpol.muntjes where value = 0.5 ;";
$result = $conn->query($sql);
    while($row = $result->fetch_assoc()) {
        $m050 = new muntje;
        $amount = $row['amount'] / 0.5;
        $m050->set(0.5,$amount);
    }

                //€0.2
$sql = "SELECT sum(transactie) as amount FROM bakerijpol.muntjes where value = 0.2 ;";
$result = $conn->query($sql);
    while($row = $result->fetch_assoc()) {
        $m020 = new muntje;
        $amount = $row['amount'] / 0.2;
        $m020->set(0.2,$amount);
    }

                //€0.1
$sql = "SELECT sum(transactie) as amount FROM bakerijpol.muntjes where value = 0.1 ;";
$result = $conn->query($sql);
    while($row = $result->fetch_assoc()) {
        $m010 = new muntje;
        $amount = $row['amount'] / 0.1;
        $m010->set(0.1,$amount);
    }
                //€0.05
$sql = "SELECT sum(transactie) as amount FROM bakerijpol.muntjes where value = 0.05 ;";
$result = $conn->query($sql);
    while($row = $result->fetch_assoc()) {
        $m005 = new muntje;
        $amount = $row['amount'] / 0.05;
        $m005->set(0.05,$amount);
    }
                    //€0.02
$sql = "SELECT sum(transactie) as amount FROM bakerijpol.muntjes where value = 0.02 ;";
$result = $conn->query($sql);
    while($row = $result->fetch_assoc()) {
        $m002 = new muntje;
        $amount = $row['amount'] / 0.02;
        $m002->set(0.02,$amount);
    }

                //€0.01
$sql = "SELECT sum(transactie) as amount FROM bakerijpol.muntjes where value = 0.01 ;";
$result = $conn->query($sql);
    while($row = $result->fetch_assoc()) {
        $m001 = new muntje;
        $amount = $row['amount'] / 0.01;
        $m001->set(0.05,$amount);
    }

   
?>