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
    var_dump($_GET); //tutaj dane z formularza metoda GET

    // opcja 2 ---------------------------------
    // if(!isset($_GET['a']) || !isset($_GET['b'])){
    //     echo "<div>BRAK DANYCH Z FORMULARZA!!!</div>";
    //     exit();
    // }
    // $a = floatval($_GET['a']);
    // $b = floatval($_GET['b']);
   

  //opcja 2 -------------------------
  if(!filter_has_var(INPUT_GET,'a') || !filter_has_var(INPUT_GET,'b')){
    echo "<div>BRAK DANYCH Z FORMULARZA!!!</div>";
    exit();
  }
  $a = filter_input(INPUT_GET,'a',FILTER_VALIDATE_FLOAT);
  $b = filter_input(INPUT_GET,'b',FILTER_VALIDATE_FLOAT);
  if($a===false || $b===false) {
    echo "<div>Błędne dane Z FORMULARZA!!!</div>";
    exit();
  }
  //-------------------------------------
    echo "tu jest rezultat formularza a = {$a} b = {$b}";
    echo "<div> {$a} + {$b} = ".($a+$b)."</div>\n";
    echo "<div> {$a} - {$b} = ".($a-$b)."</div>\n";
    echo "<div> {$a} * {$b} = ".($a*$b)."</div>\n";
    echo "<div> {$a} / {$b} = ".($b!=0 ?  round($a/$b,2):"BRAK WYNIKU" )."</div>\n";
    ?>
</body>
</html>