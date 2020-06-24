<form>
<h1> size </h1>

<label for="rows"> rows </label>
<input type='text' name='rows' id='rows'
 value= '<?php if(isset($_GET['rows'])) { echo($_GET['rows']);} ?>'>
<label for="coloms"> coloms </label>
<input type='text' name='coloms' id='coloms'
value= '<?php if(isset($_GET['coloms'])) { echo($_GET['coloms']);} ?>'>

<h1> headers </h1>
<input type='hidden' name='L' value= 'HTML' >
<input type='hidden' name='subject' value= 'table'>


<input type="checkbox" id="headerTop" name="headerTop" value="1"
<?php if(isset($_GET['headerTop'])) {if($_GET['headerTop'] == "1") {echo("checked");}}?>>
<label for="headerTop">top</label><br>


<input type="checkbox" id="headerBottom" name="headerBottom" value="1"
<?php if(isset($_GET['headerBottom'])) {if($_GET['headerBottom'] == "1") {echo("checked");}}?>>
<label for="headerBottom">Bottom</label><br>


<input type="checkbox" id="headerLeft" name="headerLeft" value="1"
<?php if(isset($_GET['headerLeft'])) {if($_GET['headerLeft'] == "1") {echo("checked");}}?>>
<label for="headerLeft">Left</label><br>


<input type="checkbox" id="headerRight" name="headerRight" value="1"
<?php if(isset($_GET['headerRight'])) {if($_GET['headerRight'] == "1") {echo("checked");}}?>>
<label for="headerRight">Right</label><br>


<input type='submit' value='create'>
</form>
