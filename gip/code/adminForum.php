<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../css/css.css" />
          <script src="https://cdn.ckeditor.com/4.9.2/standard/ckeditor.js"></script>  
          <script src="http://YOUR-DOMAIN/YOUR-DIRECTORY/textboxio/textboxio.js"></script>
          <script src="../js/textboxio.js"></script>
          <style>
                .invisible {
                    border: 0px;
                }
                h3 {
                    font-size:180%;
                }
          </style>
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
<div id='midden'> voeg zelf een bericht toe.<br>
<textarea name="editor1"></textarea>


<br>
<input type='submit' name='submit' value='verzenden'>
</form>


<script>  
    CKEDITOR.replace('editor1');  
    
  
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


if(isset($_POST['editor1'])){
  $sql = "INSERT INTO `dbarduinoeducatief`.`adminforum` ( `bericht`, `idAdmin`) VALUES ( '".$_POST['editor1']."', '$id')";
  if ($conn->query($sql) === TRUE) {
  if($debug) echo "New record created successfully";
} else {
   echo "Error: " . $sql . "<br>" . $conn->error;
}


 }


 $sql = "SELECT * FROM adminForum inner join admin order BY idBericht  DESC";
 if($result = mysqli_query($conn, $sql)){
  if(mysqli_num_rows($result) > 0){
      echo "<table class='invisible'>";
        
      while($row = mysqli_fetch_array($result)){
          echo "<tr class='invisible'>";
              echo "<tr class='invisible'> <th class='invisible' > <h3>" .  $row['naam'] ." ".$row['famielienaam']. "</h3></th> </tr>";
              echo "<tr class='invisible'> <td class='invisible'>" . $row['bericht'] . " </td> </tr>";
             
          echo "</tr>";
      }
      echo "</table>";

 
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