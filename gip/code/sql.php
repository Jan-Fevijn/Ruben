<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../../css/css.css" />
         
</head>
<body>
<?php 
include("dbConnection.php");
$accType= "ADMIN" ;
include("checkIfLogedIn.php");
include("banner.php");

echo("<div id='midden'> <a  href= 'admin.php'>back</a></div>");

?>

<form method='POST'> <br/>
<div id='midden'> voer sql query in  (geen select statments )<br>
<textarea rows="10" cols="100" type='text' name="sql"></textarea>
<br>
<input type='submit' name='sqll' value='qeury'>

</form>


<?php 

if(isset($_POST['sqll'])){
    $sql = $_POST['sql'];
    if ($conn->query($sql) === TRUE) {
     echo "<br/> query executed succesfully !!!!!!";
  } else {
     echo "<br/>Error: " . $sql . "<br>" . $conn->error;
  }
  
  
   }

   
      

$conn->close();
?>
<?php
include("footer.php");
?>
   
</div>
</body>
</html>