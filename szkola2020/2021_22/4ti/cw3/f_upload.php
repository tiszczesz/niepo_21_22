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
        $imageType = strtolower(pathinfo($targetFile,PATHINFO_EXTENSION));
       $check = getimagesize($_FILES['fileToUpload']['tmp_name']);
       //var_dump($check);
       if($check !== false){
           echo "<p>Plik jest obrazkiem {$check['mime']}</p>";
           $isOK = true;
       }else{
            echo "<p>Plik nie jest obrazkiem </p>";
            $isOK = false;
       }
       if(file_exists($targetFile)){
           echo "<p>Taki plik już jest!</p>";
           $isOK = false;
       }
       if($_FILES['fileToUpload']['size']>1000000){
           echo "<p>Za duży rozmiar pliku!</p>";
           $isOK = false;
       }
       if($imageType !="jpg" && $imageType != "png" && $imageType != "jpeg" && $imageType!="gif"){
           echo "<p>złe rozszerzenie obrazka!</p>";
           $isOK = false;
       }

       if($isOK == false){
           echo "<p>Nie można załadować obrazka!</p>";
       } else {
           if(move_uploaded_file($_FILES['fileToUpload']['tmp_name'],$targetFile)){
               echo "<p>Plik: ".htmlspecialchars(basename($_FILES['fileToUpload']['name']))
                   ." został załadowany z sukcesem</p>";
           }else{
               echo "<p>Coś jednak poszło nie tak</p>";
           }
       }
        
    }
    ?>
</body>
</html>