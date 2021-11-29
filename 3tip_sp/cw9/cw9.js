const data = ["ala ma kota","rerrter tert ert ert 999999","jeszcze jedna ciekawa wiadomość","dsf dsfsdfsdf sdf sdfsf s","ostatnia widomości"];

for(const item of data){
    let p = document.createElement("p");//utworzenie paragrafu
    let content = document.createTextNode(item);//utworzenie tekstu
    p.appendChild(content);//dodanie tekstu do paragrafu
    document.querySelector(".container").appendChild(p);//dodanie paragrafu do div.container
}
console.log(document.querySelector(".container").children);
document.querySelector(".container").firstElementChild.style.backgroundColor = "yellow";
setTimeout(function(){
    const last = document.querySelector(".container").lastElementChild;
    document.querySelector(".container").removeChild(last);
},3000);
console.log(document.body.children);
console.log(document.head.children);