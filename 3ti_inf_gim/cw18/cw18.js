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
    imie:"Jan",
    nazwisko:"Nowak",
    klasa:{
        nazwa:"3TIP",
        typ:"LO",
        showClass: function(){
            return `<div style='color:green;margin-left:50px;'>${this.nazwa} typ szkoły: ${this.typ}</div>`;
        }
    },
    dataUrodzenia:"12-03-2005",
    show:function(){
        return `<div style='border:solid 1px black;padding:5px;'>${this.imie} ${this.nazwisko}
                   data urodzenia: ${this.dataUrodzenia}<br> klasa: ${this.klasa.showClass()}</div>`;
    }
}
document.querySelector("#root1").innerHTML = book1.show()+book2.show();
document.querySelector("#root2").innerHTML = u1.show();