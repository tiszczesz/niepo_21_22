<?php
function ToTable(array $dane):string {
    $html = "<table>";
    $html .= "<tr><th>Lp</th><th>Imię</th><th>Nazwisko</th><th>Pensja</th>"
          ."<th>Stanowisko</th><th>Operacje</th></tr>";
        $lp = 0;
    foreach($dane as $key=>$line){
        $lp++;
        $row = explode(';',$line);
        //var_dump($row);
        $html .= "<tr><td>{$lp}</td><td>{$row[0]}</td><td>{$row[1]}</td>"
           ."<td>{$row[2]}</td><td>{$row[3]}</td>"
           ."<td><a class='btn' href='delete.php?id={$key}'>Usuń</a></td></tr>";
    }
    
    return $html."</table>";
}
function addToFile(array $row,string $filename):void{
    $plik = fopen($filename,'a');
    if($plik){
        fwrite($plik,implode(';',$row).PHP_EOL);
        fclose($plik);
    }
}
function saveFile(string $filename,array $dane):void{
   $plik = fopen($filename,'w');
    if($plik){
        foreach($dane as $row){
            fwrite($plik,$row.PHP_EOL);
          // echo $row.'<br>';
        }
       fclose($plik);
    }
}