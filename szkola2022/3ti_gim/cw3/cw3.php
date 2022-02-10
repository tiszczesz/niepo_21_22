<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h2>Pętla for w php for(...; ...; ....) {....}</h2>
    <?php
    for ($i = 1; $i <= 6; $i++) {
        echo "<h{$i}>Nagłówek nr: {$i} </h{$i}>\n";
    }
    for ($i = 51; $i <= 100; $i++) {
        echo "{$i}<sup>2</sup> = " . pow($i, 2) . " ";
        if ($i % 5 == 0) echo "<br />";
    }
    ?>
    <h2>Pętla do{...} while(...) w php</h2>
    <?php
    const MAXSUM = 100;
    const ZAKRES = 20;
    $sum = 0;
    do {
        $random = rand(0, ZAKRES);
        $sum += $random;  // $sum = $sum + $random;
        // echo $random. ($sum<MAXSUM ? ' + ':'');
        echo $random;
        if ($sum < MAXSUM) echo ' + ';
    } while ($sum < MAXSUM);
    echo " = {$sum}<br />";
    ?>
    <h2>Pętla while(...){ ....} w php</h2>
    <?php
    $random = rand(0, ZAKRES);
    $count = 0;
    $sum = 0;
    while ($random != 0) {
        $sum+=$random;
        if($random!=0) {
            $count++;
        }
        echo $random . ' ';
        $random = rand(0, ZAKRES);
        //max i min
        
    }
    if($count==0) echo "<div>Zbiór pusty</div>";
    else{
        echo "<div>Ilość elementów w zbiorze: {$count}</div>";
        echo "<div>Średnia w zbiorze: ".round($sum/$count,2)."</div>";
    }
    
    ?>

</body>

</html>