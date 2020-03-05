     <?php 
      $servername = "127.0.0.1";
        $username = "root";
        $password = "usbw";
        $dbname = "dbarduinoeducatief";

        // Create connection
        $conn = new mysqli($servername, $username, $password, $dbname);

        // Check connection
        if ($conn->connect_error) {
            die("Connection failed: " . $conn->connect_error);
        } 
        else{
           // echo "alles ok<br>";

        }
        ?>