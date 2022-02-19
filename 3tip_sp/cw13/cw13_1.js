class Film{
    constructor(title,director,price,date){
        this.title = title;
        this.director = director;
        this.price = price;
        this.date = date;
    }
    show(){
        return `<div>
            <p>Tytuł: <span class='data'>${this.title}</span> </p>
            <p>Reżyser:  <span class="data">${this.director}</span> </p>
            <p>Budżet: <span class="data">${this.price}</span> </p>
            <p>Data wydania: ${this.date}</p>
        </div><hr>`;
    }
}
const f1 = new Film("Gwiezdne wojny 9","Antonio Loren",450000,"2015");
const f2 = new Film("Gwiezdne wojny 10","Antonio Loren Soon",450000,"2017");

document.querySelector("#ex5").innerHTML = f1.show()+f2.show();
console.log(f1,f2);

//Game   title, genre, price, disribution, date   gogogo