<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Operacje na tekstach HTML</h1>
    <?php
        $textHTML = file_get_contents('cw20.php');
        echo '<pre>';
        echo htmlentities($textHTML, ENT_QUOTES);
        echo '</pre>';

    ?>
    <hr>
    <?php
     $textHTML = file_get_contents('cw20.php');
     
     var_dump($textHTML);
     echo '<hr>';
     $encode = htmlentities($textHTML,ENT_QUOTES);
     var_dump($encode);
     echo '<hr>';
     var_dump(htmlspecialchars_decode($encode));
    

    ?>
</body>
</html>