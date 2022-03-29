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
        $filename = "dane.txt";
        if(file_exists($filename)){
             $file = fopen($filename,'r');
        //    var_dump($file);
            if($file){
                echo "<ol>";
                while($line=fgets($file)){
                    echo "<li>{$line}</li>";
                }
                echo "</ol>";
                fclose($file);
        //        var_dump($file);
            }else {
                echo "NOOK";
            }
        }else{
            echo "Brak pliku!!!!";
        }
       
    ?>

    <?php
     $filename = "colors.txt";
     if(file_exists($filename)){
          $file = fopen($filename,'r');
      //   var_dump($file);
         if($file){
             echo "<select>\n";
             while($line=fgets($file)){
                 echo "<option>{$line}</option>\n";
             }
             echo "</select>\n";
             fclose($file);
      //       var_dump($file);
         }else {
             echo "NOOK";
         }
     }else{
         echo "Brak pliku!!!!";
     }
    ?>
</body>
</html>