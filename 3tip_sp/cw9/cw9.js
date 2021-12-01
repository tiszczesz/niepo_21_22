const data = [
  "ala ma kota",
  "rerrter tert ert ert 999999",
  "jeszcze jedna ciekawa wiadomość",
  "dsf dsfsdfsdf sdf sdfsf s",
  "ostatnia widomości",
];
const data2 = [
    "1212 sdsd  ala ma kota",
    "1212rerrter tert ert ert 999999",
    "121 jeszcze jedna ciekawa wiadomość",
    " 12 dsf dsfsdfsdf sdf sdfsf s",
    "1212  ostatnia widomości",
    "1212  ostatnia widomości",
    "fff  ostatnia widomości",
    "fffff d111  ostatnia widomości",
  ];

function GenerPars(elem,data) {
  for (let i=0;i<data.length;i++) {
    let p = document.createElement("p"); //utworzenie paragrafu
    let content = document.createTextNode(data[i]); //utworzenie tekstu
    p.appendChild(content); //dodanie tekstu do paragrafu
    p.id=i;
    elem.appendChild(p); //dodanie paragrafu do div.container
  }
}
GenerPars(document.querySelector(".container"),data);
GenerPars(document.querySelector("#other"),data2);


console.log(document.querySelector(".container").children);
document.querySelector(".container").firstElementChild.style.backgroundColor =
  "yellow";
setTimeout(function () {
  const last = document.querySelector(".container").lastElementChild;
  document.querySelector(".container").removeChild(last);
}, 3000);
console.log(document.body.children);
console.log(document.head.children);

const pars = document.querySelectorAll("p");
for(let p of pars){
    p.onclick = function(e){
        console.log(e.target.parentNode);
        e.target.parentNode.removeChild(e.target);
    }
}