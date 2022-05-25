<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Operacje na stringach</h1>
    <h3>dostęp do pojedynczych liter</h3>
    <?php
        function wstawZnak(string $napis,string $znak):string {
            $result = '';
            for($i = 0; $i < mb_strlen($napis); $i++){
                if($i<mb_strlen($napis)-1){
                    $result .= mb_substr($napis,$i,1).$znak;
                }else{
                    $result .= mb_substr($napis,$i,1);
                }
            }
            return $result;
        }
        function wstawBR(string $napis):string {
            $result = '';
            for($i = 0; $i < mb_strlen($napis); $i++){
                $znak = $i<(mb_strlen($napis)-1)?'<br>':'';
                var_dump($znak);
                $result .= mb_substr($napis,$i,1).$znak;
               
            }
            return $result;
        }
        function stringWords(string $text,string $znak): string {
            $result = '';
            $words = explode(' ',$text);
            var_dump($words);
            foreach($words as $w){
                $result .= wstawZnak($w,$znak).' ';
            }
            return $result;
        }
        echo wstawZnak("Łódka jest żółta",'.').'<br>';
        echo stringWords("Łódka jest żółta",'.').'<br>';
        echo wstawBR("Łódka jest żółta");
        function ChangeUpper(string $napis,string $znak):string {
            $result = '';
            if( mb_strtoupper(mb_substr($napis,0,1)) === mb_substr($napis,0,1)){
                //....
            }
            return $result;
        }
    ?>
</body>
</html>