<?php
if(isset($_POST['title'])){
    $title = $_POST['title'];
    $genre = $_POST['genre'];
    $year = $_POST['year'];
    $rating = $_POST['rating'];
    $conn = new mysqli("localhost","root",null,"4ti_2021_dane1");
    if($conn->connect_errno>0) die("error DB");
    $conn->query("SET NAMES utf8");
    $sql = "INSERT INTO `filmy` (`gatunki_id`,`tytul`,`rok`,`ocena`)".
       " VALUES({$genre},'{$title}','{$year}',{$rating})";
    //echo $sql;
    $result = $conn->query($sql);
    if($result){
        echo "Film {$title} został do bazy";
    }
    $conn->close();
}