<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw10.css">
    <title>Document</title>
</head>

<body>
    <?php
    require_once "PostToHtml.php";
    require_once "PostRepo.php";

    $posts = PostRepo::getAllPosts(); //na rzecz klasy - statyczne wywolanieS
    foreach ($posts as $p) {
        echo PostToHtml::postToDiv($p);
    }
    ?>
    <div>
        <a class='btn-link' href="addNewForm.php">dodaj nowy post</a>
    </div>

</body>

</html>