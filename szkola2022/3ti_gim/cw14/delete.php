<?php
    if(!isset($_GET['id'])){
        exit();
    }
    require_once "functions.php";
    require_once "configure.php";
    $dane = file(FILENAME,FILE_IGNORE_NEW_LINES);
    $id = $_GET['id'];
    if(array_key_exists($id,$dane)){
        // echo "Usuwanie elementu: {$id}";
        unset($dane[$id]);
        saveFile(FILENAME,$dane);
        header('Location: cw14.php');
    }else{
        echo "Brak klucza!!!";
    }
    