document.querySelector("#text").onkeydown = function(e){
    const key = parseInt(document.querySelector("#key").value);
    document.querySelector("#result").innerHTML = Cezar(this.value,key);
};

function isAlpha2(char){ //sprawdza polskie litery
    return /^[a-ząęśćżźółń]$/i.test(char);
}

function Cezar(text,key){
    
    return "zakodowany tekst: " +text+" kluczem: "+key;
}
function CharCode(char,key){
    if(isAlpha2(char)) return String.fromCharCode(key+char.charCodeAt());
    else return char;
}