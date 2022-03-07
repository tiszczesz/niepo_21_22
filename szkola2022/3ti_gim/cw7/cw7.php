<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Zgłoszenie</title>
</head>
<body>
    <h1>Zgłoszenie</h1>
    <?php
    //var_dump($_POST);
    if(!isset($_POST['firstname'])){
        echo "Błędny adres!!!!<br>";
        exit();
       // die();
    }
    $firstname = htmlspecialchars(trim($_POST['firstname']),ENT_QUOTES);
    $lastname = htmlspecialchars(trim($_POST['lastname']),ENT_QUOTES);
    if($firstname!='' && $lastname!=''){
        $division = $_POST['division'];
        $date = $_POST['date'];
        $gender = $_POST['gender'];
        $zaint = isset($_POST['zaint']) ? $_POST['zaint']:[];
        echo "<div>Przyjęto zgłoszenie dla: {$firstname} {$lastname} do klasy: {$division}</div>";
        echo "<div>Jesteś mile ".($gender=='kobieta'?"widziana ":"widziany ")."</div>";
        echo "<div>Zgłoszono w dniu: {$date}</div>";
        if(count($zaint)!=0){
            echo "<div>Twoje zainteresowania</div>";
            echo "<ul>";
            foreach($zaint as $z){
                echo "<li>{$z}</li>\n";
            }
            echo "</ul>";
        }else{
            echo "<div>Szkoda, że nie masz zainteresowań!!!</div>";
        }
    }else{
        echo "<div>Musisz podać imię i nazwisko</div>";
    }
    
    ?>
    <a href='cw7.html'>Powrót</a>
</body>
</html>