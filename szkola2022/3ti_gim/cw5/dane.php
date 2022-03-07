<?php
function GetContacts():array {
    return [
        0 => ["Adam","Nowak","23-3434343","a.nowak@hh.pl"],
        1 => ["Monika","Bałecka","12-3333","m.baleckak@hh.pl"],
        2 => ["Tomasz","Bomasz","23-333333","t.bomasz@hh.pl"],
        3 => ["Roman","Uryk","23-3332222","r.uryk@hh.pl"]        
    ];
}
function GenerTab(array $dane): string {
    $html = "<table><tr><th>Lp</th><th>Imię</th>"
       ."<th>Nazwisko</th><th>Telefon</th><th>Email</th></tr>\n";
       $lp=0;
    foreach($dane as $row){
        $html .= "\t<tr><td>".(++$lp)."</td><td>{$row[0]}</td><td>{$row[1]}</td>"
        ."<td>{$row[2]}</td><td>{$row[3]}</td></tr>\n";
    }
    return $html."</table>\n";
}
////$dane[0][0]---> "Adam";
///$dane[2][2]---> "23-333333";