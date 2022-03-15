function getTodos(){
    return [
        "Iść do sklepu po jedzenie",
        "Nakarmić rybki",
        "Wyjść z psem",
        "Skosić trawę",
        "Naprawić drzwi o d garażu",
        "Odpocząć"
    ];
}

document.body.onmousedown = function(event){
    console.log(event);
}
const todo = getTodos();
document.querySelector("#result").innerHTML = generList(todo);
function generList(list){
    let html = "<ol>";
 //petla po wszystkich elementach listy --> tworzenie li

    return html+"</ol>";
}
// todo 
/*
    - wygenerować listę numerowaną z powyższej funkcji
    - zdefiniować zdarzenie lewgo przycisku myszy --> koloruje element listy na czerwono
    - zdefiniować zdarzenie prawego przycisku myszy --> koloruje element listy na zielono

*/