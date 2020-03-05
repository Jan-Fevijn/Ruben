<?php 
session_start();
$debug = false ;
if (isset($_POST['username'])) {
    echo("it is set  ");
    include("dbconn.php");
    $username = $_POST['username'];
    $password =  $_POST['password'];
    $sql = "SELECT * FROM user WHERE username = '$username' and password='$password' ";
    
    $result = $conn->query($sql);
    if ($result->num_rows > 0) {
    $row = $result->fetch_assoc();
    $_SESSION['iduser'] = $row['iduser'];
    if ($row['admin'] == 1) {
        header('location: admin.php ');
    } else {
        header('location: user.php ');
    }
    
  
    } else {
        header("location: index.php?msg='gebruikersnaam of paswoord is ongeldig.' ");
    }


}
?>