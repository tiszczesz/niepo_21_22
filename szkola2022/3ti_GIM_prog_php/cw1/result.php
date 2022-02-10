<?php
if (isset($_POST['submit'])) {
    // var_dump($_POST);
    var_dump($_FILES);
    $uploads = __DIR__ . '/uploads/';
    $filename = $uploads . basename($_FILES['fileToUpload']['name']);
    // echo $filename;
    $noError = true;
    $imageType = strtolower(pathinfo($filename, PATHINFO_EXTENSION));
    $checkImage = getimagesize($_FILES['fileToUpload']['tmp_name']);
    var_dump($checkImage);
    if ($checkImage !== false) {
        echo "<p>Plik jest obrazkiem: " . $checkImage['mime'] . "</p>";
        $noError = true;
    } else {
        echo "<p>Plik nie jest obrazkiem: </p>";
        $noError = false;
        //die("Błąd!!!!");
    }
    if (file_exists($filename)) {
        echo "<div>Plik juz istnieje!!!!</div>";
        $noError = false;
       // die("error");
    }
    if($_FILES['fileToUpload']['size']>1000000){
        echo "<div>Rozmiar pliku za duży</div>";
        $noError = false;
        //die("error");
    }

    if($imageType != 'jpg' && $imageType != 'png' && $imageType != 'jpeg' && $imageType != 'gif'){
        echo "<div>Zły typ obrazek</div>";
        $noError = false;
        //die("error");
    }
    if($noError){
        if(move_uploaded_file($_FILES['fileToUpload']['tmp_name'],$filename)){
            echo "<div>Załadowano plik ".htmlspecialchars(basename($_FILES['fileToUpload']['name']))."</div>";
        }else{
            echo "<div>nie udalo się załadować pliku!!!!</div>";
        }
    }
    // 

}

// if(filter_has_var(INPUT_POST,'submit')){

// }

echo "<div><a href='cw1.html'>Powrót na stronę główną</a></div>";
echo "<div><a href='galeria.php'>Przegląd obrazków</a></div>";
