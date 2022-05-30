"use strict";
console.log("Hello");
fetch("https://jsonplaceholder.typicode.com/comments")
    .then(resp => resp.json())
    .then(json => {
    const comments = json;
    console.log(comments);
    const root = document.querySelector('#root');
    if (root !== null) {
        generList(root, comments);
    }
});
function generList(elem, data) {
    const h2 = document.createElement('h2');
    h2.innerHTML = `Pobrano listę komentarzy ilość: ${data.length}`;
    elem.appendChild(h2);
    const list = document.createElement('ul');
    data.forEach((e) => {
        const li = document.createElement('li');
        li.innerHTML = `<b>${e.name}</b> zawartość: <u>${e.body}</u>`;
        list.appendChild(li);
    });
    elem.appendChild(list);
}
console.log("Hello from Typescript");
// async function FF(params:string) {
//   return 'from ....';
// }
// const a = FF('fff'); 
// console.log(a);
