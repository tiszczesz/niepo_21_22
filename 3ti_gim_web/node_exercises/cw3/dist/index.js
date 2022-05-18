import { colors, workers } from './dane1.js';
console.log("Hello from TypeScript");
workers.push({ id: 4, firstname: "Monika", lastname: "Hajduk", age: 33 });
console.log(colors);
console.log(workers);
const appendToList = (elemRoot, data) => {
    const list = document.createElement('ol');
    data.forEach((e) => {
        const li = document.createElement('li');
        li.innerHTML = e;
        list.appendChild(li);
    });
    elemRoot.appendChild(list);
};
function generTab(elem, dane) {
    const table = document.createElement('table');
    table.classList.add('table');
    const trHead = table.insertRow(0);
    trHead.innerHTML = '<th>Lp</th><th>Imię</th><th>Nazwisko</th><th>Wiek</th>';
    let lp = 0;
    dane.forEach((item) => {
        const row = table.insertRow(-1);
        row.innerHTML = `<td>${++lp}</td><td>${item.firstname}</td>
            <td>${item.lastname}</td><td>${item.age}</td>`;
    });
    elem.appendChild(table);
}
const root = document.querySelector('#root');
if (root !== null) {
    appendToList(root, colors);
}
const root2 = document.querySelector('#root2');
if (root2 != null) {
    generTab(root2, workers);
}
