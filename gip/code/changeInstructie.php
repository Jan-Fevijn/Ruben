<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <script src="https://cdn.ckeditor.com/4.9.2/standard/ckeditor.js"></script>  
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../../css/css.css" />
          <script src="http://YOUR-DOMAIN/YOUR-DIRECTORY/textboxio/textboxio.js"></script>
		<script src="../js/textboxio.js"></script>
      
          <style >
          #mytextarea {
    margin:10px 0;
    height:200px;
}
</style>
</head>
<body>
<?php
include('checkIfLogedIn.php');
include("dbConnection.php");
$accType = "ADMIN";
include("banner.php");
echo(" <div id='midden' ><a  href= 'admin.php' > back</a> <br/> </div> ") 
?>
<form method="POST">
id :
<input type='text' name='id'> 
<input type="submit" value="toon instructie / oefening">
</form>

<form method='POST'>
<textarea name="editor1"> 

<?php  
if (isset($_POST['id'])) {
    $idOef = $_POST['id'];
    
    $sql = "SELECT * FROM oefeningen WHERE idoefeningen='$idOef'";
    $result = $conn->query($sql);
    $row = $result->fetch_assoc();
    echo($row['bodyDeel1']);
    $_SESSION['idOef'] = $idOef ;
}
?>

</textarea><br/>  
<input type='submit' value='change instructie'>
</form>

<?php 
if (isset($_POST['editor1'])) {
    if (isset($_SESSION['idOef'])) {
        $body = $_POST['editor1'];
        $idOef = $_SESSION['idOef'];
        $sql = "UPDATE `dbarduinoeducatief`.`oefeningen` SET `bodyDeel1` = '$body ' WHERE (`idoefeningen` = '$idOef')";
        if ($conn->query($sql) === TRUE) {
            echo $idOef;
            echo $body;
        } else {
            echo "Error updating record: " . $conn->error;
        }
    } else {
        echo("gelieve het id van de oefening in te geven");
    }
   
}
?>
  <script>  
    CKEDITOR.replace('editor1');  
    CKEDITOR.replace('editor2');  
  
    function getData() {  
        //Get data written in first Editor   
        var editor_data = CKEDITOR.instances['editor1'].getData();  
        //Set data in Second Editor which is written in first Editor  
        CKEDITOR.instances['editor2'].setData(editor_data);  
    }  
    
</script>  

					
				   
				     <script type="text/javascript">
    var editor = textboxio.replace('#mytextarea');
  </script>
  <?php
include("footer.php");
?>
   
</body>
</html>