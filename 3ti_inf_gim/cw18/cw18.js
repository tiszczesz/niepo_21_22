console.log("hello");
let book1 = {
    //fields
    tittle:"ABC JS",
    author:"Antoni Małecki",
    price:23.99,
    //methods
    show: function(){
        return "<div>tytuł: "+this.tittle+" autor: "+this.author+" cena: "+this.price+" PLN</div>";
    }
}
let book2 = {
    //fields
    tittle:"ABC C++",
    author:"Dawid Morgan",
    price:56.99,
    //methods
    show: function(){
        return "<div>tytuł: "+this.tittle+" autor: "+this.author+" cena: "+this.price+" PLN</div>";
    }
}
let u1 = {
    //todo imie nazwisko klasa srednia ocen data urodzenia
}
document.querySelector("#root").innerHTML = book1.show()+book2.show();