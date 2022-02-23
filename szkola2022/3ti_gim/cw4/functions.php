<?php
function GetInfo(): void
{ //def funkcji
    echo "<h3>hello from function GetInfo</h3>";
}
function GetInfo2(string $info = "bla bla bla"): void
{ //def funkcji
    echo "<h3>{$info}</h3>";
}
function GenerListEcho(int $count, bool $isUL = true): void
{
    $listTag = $isUL ? "ul" : "ol";
    echo "<{$listTag}>";
    for ($i = 1; $i <= $count; $i++) {
        echo  "<li>Element listy nr {$i}</li>";
    }
    echo "</{$listTag}>";
}
function GenerList(int $count, bool $isUL = true): string
{
    $listTag = $isUL ? "ul" : "ol";
    $html =  "<{$listTag}>\n";
    for ($i = 1; $i <= $count; $i++) {
        $html .=  "\t<li>Element listy nr {$i}</li>\n";
    }
    $html .= "</{$listTag}>\n";
    return $html;
}
function GetColors():array {
    return ["white","yellow","green","blue","red","pink" ];
}
function GenerSelect(array $colors):string {
    $html = "<select id='colors'>";
    for($i=0; $i<count($colors);$i++){
        $html .= "<option value='{$colors[$i]}'>{$colors[$i]}</option>";
    }
    return $html."</select>";
}
function GenerRadio(array $colors):string {
    $html = '<div>';
    foreach($colors as $c){
        $html .= "<input type='radio' name='r' value='{$c}'/> {$c}<br />";
    }
    return $html.'</div>';
}