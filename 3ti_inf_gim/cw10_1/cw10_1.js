document.querySelector("#gener").onclick = function(){
    //alert("fgfgfg");
    const cols = parseInt(document.querySelector("#cols").value);
    const rows = parseInt(document.querySelector("#rows").value);
    if(isNaN(cols) || isNaN(rows) ){
        document.querySelector("#result").innerHTML =
             "<div style='color:red'>Błędne dane!!!</div>";
        return;
    }
    if(rows<1 || rows>100){
        document.querySelector("#result").innerHTML =
             "<div style='color:red'>Błędna liczba wierszy</div>";
        return;
    }
    if(cols<1 || cols>100){
        document.querySelector("#result").innerHTML =
             "<div style='color:red'>Błędna liczba kolumn</div>";
        return;
    }
    document.querySelector("#result").innerHTML = GenerTab(cols,rows);
};

function GenerTab(cols,rows){
    let html = "<table>";
    for(let i=1; i<=rows;i++){
        html+="<tr>";
        for(let j=1; j<=cols;j++){
            html+=`<td>${(i*j)}</td>`;
        }
        html+="</tr>";
    }
    return html+"</table>";
}

document.querySelector("#colors").onchange = function(e){
    console.log("ddd");
    console.log(e.target.value);
}