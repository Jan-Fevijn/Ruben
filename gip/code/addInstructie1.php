
<script src="https://cdn.ckeditor.com/4.9.2/standard/ckeditor.js"></script>  
<form method="POST" action="addInstructie1.php">
<textarea name="editor1"></textarea><br/> //Write data  
  
<input type="submit" id="getData" name="getData" value="Get and Set Data" onclick="getData()" /> 
<?php
  echo("dibug101");
if (isset($_POST['editor1'])) {
    echo ($_POST['editor1']);
    echo("dibug101");
}
?> 
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