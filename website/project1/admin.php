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

if (isset($_POST['username'])) {
    $username = $_POST['username'];
    $password1 = $_POST['password1'];
    $password2 = $_POST['password2'];
    $admin=$_POST['admin'];
    if ($password1 == $password2) {
        $sql = "INSERT INTO `inuitgaven`.`user` ( `username`, `password`, `ADMIN`) VALUES ( '$username', '$password1', '$admin');        ";
        if ($conn->query($sql) === TRUE) {
        //    echo "New record created successfully";
        } else {
            echo "Error: " . $sql . "<br>" . $conn->error;
        }
    } else {
        echo("de 2 wachtwoorden komen mogelijks niet overeen, probeer opnieuw.");
    }
}
?>
<?php 

if (isset($_POST['userID'])) {
    $code = $_POST['code'];
    $omschrijving = $_POST['beschrijving'];
    $bedrag = $_POST['bedrag'];
    $idUser = $_POST['userID'];
    $io = $_POST['inkomst'];


$sql = "INSERT INTO `inuitgaven`.`inkomsten` (`code`, `omschrijving`, `bedrag`, `io`, `iduser`) VALUES ('$code', '$omschrijving', '$bedrag', '$io', '$idUser')";
if ($conn->query($sql) === TRUE) {
   // echo "New record created successfully";
} else {
 //   echo "Error: " . $sql . "<br>" . $conn->error;
}
}

if (isset($_POST['changeuserID'])){

 
    $omschrijving = $_POST['changebeschrijving'];
    $bedrag = $_POST['changebedrag'];
    $code = $_POST['changecode'];
    $idUser = $_POST['changeuserID'];
    $io = $_POST['changeinkomst'];


$sql = "UPDATE `inkomsten` SET `omschrijving` = '$omschrijving', `bedrag` = '$bedrag', `io` = '$io', `iduser` = '$idUser' WHERE (`code` = '$code') ";
echo($sql);
if ($conn->query($sql) === TRUE) {
   // echo "New record changed successfully";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}    

}

$sql = "SELECT * from user";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    echo("<table border='1'>");
    echo("<tr> <th> iduser </th> <th> username </th> <th> password </th> <th> acount type </th> </tr>");
    while($row = $result->fetch_assoc()) { 
       $iduser = $row['iduser'];
       $username = $row['username'];
       $password = $row['password'];

        if ($row['ADMIN'] == 1) {
            $accType = "ADMIN";
        } else {
            $accType = "user";
        }
        echo("<tr> <td> $iduser </td> <td> $username </td> <td> $password </td> <td> $accType</td></tr>");
    }
    echo("</table>");
}

// echo($_SESSION['iduser']);
$sql = "SELECT u.iduser, code , omschrijving, bedrag, io, u.iduser,  username FROM inkomsten inner join  (SELECT * from user) as u  on u.iduser = inkomsten.iduser ";
$result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    echo("<table border='1'>");
    echo("<tr> <th> code </th><th> omschrijving</th><th>inkomst / uitgave </th> <th>bedrag </th> <th>userID</th> <th>username </th> </tr> ");
    while($row = $result->fetch_assoc()) {
        if ($row['io'] == 1 ) {
            $io = "inkomst";
            $col = "green";
        } else {
            $io = "uitgave";
            $col = "red";
        }
        echo "<tr> <td style='color: $col'> " . $row["code"]. " </td>  <td style='color: $col'> " . $row["omschrijving"]. " </td> <td style='color: $col'>$io </td><td style='color: $col'>" . $row["bedrag"]. "</td> <td style='color: $col'>" . $row['iduser']. "</td> </td> <td style='color: $col'>" . $row["username"]. "</td>   </tr>";
    }
} else {
    echo "0 results";
}
?>
</table>
<form class='adminAdd' method='POST'>
<label id='inuit'> inkomst/uitgave toevoegen </label>

<label for='code' id='lblcode'> code </label>
<input type='text' id='code' name='code'>

<label for='beschrijving' id='lblBeschrijving'> omscrijving </label>
<input type='text' id='beschrijving' name='beschrijving'>

<label for='inkuitg' id='lblinkuitg'> inkomst / uitgave </label>
<select type='select' id='inkuitg' name='inkomst'>
<option value='1' > inkomst </option>
<option value='0' > uitgave </option>
</select>
<label for='bedrag' id='lblBedrag'> bedrag  </label>
<input type='number' id='bedrag' name='bedrag'>

<label for='username' id='lblUsername'> userID   </label>
<input type='text' id='username' name='userID'>

<input type='submit' value='add'>

</form>

<form class='adminChange' method='POST'>
<label id='inuit'> inkomst/uitgave wijzigen </label>
<label for='ccode' id='lblcode'> code </label>
<input type='text' id='ccode' name='changecode'>

<label for='cbeschrijving' id='lblBeschrijving'> omscrijving </label>
<input type='text' id='cbeschrijving' name='changebeschrijving'>

<label for='cinkuitg' id='lblinkuitg'> inkomst / uitgave </label>
<select type='select' id='cinkuitg' name='changeinkomst'>
<option value='1' > inkomst </option>
<option value='0' > uitgave </option>
</select>
<label for='cbedrag' id='lblBedrag'> bedrag  </label>
<input type='number' id='cbedrag' name='changebedrag'>

<label for='cusername' id='lblUsername'> userID   </label>
<input type='text' id='cusername' name='changeuserID'>

<input type='submit'  value='change'>

</form>


<form method='POST' class='addUser'>
<label id='inuit'> add user </label>
<label id='lblBeschrijving'> username </label>
<input id='ccode' type='text' name='username'>
<label id='lblBeschrijving'> wachtwoord </label>
<input id='ccode' name='password1' type='password'>
<label id='lblBeschrijving'>herhaal uw wachtwoord </label>
<input id='ccode' name='password2' type='password'>
<label id='lblBeschrijving'> admin of user ? </label>

<select type='select' id='cinkuitg' name='admin'>
<option value='1' > admin </option>
<option value='0' > user </option>
</select>
<input id='ccode' type='submit' value='add user'>
</form>

</body>
</html>