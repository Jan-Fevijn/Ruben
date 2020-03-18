<!DOCTYPE html	  public     "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script src="https://cdn.ckeditor.com/4.9.2/standard/ckeditor.js"></script>  
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="../css/css.css" />
	<script src="http://YOUR-DOMAIN/YOUR-DIRECTORY/textboxio/textboxio.js"></script>
		<script src="../js/textboxio.js"></script>
		<style>
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
   
    <div id="instructie2">

        <table border='1'>
            <tr>
                <td>

                    <img src="../../img/instructie.png" height="50" width="50" />
                </td>
                <td id="instructie1">
                   

                   <form method="POST" action="addInstructie.php" >
                  id / oefening nummer <br>
                  <input name="id" >
				    <h2>titel: </h2>
					 <input name="tietel" type="text" size="30" font>

					 <br/> <br/> <br/> body : <br/> 
					 


<textarea name="editor1"></textarea><br/>  
<input type="submit" value="add instructie / oefening">
</form>



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
   
                </td>
            </tr>
            <?php



if (isset($_POST['editor1'])) {  // only at add instruction pressed .  
  if ($debug)  echo("pass the isset");
  $body = $_POST['editor1'];
  $id = $_POST['id'];
  $tietel = $_POST['tietel'];
    $query = "INSERT INTO oefeningen (idoefeningen, bodyDeel1, tietel)  VALUES ('$id', '$body', '$tietel')";
	
    if(mysqli_query($conn, $query)) {
    
     if($debug) echo "Records added successfully.";
  } else{
 

      $a = $conn->error;
 if (strpos($a, 'PRIMARY') !== false) {
  
    
    // change all above ingegeven id 
 
    $sql = "UPDATE oefeningen SET idoefeningen=idoefeningen +1 WHERE idoefeningen >'$id' -1 ORDER BY oefeningen.idoefeningen DESC ";
    if(mysqli_query($conn, $sql)) {
  if ($debug)  echo("nope");
    }
    else {
        echo "ERROR: Could not able to execute l132 $sql. " . mysqli_error($conn);
    }
  // $bodyDeel =  str_split($string, 4); 

    $query = "INSERT INTO oefeningen (idoefeningen, bodyDeel1, tietel)  VALUES ('$id', '$body', '$tietel')";
	
    if(mysqli_query($conn, $query)) {
    
   if ($debug)  echo "Records added successfully.";}

} else { 
echo "ERROR: Could not able to execute $query. l141 " . mysqli_error($conn);


}

}

}
?>

<?php
    

           
            $sql = "select * from oefeningen";
            $resultaat = $conn->query($sql);
            while($row = $resultaat->fetch_assoc()){
            echo("<tr> <td> <img src='../../img/instructie.png' height='50' width='50' /> </td>");
            
            echo( "<td>". $row['idoefeningen']."<br>". $row['tietel'] . $row['bodyDeel1']  );
            if (isset($row['bodyDeel2'])){
                echo($row['bodyDeel2']);
            }
            if (isset($row['bodyDeel3'])){
                echo($row['bodyDeel3']);
            }
            echo( "</td> </tr>" );
            }
        
          ?>

        </table>
    </div>
	<script>

    </script>
    <?php
include("footer.php");
?>
   
    
</body>
</html>