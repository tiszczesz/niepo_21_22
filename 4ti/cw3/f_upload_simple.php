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
 
    var_dump($_FILES);
    if(isset($_FILES['fileToUpload']) && isset($_POST['submit']) 
                                && !empty($_FILES['fileToUpload']['name'])){        
        $dir = __DIR__."/images/";
        $targetFile = $dir.basename($_FILES["fileToUpload"]["name"]);
        echo $targetFile;
        $isOK = true;
       
           if(move_uploaded_file($_FILES['fileToUpload']['tmp_name'],$targetFile)){
               echo "<p>Plik: ".htmlspecialchars(basename($_FILES['fileToUpload']['name']))
                   ." został załadowany z sukcesem</p>";
           }else{
               echo "<p>Coś jednak poszło nie tak</p>";
           }
       }
      var_dump(scandir($dir));  
      
    ?>
     <div>
         <a href="result.php">wyświetl wszystkie obrazki</a>
       </div>
</body>
</html>