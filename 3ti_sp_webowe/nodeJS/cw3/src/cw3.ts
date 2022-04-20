document.querySelector("#run")?.addEventListener("click",(e)=>{
    const elmA:HTMLInputElement|null = document.querySelector("#a");
    const a = parseFloat(elmA!.value);
    const elmB:HTMLInputElement|null = document.querySelector("#b");
    const result = document.querySelector("#result");
    const b = parseFloat(elmB!.value);
    if(isNaN(a) || isNaN(b)){
        result!.innerHTML = "Błędne dane";
    }else{
        result!.innerHTML = `${a} + ${b} = ${a+b}`;
    }
    
});