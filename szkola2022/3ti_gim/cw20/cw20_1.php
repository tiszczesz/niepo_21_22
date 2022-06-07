<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <div class="container">
        <form method="post">
            <textarea name="text" id="text" cols="30" rows="10"></textarea>
            <input type="submit" value="Zapisz">
        </form>
        <div class="result">
            <pre>
                <?php
               // var_dump($_POST);
                if(isset($_POST['text'])){
                   
                   $encodeText = htmlentities($_POST['text'],ENT_QUOTES);
                   $replaceText = str_replace('div','DDD',$encodeText);
                   echo $encodeText;
                   echo '<hr>';
                   echo $replaceText;
                }

                ?>
            </pre>
        </div>
    </div>
</body>
</html>