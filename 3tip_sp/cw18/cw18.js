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
const todo = getTodos();
document.querySelector("#result").innerHTML = generList(todo);
const elems = document.querySelectorAll("li");
for(let elem of elems){
    elem.onmousedown = function(e){
       // console.log(e);
        switch(e.buttons){ //sprawdzenie ktory przycisk myszy kliknieto 1 -> lewy 2 -> prawy
            case 1:
                console.log("lewy przycisk");
                e.target.style.color = "red";
                break;
            case 2:
                console.log("prawy przycisk");
                e.target.style.color = "green";
                break;
            default:
                e.target.style.color = "black";
                console.log("inny przycisk");
        }
    }
    elem.oncontextmenu = function(e){
        e.preventDefault();  //wylaczenie menu kontekstowego
        return false;
    }
}
function generList(list){
    let html = "<ol>";
    for(let elem of todo){
        html += `<li>${elem}</li>`
    }
    return html+"</ol>";
}
// todo 
/*
    - wygenerować listę numerowaną z powyższej funkcji --> true
    - zdefiniować zdarzenie lewgo przycisku myszy --> koloruje element listy na czerwono
    - zdefiniować zdarzenie prawego przycisku myszy --> koloruje element listy na zielono

*/