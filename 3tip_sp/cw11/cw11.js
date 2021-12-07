function getAllGifts(){
    return [
        ["Jan","Nowak","Klocki lego",99.99],
        ["Adam","Nowak","Samochodzik",49.00],
        ["Monika","Nowak","Lalka Barbie",199.00],
        ["Tomasz","Bomasz","Rowerek",359.99],
        ["Helena","Małecka","Wiaderko",19.99],
        ["Renata","Gryk","Miś pluszowy",69.00]
    ];
}
function thTableRow(){
    const tr = document.createElement("tr");
    const imie = document.createTextNode("Imię");
    const nazwisko = document.createTextNode("Nazwisko");
    const prezent = document.createTextNode("Prezent");
    const cena = document.createTextNode("Cena");
    let th1 = document.createElement("th");
    let th2 = document.createElement("th");
    let th3 = document.createElement("th");
    let th4 = document.createElement("th");
    th1.appendChild(imie);
    th2.appendChild(nazwisko);
    th3.appendChild(prezent);
    th4.appendChild(cena);
    tr.appendChild(th1);
    tr.appendChild(th2);
    tr.appendChild(th3);
    tr.appendChild(th4);
    return tr;
}
function CreateTab(dane){
    const table = document.createElement("table");
    table.appendChild(thTableRow());
    for(let row in dane){
        //dodawanie kolejnych rows
    }

    return table;
}
const dane = getAllGifts();
document.querySelector(".root").appendChild(CreateTab(dane));
// Z poziomu js wygenerować tabelkę html z danymi