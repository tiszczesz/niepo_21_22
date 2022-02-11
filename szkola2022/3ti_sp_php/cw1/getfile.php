<?php
// if (isset($_POST['submit'])) {
//     var_dump($_POST);
//     echo "<hr>";
//     var_dump($_FILES);
// }
if (filter_has_var(INPUT_POST, "submit")) {
    
    var_dump($_FILES);
    $file_target = __DIR__."/media/".basename($_FILES['toUpload']['name']);
    echo $file_target;
    $imageType = strtolower(pathinfo($file_target,PATHINFO_EXTENSION));
    //var_dump($imageType);
   
   $isNoError = true;
   $isImage = getimagesize($_FILES['toUpload']['tmp_name']);
    var_dump($isImage);
    if($isImage){
        echo "<div>Tak to obrazek typu: ".$isImage['mime']."</div>";
        $isNoError = true;
    }else{
        echo "<div>To nie jest obrazek </div>";
        $isNoError = false;
    }
    if(file_exists($file_target)){
        echo "<div>Plik już istnieje</div>";
        $isNoError = false;
    }
    if($_FILES['toUpload']['size']>500000){
        echo "<div>Rozmiar obrazka za duży</div>";
        $isNoError = false;
    }
    if($imageType!='jpg' && $imageType!="png" 
        && $imageType!='jpeg' && $imageType!='gif'){
        $isNoError = false;
    }
    if($isNoError){
        if( move_uploaded_file($_FILES['toUpload']['tmp_name'],$file_target)){
            echo "<div>Obrazek: ".htmlspecialchars( basename($_FILES['toUpload']['name']))." został zapisany</div>";
        }else{
            echo "<div>Obrazek: nie został zapisany</div>";
        }
    }

}

echo "<div><a href='cw1.html'>Powrót do formularza</a></div>";
echo "<div><a href='obrazki.php'>Wywietl wszystkie obrazki</a></div>";
//scandir()


