<h1> keuze :</h1>
<div id='automaat'> <br>
        <?php 
           $sql ="SELECT * FROM bakerijpol.broodlocatie inner join soortbrood on soortbrood.idsoortBrood = broodlocatie.IDsoordBrood WHERE broodlocatie.hoeveelheid >0 ";
           $result = $conn->query($sql);

if ($result->num_rows > 0) {
   // output data of each row
   while($row = $result->fetch_assoc()) {

  echo("<div id='brood'>");
  echo("<h2> ". $row['naam'] ." </h2>");
  echo($row['locatie']);
  echo("</div>");
   }
} else {
   echo "0 results";
}
        ?><br>
        </div>