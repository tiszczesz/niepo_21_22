<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <div>
        <form method="post">
            <div>
                <textarea name="text" id="text" cols="30" rows="10"></textarea>
            </div>
            <div><input type="submit" value="Zapisz do pliku"></div>
        </form>
    </div>
    <?php
    if (isset($_POST['text'])) {
        $file = fopen("wynik.txt", 'a');
        $dd = date("Y-m-d H:i:s");
        if ($file) {
            fwrite($file,$dd.': '.$_POST['text'].PHP_EOL);
            fclose($file);
        }
    }


    ?>
</body>

</html>