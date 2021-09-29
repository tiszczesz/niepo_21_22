function Show(content,count){
    let html = "<ul>";
    for(let i=0 ; i < count ; i++){
        html += `<li>${content}</li>`
    }
    html += "</ul>";
    console.log(html);
    return html;
}


const button = document.querySelector("#run");
button.onclick = function(){
    document.querySelector("#description").nextElementSibling.innerHTML = "";
    document.querySelector("#count").nextElementSibling.innerHTML = "";
    const content = document.querySelector("#description").value;
    const count = parseInt(document.querySelector("#count").value);

    let isValidate = true;
    if(content=="" ){
        document.querySelector("#description").nextElementSibling.innerHTML = "Brak tekstu!";
        isValidate = false;
    }
    if(isNaN(count) || count < 0 || count>200){
        document.querySelector("#count").nextElementSibling.innerHTML = "Błędne lub brak danych!!";
        isValidate = false;
    }
    //console.log(content,count);
    
    document.querySelector("#result").innerHTML = isValidate ? Show(content,count):"";
};
