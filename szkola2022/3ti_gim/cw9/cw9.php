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
    $colors = getData();
    // echo "<pre>";
    $values = array_values($colors);
    $keys = array_keys($colors);
    var_dump($colors);
    var_dump($values);
    var_dump($keys);
    //  echo "</pre>";
    ?>
    <h2>Sortowanie tablic sort->tylko zwykłe tablice asort->sortowanie wartości ksort->sortowanie kluczy</h2>
    <?php
    $numbers = [12, 7, 99, 22, 11, 45, 168, 660, 320, 5];
    var_dump($numbers);
    sort($numbers/*,SORT_STRING*/);
    var_dump($numbers);
    ksort($colors);
    var_dump($colors);
    asort($colors);
    var_dump($colors);
    $sum = array_sum($numbers);
    echo "<p>Suma elementów tablicy: ".print_r($numbers)." to {$sum}</p>";
    print_r(array_map(fn($value):int => $value*$value, $numbers));
    function f1(int $arg):int {
        return 2*$arg;
    }
    echo "<br>";
    print_r(array_map("f1", $numbers));
    echo "<br>";
    print_r(array_filter($numbers,fn($value):int => !($value % 2)));
    echo "<br>";
    print_r(array_filter($numbers,fn($value):int => $value>=18));
    echo "<br>";
    print_r(array_map(fn($value):string => "To juz nie liczba: ".($value), $numbers));
    ?>

</body>

</html>