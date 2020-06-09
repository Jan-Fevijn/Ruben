<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" type="text/css" href="css/css.css">
</head>
<body>
<?php 
include("code/dbConn.php");
?>
    <h1>
        my games
    </h1>
    <table border = '1'>
    <tr> 
    
        <th> naam spel    </th> 
       
        <th> korte inhoud </th>
        <th> aankoopdatum </th>

     </tr>
    <?php 
$sql = "select s.idspel, s.Naamspel, s.IDuitgever, s.korteinhoud, s.aankoopdatum, iduitleening, iduitleener from spel as s inner join uitleening as uitling on s.idspel = uitling.idspel";
echo $sql;
$result = $conn->query($sql);
  // output data of each row
  if ($result->num_rows > 0) {
  while($row = $result->fetch_assoc()) {
 echo("<tr>");
echo("<td> " .$row['Naamspel']." </td>" . "<td>" .$row['korteinhoud']  );
 echo("</tr>");
  }
}
?>
    </table>
</body>
</html>