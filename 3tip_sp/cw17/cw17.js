document.querySelector("#start").onclick = function(){
    document.querySelector(".scene").innerHTML = generTable(40,70);
    const tds = document.querySelectorAll(".scene td");
    //console.log(tds);
    for(let td of tds){
        //console.log(td);
        td.addEventListener("mousedown",function(e){
            console.log(e);
        });
    }
};


function generTable(rows,cols){
    let html = "<table>";
    for(let i=0;i<rows;i++){
        html += "<tr>";
        for(let j=0;j<cols;j++){
            html += "<td></td>";
        }
        html += "</tr>";
    }
    return html+"</table>";
}