function Book(title,author,price){
    this.title = title;
    this.author = author;
    this.price = price;
    this.show = function(){
        return "tytuł: "+this.title+" autor: "+this.author+" cena: "+this.price+" PLN";
    }
}

const b1 = new Book("ala ma kota","Kamil Bamil",34.99);
const b2 = new Book("Toamszów","Adrian Bamil",33.99);
const b3 = new Book("JS wstęp","Franciszka Kiszka",55.99);
console.log(b1,b2,b3);
let ul = document.createElement("ul");

function AddBook(book){
    let li = document.createElement("li");
    let text = document.createTextNode(book.show());
    li.appendChild(text);
    return li;
}
ul.appendChild(AddBook(b1));
ul.appendChild(AddBook(b2));
ul.appendChild(AddBook(b3));

document.querySelector("#root").appendChild(ul);