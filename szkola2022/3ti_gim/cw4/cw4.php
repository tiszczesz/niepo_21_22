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
    function GetInfo(): void
    { //def funkcji
        echo "<h3>hello from function GetInfo</h3>";
    }
    function GetInfo2(string $info = "bla bla bla"): void
    { //def funkcji
        echo "<h3>{$info}</h3>";
    }
    function GenerListEcho(int $count, bool $isUL = true): void
    {
        $listTag = $isUL ? "ul" : "ol";
        echo "<{$listTag}>";
        for ($i = 1; $i <= $count; $i++) {
            echo  "<li>Element listy nr {$i}</li>";
        }
        echo "</{$listTag}>";
    }
    function GenerList(int $count, bool $isUL = true): string
    {
        $listTag = $isUL ? "ul" : "ol";
        $html =  "<{$listTag}>\n";
        for ($i = 1; $i <= $count; $i++) {
            $html .=  "\t<li>Element listy nr {$i}</li>\n";
        }
        $html .= "</{$listTag}>\n";
        return $html;
    }
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
</body>

</html>