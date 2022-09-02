import { Colors, Sizes, FirstNames } from './data.js';
console.log(Colors);

function GenerColors(htmlElem:HTMLDivElement,  data:string[]):void{
    
    data.forEach((elem)=>{
        const option = document.createElement("option");
        option.value = elem;        
        option.innerHTML = elem;
        select.appendChild(option);
    })
    select.id = "selectID";
    htmlElem.appendChild(select);
}
function GenerRadioList(htmlElem:HTMLDivElement, data:string[]):void {
    let html = '';
    data.forEach((elem =>{
       html += `<input type=\"radio\" value=\"${elem}\" name='rr'> ${elem}px<br>`;

    }));
    htmlElem.innerHTML = html;
}
const elem: HTMLDivElement|null = document.querySelector('#app');
const elem2: HTMLDivElement|null = document.querySelector('#app2');
const select = document.createElement("select");

if(elem!==null){
    GenerColors(elem,Colors);
}
if(elem2!==null){
    GenerRadioList(elem2,Sizes);
}
(document.querySelector('[name="rr"]') as HTMLInputElement).checked = true;
select.addEventListener("change",(event)=>{
    console.log(event); 
    document.body.style.backgroundColor = (event.target as HTMLSelectElement)?.value;
});
document.body.style.backgroundColor = select.value;
document.querySelectorAll('[name="rr"]').forEach((e) => {
    e.addEventListener("click",(event) => {
        console.log(event.target);
        
        document.querySelector("p")!.style.
         fontSize = (event.target as HTMLInputElement).value+'px';
    });
});

document.querySelector("#gener")?.addEventListener("click", (event) => {
    alert("kliknięto: "+event.target);
})


