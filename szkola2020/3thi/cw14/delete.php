<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<?php
         $conn = new mysqli("localhost", "root", null, "3thi_cw1");
         // var_dump($conn);
         if ($conn->connect_errno !== 0) {
             echo $conn->connect_error . "<br>";
             die("ERROR Db");
         }
         echo "<p>Wszystko OK z Db</p>";
         //$conn->set_charset("utf8");
     
         $r = $conn->query("SET NAMES utf8");
     
        $sqlInsert = "DELETE FROM persons WHERE firstName not like '%a'";
        $r2 = $conn->query($sqlInsert);
         if($r2==true){
             echo "<div>Usunięto z bazy</div>";
         }else{
            echo "<div>Nie usunięto z bazy</div>";
         }
        $conn->close();

    ?>
</body>
</html>