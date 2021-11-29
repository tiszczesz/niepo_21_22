const dane = [
    ["Jan","Nowak",25,3400],
    ["Adam","Rygiel",22,4500],
    ["Monika","Wałecki",23,2400],
    ["Roman","Tomera",34,5800],
    ["Edmund","Waligóra",32,2100]
]

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
function GenerTab(dane){    
    let table = document.createElement("table");
    table.appendChild(GenerRow(["Imię","Nazwisko","Wiek","Pensja","Inne"]));
    for(let row of dane){
        table.appendChild(GenerRow(row,true));
    }
    return table;
}
console.log(GenerTab(dane));
document.querySelector("#root").appendChild(GenerTab(dane));