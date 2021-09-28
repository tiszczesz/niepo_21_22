function Show(content,count){
    let html = "<ul>";
    for(let i=0 ; i < count ; i++){
        html += `<li>${content}</li>`
    }
    html += "</ul>";
    return html;
}
const wynik = document.querySelector("#result");
console.log(wynik);