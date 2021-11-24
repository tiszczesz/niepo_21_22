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
    let html = "<table>";
    let number = 1;
    for(let i=0; i<rows;i++){
        html+= "<tr>"
        for(let j=0;j<cols;j++){
            let mark = isPrimal(number)? "class='mark'": ""
            html += `<td ${mark}>${number++}</td>`;
            console.log(number,isPrimal(number));
        }        
        html +="</tr>";
    }
    return html+"</table>";
}
function isPrimal(liczba){
    if(liczba==1) return false;
    for(let i=2 ; i<liczba; i++){
        if(liczba % i == 0) return false;
    }
    return true;
}