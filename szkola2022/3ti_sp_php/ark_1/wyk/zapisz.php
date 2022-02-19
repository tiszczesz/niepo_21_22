<?php
$conn = new mysqli("localhost","root",null,"3tisp_wedkowanie");
if($conn->connect_errno>0) die($conn->connect_error);//!
$conn->query("SET NAMES utf8");//!
if(isset($_POST['imie'])){//!
    //var_dump($_POST);
    $sql = "INSERT INTO karty_wedkarskie(imie,nazwisko,adres,data_zezwolenia,punkty)"
       ." VALUES ('{$_POST['imie']}','{$_POST['nazwisko']}','{$_POST['adres']}',null,null)";
    //echo  $sql;

    $result = $conn->query($sql);
    //var_dump($result);
    $conn->close();
}//!