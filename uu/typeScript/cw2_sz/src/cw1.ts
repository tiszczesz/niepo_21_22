type Person = {
    firstname: string,
    lastname: string,
    age: number
}
document.querySelector("#run")?.addEventListener("click", (event) => {
    console.log(event);

    fetch(url).then(res => res.json()).then((data: Array<Person>) => {
        console.log(data);
        showData(data);
    })
});
const url = "data.json";

const showData = (data: Array<Person>) => {
    let html = '<h1>Resultat</h1>';
    const output = document.querySelector(".container");
    console.log(output);
    
    data.forEach((person: Person) => {
        html += `<div>${person.firstname} ${person.lastname} wiek: ${person.age}</div>`
    });
    output!.innerHTML = html;
}
