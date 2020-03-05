<html lang="en" xmlns="http://www.w3.org/1999/xhtml"><head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css.css">
</head>
<body>
<?php 
include("dbconn.php");
include("checkIfLogedIn.php");
include("banner.php");

echo($_SESSION['iduser']);
$iduser = $_SESSION['iduser'];

if (isset($_POST['code'])) {
    $code = $_POST['code'];
    $bedrag = $_POST['bedrag'];
    $io = $_POST['inkomst'];
    $omscrijving = $_POST['beschrijving'];
    $sql = "INSERT INTO `inuitgaven`.`inkomsten` (`code`, `omschrijving`, `bedrag`, `io`, `iduser`) VALUES ('$code', '$omscrijving', '$bedrag', '$io', '$iduser')";
    if ($conn->query($sql) === TRUE) {
       // echo "New record created successfully";
    } else {
     //   echo "Error: " . $sql . "<br>" . $conn->error;
    }
}


$sql = "SELECT * FROM inkomsten WHERE iduser = '$iduser'";
$result = $conn->query($sql);



if ($result->num_rows > 0) {
    // output data of each row
    echo("<table border='1'>");
    echo("<tr> <th> code </th><th> omschrijving</th> <th>inkomst / uitgave </th> <th>bedrag </th> </tr> ");
    while($row = $result->fetch_assoc()) {
        if ($row['io'] == 1 ) {
            $io = "inkomst";
            $col = "green";
        } else {
            $io = "uitgave";
            $col = "red";
        }
        echo "<tr> <td style='color: $col'> " . $row["code"]. " </td>  <td style='color: $col'> " . $row["omschrijving"]. " </td> <td style='color: $col'>$io </td> <td style='color: $col'>" . $row["bedrag"]. "</td> </tr>";
    }
} else {
   // echo "0 results";
}
echo("</table>")
?>
<form id = 'userAddIO' method='POST'>
<label id='inuit'> inkomst / uitgave  toevoegen </label>

<label for='code' id='lblcode2'> code </label>
<input type='text' id='code' name='code'>

<label for='beschrijving' id='lblBeschrijving2'> omscrijving </label>
<input type='text' id='beschrijving' name='beschrijving'>

<label for='inkuitg' id='lblinkuitg2'> inkomst / uitgave </label>
<select type='select' id='inkuitg' name='inkomst'>
<option value='1' > inkomst </option>
<option value='0' > uitgave </option>
</select>
<label for='bedrag' id='lblBedrag2'> bedrag  </label>
<input type='number' id='bedrag' name='bedrag'>


<input type='submit' value='add'>

</form>

</body>
</html>