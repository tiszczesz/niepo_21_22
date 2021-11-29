const p = document.createElement("p");
const text = document.createTextNode("Ala ma kota");
const ul = document.createElement("ul");
const li1 = document.createElement("li");
const li2 = document.createElement("li");
const li3 = document.createElement("li");
li1.appendChild(document.createTextNode("Element listy 1"));
li2.appendChild(document.createTextNode("Element listy 2"));
li3.appendChild(document.createTextNode("Element listy 3"));
ul.appendChild(li1);
ul.appendChild(li2);
ul.appendChild(li3);
p.appendChild(text);
console.log(p);
p.onclick = function(){
    ul.removeChild(li2);
}
document.querySelector(".parent").appendChild(p);
document.querySelector("h1").onclick = function(){
    document.querySelector(".parent").appendChild(ul);
};
console.log(li1.nextElementSibling);
console.log(document.querySelector(".parent").nextSibling);

