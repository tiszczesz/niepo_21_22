<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style>
        .line{margin: 20px;}
        label{display:inline-block;width: 200px;text-align: right;padding: 6px;}
        input{width: 200px;padding: 5px;}
        input[type=submit]{margin-left: 218px;}
    </style>
    <title>Document</title>
</head>
<body>
    <div class="container">
        <form action="result.php" method="post">
            <div class="line">
                <label for="">Login </label>
                <input type="text" name="login" id="login">
            </div>
            <div class="line">
                <label for="">Hasło </label>
                <input type="password" name="password" id="password">
            </div>
            <div class="line">
               
                <input type="submit" value="Loguj">
            </div>
        </form>
    </div>
</body>
</html>