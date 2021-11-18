document.querySelector("#gener").onclick = function (){
    //alert("fff");
    let rows = parseInt(document.querySelector("#rows").value);
    let cols = parseInt(document.querySelector("#cols").value);
    console.log(rows,cols);
    if(isNaN(rows) || isNaN(cols)){
        console.log("Błąd walidacji");
        return;
    }
    document.querySelector("#result").innerHTML = showTable(rows,cols);
};
function showTable(rows,cols){
    return "Brawo tabelka o rozmiarze: "+rows+"x"+cols;
}