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
    $c_name = "biszkopcik";
    $c_value = "smaczniutki";
    setcookie($c_name,$c_value,time()+3600,"/");

    var_dump($_COOKIE);

    if(isset($_COOKIE[$c_name])){
        echo "<p>Mamy pyszne ciastko o nazwie {$c_name} o wartości: {$_COOKIE[$c_name]}</p>";
    }else{
        echo "<p>Ktoś zeżarł ciasteczko: {$c_name}</p>";
    }
    ?>
</body>
</html>