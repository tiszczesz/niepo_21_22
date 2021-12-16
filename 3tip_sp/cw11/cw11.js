function getAllGifts(){
    return [
        ["Jan","Nowak","Klocki lego",3.99],
        ["Adam","Nowak","Samochodzik",49.00],
        ["Monika","Nowak","Lalka Barbie",199.00],
        ["Tomasz","Bomasz","Rowerek",4.99],
        ["Helena","Małecka","Wiaderko",19.99],
        ["Renata","Gryk","Miś pluszowy",69.00],
        ["Świety", "Mikołaj","Renifer",5.90]
    ];
}
function thTableRow(){
    const tr = document.createElement("tr");
    tr.innerHTML = "<th>Imię</th><th>Nazwisko</th><th>Prezent</th><th>Cena</th>";    
    return tr;
}
function CreateTab(dane,limit=100){
    const table = document.createElement("table");
    table.appendChild(thTableRow());
    let total = 0;
    for(let row of dane){
        total += parseFloat(row[3]);
        const red = parseFloat(row[3])>limit ? " class='red'": "";
        let tr = document.createElement("tr");
        tr.innerHTML = `<td>${row[0]}</td><td>${row[1]}</td><td>${row[2]}</td><td style='text-align:right' ${red}>${row[3].toFixed(2)} PLN</td>`;
        table.appendChild(tr);
    }
    let tr = document.createElement("tr");
    tr.innerHTML = "<td colspan='4' class='total'>Suma całkowita: "+total.toFixed(2)+" PLN</td>";
    table.appendChild(tr);
    return table;
}
const dane = getAllGifts();
document.querySelector(".root").appendChild(CreateTab(dane,50));
let rangeLimit = document.querySelector("#limit");
rangeLimit.max = GetMaxPrice(dane);
//debugger;
function GetMaxPrice(dane){
    let max = dane[0][3];
    for(let row of dane){
        if(row[3]>max) max = row[3];
    }
    return max;
}
// Z poziomu js wygenerować tabelkę html z danymi