<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        .green{color: green;}
        .red{color: red;}
    </style>
</head>
<body>
    <?php
    require_once "functions.php";
    if(!isset($_POST['login'])){
        echo "<div><a href='cw10.php'>Wróć do formularza</a></div>";
        exit();
    }
    $login = trim($_POST['login']);
    $password = trim($_POST['password']);
    $users = Logins();
    if(array_key_exists($login,$users)){
        var_dump($login,$password,$users[$login]);
        if($password===$users[$login]){
            echo "<div class='grren'>Jesteś zalogowany!!!</div>";
        }
        else{
            echo "<div class='grren'>Jesteś nie zalogowany złe hasło!!!</div>";
        } 
    }else{
        echo "<div class='red'>Błędny login lub hasło!!!</div>";
        echo "<div><a href='cw10.php'>Wróć do formularza</a></div>";
    }
    ?>
</body>
</html>