const dane = [
    ["Jan","Nowak",25,3400],
    ["Adam","Rygiel",22,4500],
    ["Monika","Wałecki",23,2400],
    ["Roman","Tomera",34,5800],
    ["Edmund","Waligóra",32,2100]
];

function GenerRow(row,isButton=false){
    let tr = document.createElement("tr");
    for(const item of row){
        let td = document.createElement("td");
        td.appendChild(document.createTextNode(item));
        tr.appendChild(td);
    }
    if(isButton){
        let td = document.createElement("td");
        td.innerHTML = "<input type='button' value='Klik' class='remove'>";
        tr.appendChild(td);
    }
    
    return tr;
}
function AddNew(data){
    const imie = document.querySelector("#imie").value;
    const nazwisko = document.querySelector("#nazwisko").value;
    const wiek = parseInt(document.querySelector("#wiek").value);
    const pensja = parseInt(document.querySelector("#pensja").value);
    data.push([imie,nazwisko,wiek,pensja]);
    ClearForm();
}
function ClearForm(){
    document.querySelectorAll(".toclear").forEach(function(v,i){
        v.value = "";
    })
} 
document.querySelector("#addNew").onclick = function(){
   // console.log("erer");
    //debugger;
    AddNew(dane);
    RenderTable(document.querySelector("#root"));
    
};
function GenerTab(dane){    
    let table = document.createElement("table");
    table.id = "dane1";
    table.appendChild(GenerRow(["Imię","Nazwisko","Wiek","Pensja","Inne"]));
    for(let row of dane){
        table.appendChild(GenerRow(row,true));
    }
    return table;
}
function RenderTable(elem){
    elem.innerHTML = "";
    elem.appendChild(GenerTab(dane));
    RemovePrepare();
}
//console.log(GenerTab(dane));
RenderTable(document.querySelector("#root"));

// for(let i=0;i<btns.length;i++){
//     btns[i].onclick = function(e){
//         console.log(e.target);
//     }
// }


function RemovePrepare() {
    let btns = document.querySelectorAll(".remove");
    for (let btn of btns) {
        btn.onclick = function (e) {
            const index = e.target.parentNode.parentNode.rowIndex;
            console.log(index);
            // console.log(e.target.parentNode.parentNode);
             document.querySelector("#dane1").removeChild(e.target.parentNode.parentNode);
            dane.splice(index-1,1);
            console.log(dane);
        };
    }    
}
