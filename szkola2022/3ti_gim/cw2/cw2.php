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
    //dodawanie odejmowanie mnozenie i dzielenie dla $a $b w 
    // paragrafach  -->   12.8 + 45 = 57.8
    define("STALA","wartosc stalej");
    const STALA2 = "warosc stalej2";
    echo 'STALA = '.STALA.' <br />STALA2 = '.STALA2;
    $a  = 13.1;
    $b = 3;
    echo '<p>' . $a . ' + ' . $b . ' = ' . ($a + $b) . '</p>'; // kropki łączą kolejne stringi
    echo '<p>' . $a . ' - ' . $b . ' = ' . ($a - $b) . '</p>'; // kropki łączą kolejne stringi
    echo '<p>' . $a . ' * ' . $b . ' = ' . ($a * $b) . '</p>'; // kropki łączą kolejne stringi
    if ($b == 0) {
        $result = "nie dzielimy przez zero";
    } else {
        $result = round($a / $b, 2);
    }
    echo '<p>' . $a . ' / ' . $b . ' = ' . $result . '</p>'; // kropki łączą kolejne stringi
    echo "<p>{$a} / {$b} = " . ($b == 0 ? "nie dzielimy przez zeroo" : round($a / $b, 2)) . '</p>';
    ?>
</body>

</html>