<?php
require_once "Repository.php";
class ToHtml{
    public static function SectionsToList(array $sections,?int $id=null):string {
        $html = '<div class="list-group">'."\n";
        $active = "active";
        $html .= "<a class='list-group-item list-group-item-action "
             .($id==null?"active":"")."' href='cw4.php'>Wszystkie działy</a>";
        foreach($sections as $section){
            $html .= "<a class='list-group-item list-group-item-action "
            .($id==$section->id?"active":"")."' href='cw4.php?id={$section->id}'>{$section->name}</a>\n";
        }
        return $html ."</div>";
    }
    public static function WorkersToTable(array $dane)
    {
        $html =<<<TEXT
         <table class="table table-striped">
         <tr>
         <th>Lp</th>
         <th>Imię</th>
         <th>Nazwisko</th>
         <th>Pensja</th>
         <th>Dział</th>
         </tr> 
TEXT;
        $lp = 0;
     foreach($dane as $w){
         $lp++;
         $html .= "<tr><td>{$lp}</td><td>{$w->FirstName}</td><td>{$w->LastName}</td>"
                ."<td>{$w->Salary}</td><td>{$w->Section}</td></tr>";
     }
        return $html ."</table>";
    }
}