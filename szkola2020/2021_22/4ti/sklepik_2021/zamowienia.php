<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="bootstrap-5.1.3-dist/css/bootstrap.min.css">
    <title>Szczegóły klienta</title>
</head>

<body>
    <div class="container">
        <h1>Szczegóły klienta</h1>
<?php
        require_once "functions.php";
        if (isset($_GET['id'])) {
            $id = $_GET['id'];
            $customer = getCustomerById($id);
            if($customer==null || count($customer)==0) die("ERROR");
            //var_dump($customer);
            echo "<h3>{$customer[1]} {$customer[2]}</h3>";
            $orders = getOrders($id);
            $total = 0;
            foreach($orders as $i){
                $total += floatval($i[2]);
            }
            echo showOrders($orders);
            echo "<hr>";
            echo "<div>Całkowity koszt: {$total}PLN</div>";
            echo getTotal($id);
?>

            <h3></h3>

    </div>
<?php
        } else {
            echo "<h3>Nie wybrano klienta <a href='sklepik_2021.php'>Powrót</a></h3>";
        }
?>
</body>

</html>