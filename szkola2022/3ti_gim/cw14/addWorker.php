<?php
require_once "configure.php";
require_once "functions.php";
var_dump($_POST);
$imie = trim($_POST['imie']);
$nazwisko = trim($_POST['nazwisko']);
$pensja = floatval(trim($_POST['pensja']));
$stanowisko = trim($_POST['stanowisko']);
if(empty($imie) || empty($nazwisko) || empty($pensja) || empty($stanowisko)){
    echo "ERRROR!!!!!";
    die("error");
}
addToFile([$imie,$nazwisko,$pensja,$stanowisko],FILENAME);

header('Location: cw14.php');