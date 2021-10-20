//alert("ffffff");
const btn = document.querySelector("#run");
console.log(btn);
btn.onclick = klik;

function klik(){
    //alert("boom");
    const a = parseFloat(document.querySelector("#a").value);
    const b = parseInt(document.querySelector("#b").value);
    console.log(`a = ${a} b = ${b}`);
    if(b < 0 &&  a === 0) {
        document.querySelector('#result').innerHTML = "brak wyniku!!!";    
        return; 
    }
    let a1=0;
    let b1=0;
     if(b<0){
        a1 = 1/a;
        b1 = -b;
     }else{
         a1 = a;
         b1 = b;
     }
    if(!isNaN(a) && !isNaN(b)){
        const wynik1 = Math.pow(a,b);
        let wynik2 = 1;
        for(let i=1; i<=b1;i++){
            wynik2 *= a1; //wynik2 = wynik2*a;
            
        }
        console.log(`${a} ^ ${b} = ${wynik1}`);
        console.log(`${a} ^ ${b} = ${wynik2}`);
        let wynik = `<p>Za pomocą Math.pow() ${a}<sup>${b}</sup> = ${wynik1}</p>
        <p>Za pomocą pętli ${a}<sup>${b}</sup> = ${wynik2}</p>`;
        document.querySelector('#result').innerHTML = wynik;
    }else{
        document.querySelector('#result')
             .innerHTML = "<p style=\"color:red;\">Błędne dane!!!</p>";
    }

}