<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw4.css">
    <title>Document</title>
</head>

<body>
    <?php
    require_once "functions.php";
    GetInfo();  //wywolanie funkcji
    GetInfo2();
    GetInfo2("Ta funkcja ma własny argument typu string");
    echo "<hr>";
    var_dump(GenerListEcho(5));
    var_dump(GenerList(2,false));
   // echo GenerList(6, true);
    echo "<hr>";
    echo GenerList(5, false);
    //$hhh = GetInfo2(true);
    //var_dump($hhh);
    ?>
    <h1>Ćwiczenie z generowanie elemetu &lt;select&gt; i  &lt;option&gt; argument funkcji to ilość opcji</h1>
 <?php
 var_dump(GetColors());
 echo GenerSelect(GetColors());
 echo GenerRadio(GetColors());
 ?>
 <div class='first'></div>
 <script>
     document.querySelector("#colors").onchange = function(e){
        document.body.style.backgroundColor = e.target.value;
     }
     const radios = document.querySelectorAll('input[name="r"]');
     console.log(radios);
     for (const r of radios) {
         r.onclick = function(e){
             document.querySelector('.first').style.backgroundColor = e.target.value;
         }
     }
 </script>
</body>

</html>