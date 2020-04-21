<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" type="text/css" href="css/css.css">
</head>
<body>
    <form method='POST'>
        <label for='userCode'>
        <input type='text' id='userCode' name='userCode'> 
        <input type='submit'>
    </form>
    <?php 
    include("code/dbConn.php");
        if (isset($_POST['userCode'])) {
            $userCode = $_POST['userCode'];
            if ( is_numeric($userCode)) {
                echo($userCode);
                $sql = "SELECT code from user where code = $userCode ";
                $result = $conn->query($sql);

if ($result->num_rows > 0) {
    // output data of each row
    while($row = $result->fetch_assoc()) {

        $_SESSION['userCode'] = $userCode;
        header("location: code/order.php ");

                     }
                }
            }
        }
    ?>
</body>
</html>