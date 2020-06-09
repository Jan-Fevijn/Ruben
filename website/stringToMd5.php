<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form>
        <input type='text' name='string'
        
        <?php
        if (isset($_GET['string'])) {
            echo(" value = '" . $_GET['string'] . "'");
        }
    ?>
        
        >
        <input type='submit' value='convert'>
    </form>

    <?php
        if (isset($_GET['string'])) {
            echo("<br> " . md5($_GET['string']));
        }
    ?>
</body>
</html>