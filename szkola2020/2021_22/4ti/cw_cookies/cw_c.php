<!DOCTYPE html>
<html lang="en">
  
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ciasteczka</title>
</head>
<body>
<?php
    var_dump($_COOKIE);
    $c_name = "moje_ciastko";
    $c_value = "mnima mniam";
    setcookie($c_name,$c_value,time()+3600,"/");
    if(isset($_COOKIE[$c_name])){
        echo "<p>ciasteczko {$c_name} jest ustawione na wartość ".$_COOKIE[$c_name]."</p>";
    }else{
        echo "<p>ciasteczko {$c_name} nie ustawione </p>";
    }
?>
</body>
</html>