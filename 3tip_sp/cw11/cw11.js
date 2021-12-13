function getAllGifts(){
    return [
        ["Jan","Nowak","Klocki lego",99.99],
        ["Adam","Nowak","Samochodzik",49.00],
        ["Monika","Nowak","Lalka Barbie",199.00],
        ["Tomasz","Bomasz","Rowerek",359.99],
        ["Helena","Małecka","Wiaderko",19.99],
        ["Renata","Gryk","Miś pluszowy",69.00],
        ["Świety", "Mikołaj","Renifer",2020.90]
    ];
}
function thTableRow(){
    const tr = document.createElement("tr");
    tr.innerHTML = "<th>Imię</th><th>Nazwisko</th><th>Prezent</th><th>Cena</th>";    
    return tr;
}
function CreateTab(dane){
    const table = document.createElement("table");
    table.appendChild(thTableRow());
    for(let row of dane){
        let tr = document.createElement("tr");
        tr.innerHTML = `<td>${row[0]}</td><td>${row[1]}</td><td>${row[2]}</td><td style='text-align:right'>${row[3]} PLN</td>`;
        table.appendChild(tr);
    }

    return table;
}
const dane = getAllGifts();
document.querySelector(".root").appendChild(CreateTab(dane));
// Z poziomu js wygenerować tabelkę html z danymi