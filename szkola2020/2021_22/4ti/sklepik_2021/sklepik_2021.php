<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="bootstrap-5.1.3-dist/css/bootstrap.min.css">
    <title>Document</title>
</head>
<body>
    <div class="container">
        <h1>Sklepik 2021_22</h1>
        <?php
        require_once "functions.php";
        //$conn = getConnection();
        //var_dump($conn);
        //$conn->close(); 
        //mysqli_close($conn);
        echo getCustomers();
        ?>
    </div>
    
</body>
</html>