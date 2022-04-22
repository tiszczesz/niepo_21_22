<?php
function ToTable(array $dane):string {
    $html = "<table>";
    $html .= "<tr><th>Lp</th><th>Imię</th><th>Nazwisko</th><th>Pensja</th>"
          ."<th>Stanowisko</th></tr>";
        $lp = 0;
    foreach($dane as $line){
        $lp++;
        $row = explode(';',$line);
        //var_dump($row);
        $html .= "<tr><td>{$lp}</td><td>$row[0]</td><td>$row[1]</td>"
           ."<td>$row[2]</td><td>$row[3]</td></tr>";
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