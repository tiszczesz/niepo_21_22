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
    require_once "functions.php";
    $colors = GetColors();
    $color = array_rand($colors);

    if (!isset($_POST['answer'])) {
        echo ShowForm($color);
    } else {
        echo  '<div class="result">';
        $answer = trim($_POST['answer']);
        $request = trim($_POST['color']);
        var_dump($answer, $colors[$color]);
        $src = $_POST['answer'] == $colors[$request] 
                    ? "ok.jpg" : "nook.jpg";
        var_dump($src);
        echo "<img src='$src' alt='odpowiedz'>";
    }
    echo "</div>";
    ?>

    <a href="cw11.php">Nowe zgadywanie</a>
</body>

</html>