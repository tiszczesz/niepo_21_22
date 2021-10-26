<?php
function getConnection()
{
    $conn = new mysqli("localhost", "root", null, "zdalne4tigr1_cw2");
    if ($conn->connect_errno != 0) return null;
    $conn->query("SET NAMES utf8");
    return $conn;
}
function getAllWycieczki(): array
{
    $conn = getConnection();
    if ($conn->connect_errno != 0) return [];
    $sql = "SELECT * FROM wycieczki";
    $dane = [];
    $result = $conn->query($sql);
    while ($row = $result->fetch_row()) {
        $dane[] = $row;
    }
    $conn->close();
    return $dane;
}
function wycieczkiToList(array $dane): string
{
    $html = "<ul>";
    foreach ($dane as $row) {
        $html .= "<li>{$row[1]} data: {$row[2]} ilość miejsc: {$row[3]} cena: {$row[4]}zł</li>\n";
    }
    return $html . "</ul>";
}
function getAllGrupy(): array
{
    $conn = getConnection();
    if ($conn->connect_errno != 0) return [];
    $sql = "SELECT * FROM grupy";
    $dane = [];
    $result = $conn->query($sql);
    while ($row = $result->fetch_row()) {
        $dane[] = $row;
    }
    $conn->close();
    return $dane;
}
function grupyToSelect(array $grupy): string
{
    $html = "<select name='grupaId'>\n";
    foreach ($grupy as $row) {
        $html .= "\t<option value='{$row[0]}'>{$row[1]} opis: {$row[2]}zł</option>\n";
    }
    return $html . "</select>\n";
}
function wycieczkiToSelect(array $wycieczki): string
{
    $html = "<select name='wycieczkaId'>\n";
    foreach ($wycieczki as $row) {
        $html .= "\t<option value='{$row[0]}'>{$row[1]} cena: {$row[4]}zł</option>\n";
    }
    return $html . "</select>\n";
}
function insertToUczestnikAdres(array $dane): int
{
    $conn = getConnection();
    if ($conn->connect_errno != 0) return -1;
    $sql = "INSERT INTO uczestnicy(imie,nazwisko,grupaID) VALUES('{$dane[0]}','{$dane[1]}',{$dane[4]})";
    $sql2 = "SELECT LAST_INSERT_ID()";
    $result = $conn->query($sql);
    $result2 = $conn->query($sql2);
    $id = $result2->fetch_row()[0];
    $sql3 = "INSERT INTO adres VALUES({$id},'{$dane[2]}','{$dane[3]}')";
    $r = $conn->query($sql3);
    $conn->close();
    return $id;
}
function insertToWycieczkiUczestnicy(int $id, int $wycieczkaID): void
{
    $conn = getConnection();
    if ($conn == null) return;
    $sql = "INSERT INTO wycieczka_uzytkownik(wycieczka_id,uczestnik_id) VALUES({$wycieczkaID},{$id})";
    //echo $sql;
    $conn->query($sql);
    $conn->close();
}
function wycieczkiToTable(array $dane): string
{
    $html = "<table class='wycieczki'>";
    $html .= "<tr><th>Miejsce</th><th>Data</th><th>Ilość miejsc</th><th>Cena</th><th></th></tr>";
    foreach ($dane as $wycieczka) {
        $html .= "<tr><td>{$wycieczka[1]}</td><td>{$wycieczka[2]}</td><td>{$wycieczka[3]}</td><td>{$wycieczka[4]}</td>"
            . "<td><a href='uczestnicy.php?id={$wycieczka[0]}'>Zobacz uczestników</a></td></tr>";
    }
    return $html . "</table>";
}
function getWycieczkaById(int $wycieczkaId): array
{
    $conn = getConnection();
    if ($conn == null) return [];
    $sql = "SELECT * FROM wycieczki WHERE id={$wycieczkaId}";
    $result = $conn->query($sql);
    $conn->close();
    return $result->fetch_row();
}
function getAllUczWycieczki(int $id=-1):array
{
    $conn = getConnection();
    if ($conn == null) return [];
    $sql = $id!=-1 ? "SELECT  imie,nazwisko,uczestnicy.id FROM uczestnicy INNER JOIN wycieczka_uzytkownik "
        . " on uczestnicy.id=wycieczka_uzytkownik.uczestnik_id WHERE  "
        . " wycieczka_uzytkownik.wycieczka_id={$id}"
        :"SELECT imie,nazwisko,uczestnicy.id FROM uczestnicy INNER JOIN wycieczka_uzytkownik "
        . " on uczestnicy.id=wycieczka_uzytkownik.uczestnik_id ";
    //echo $sql;
    $result = $conn->query($sql);
    $wynik = [];
    while($row=$result->fetch_row()){
        $wynik[] = $row;
    }
    $conn->close();
    return $wynik;
}
function toList(array $uczestnicy): string
{
    $html = "<ol>";
    foreach($uczestnicy as $u){
        $html .= "<li>{$u[0]} {$u[1]} <a href='editUcz.php?id={$u[2]}'>Edytuj uczestnika</a></li>\n";
    }
    return $html . "</ol>\n";
}
function getUczestnikById(int $id):array{
    $conn = getConnection();
    if ($conn == null) return [];
    $sql = "SELECT * FROM uczestnicy WHERE id={$id}";
    //echo $sql;
    $result = $conn->query($sql);   
    $wynik = $result->fetch_row();
    $conn->close();
    return $wynik;
}
function wycieczkiToListCB(array $dane ,array $wycById=[]):string{
    $html = "<div><form method='post'>\n";
    foreach($dane as $w){
        $checked = in_array($w[0],$wycById)? " checked" :"";
        $html .= "<div><input type='checkbox' value='$w[0]' name='wyc[]' {$checked}>{$w[1]} {$w[2]} cena: {$w[4]} zł</div>\n";
    }
    return $html."<input type='submit' value='Zapisz'></form></div>\n";
}

function getWycieczkiByIdUczestnika(int $iduczestnika):array{
    $conn = getConnection();
    if($conn==null) return [];
    $sql = "SELECT wycieczka_id FROM `wycieczka_uzytkownik` WHERE uczestnik_id={$iduczestnika}";
   // var_dump($sql);
    $result = $conn->query($sql);
    $wycieczki = [];
    while($row = $result->fetch_row()){
        $wycieczki[] = $row[0];
    }
    $conn->close();
    return $wycieczki;
}
function getAllUczestnicy():array{
    $conn = getConnection();
    if($conn==null) return [];
    $sql = "SELECT * FROM uczestnicy";
   // var_dump($sql);
    $result = $conn->query($sql);
    $uczestnicy = [];
    while($row = $result->fetch_row()){
        $uczestnicy[] = $row;
    }
    $conn->close();
    return $uczestnicy;
}
function toListUczestnicy(array $dane):string{
    $html = "<ol>";
    foreach($dane as $u){
        $html .= "<li>{$u[1]} {$u[2]} <a href='editUcz.php?id={$u[0]}'>Edytuj uczestnika</a></li>\n";
    }
    return $html . "</ol>\n";
}