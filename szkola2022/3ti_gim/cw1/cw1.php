<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
   <h1>Informacje o echo</h1>
    <?php
        $a = 12;
        var_dump($a);
        echo "<h3>Hello from PHP {$a}</h3>"; //jest wolniej ale z przetwarzaniem np zmiennych
        $a = "Ala ma kota";
        echo "<h3>Hello from PHP {$a}</h3>"; //jest szybciej ale bez przetwarzania
        var_dump($a);
       // phpinfo();
       
    ?>
<h1>Informacje o typach w php</h1>
<h3>Typ całkowity int</h3>
   <?php
    $calkowita = 23444;
    $d = 100111;
    var_dump($calkowita);
   ?>
   <h3>Typ zmienno przecinkowy float</h3>
   <?php
    $zmienno1 = 2.890;
    $zmienno2 = 267e-2; // 267*10^-2
    var_dump($zmienno1);
    var_dump($zmienno2);
    $a = 1234; // decimal number
    $a = 0123; // octal number (equivalent to 83 decimal)
  //  $a = 0o123; // octal number (as of PHP 8.1.0)
    $a = 0x1A; // hexadecimal number (equivalent to 26 decimal)
    $a = 0b11111111; // binary number (equivalent to 255 decimal)
    $a = 1_234_567; // decimal number (as of PHP 7.4.0)
   ?>
</body>
</html>