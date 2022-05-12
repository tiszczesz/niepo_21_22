import {colors, workers,IWorker } from './dane1.js';
console.log("Hello from TypeScript");
workers.push({id:4,firstname:"Monika",lastname:"Hajduk",age:33})
console.log(colors);
console.log(workers);
const appendToList = (elemRoot: HTMLDivElement,data:string[]) => {
    const list = document.createElement('ol');
    data.forEach((e)=>{
        const li = document.createElement('li');
        li.innerHTML = e;
        list.appendChild(li);
    });
    elemRoot.appendChild(list);
}
const root:HTMLDivElement|null = document.querySelector('#root');
if(root!==null){
    appendToList(root,colors);
}


