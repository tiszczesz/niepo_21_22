import { Colors, Sizes } from './data.js';
console.log(Colors);
function GenerColors(htmlElem, data) {
    data.forEach((elem) => {
        const option = document.createElement("option");
        option.value = elem;
        option.innerHTML = elem;
        select.appendChild(option);
    });
    select.id = "selectID";
    htmlElem.appendChild(select);
}
function GenerRadioList(htmlElem, data) {
    let html = '';
    data.forEach((elem => {
        html += `<input type=\"radio\" value=\"${elem}\" name='rr'> ${elem}px<br>`;
    }));
    htmlElem.innerHTML = html;
}
const elem = document.querySelector('#app');
const elem2 = document.querySelector('#app2');
const select = document.createElement("select");
if (elem !== null) {
    GenerColors(elem, Colors);
}
if (elem2 !== null) {
    GenerRadioList(elem2, Sizes);
}
document.querySelector('[name="rr"]').checked = true;
select.addEventListener("change", (event) => {
    console.log(event);
    document.body.style.backgroundColor = event.target?.value;
});
document.body.style.backgroundColor = select.value;
document.querySelectorAll('[name="rr"]').forEach((e) => {
    e.addEventListener("click", (event) => {
        console.log(event.target);
        document.querySelector("p").style.
            fontSize = event.target.value + 'px';
    });
});
