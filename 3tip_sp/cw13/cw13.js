document.querySelector("#ex1").innerHTML = ShowBook();

function ShowBook(){
    const book1 = {
        //fields
        title: "ABC JavaScript",
        author: "Adam Nowak",
        price: 45.99,
        //methods
        show: function(){
            return `<p>
            Informacje o książce:<br /> 
            tytuł: ${this.title} <br />
            autor: ${this.author} <br />
            cena: ${this.price} zł <br />
            </p>`;
        }
    }
    return book1.show();
}

const Contact = {
    imie:"Roman",
    nazwisko: "Tomera",
    telefon: "2345677",
    email: "ffff@gmail.com",
    info: function(){
        return `<div style="color:green;border:solid 1px black;">
        Kontakt: ${this.imie} ${this.nazwisko} tel. ${this.telefon} ${this.email}
        </div>`;
    }
}
const Contact2 = {
    imie:"Monika",
    nazwisko: "Rybicka",
    telefon: "2345677",
    rrr: 553535353535,
    email: "ffff@gmail.com",
    info: function(){
        return `<div style="color:blue;border:solid 1px black;">
        Kontakt: ${this.imie} ${this.nazwisko} tel. ${this.telefon} ${this.email}
        </div>`;
    }
}
document.querySelector("#ex2").innerHTML = Contact.info()+Contact2.info();

function Book(title,author,price){
    this.title = title;
    this.author = author;
    this.price = price;
    this.show = function(){
        return `<p>
        Informacje o książce:<br /> 
        tytuł: ${this.title} <br />
        autor: ${this.author} <br />
        cena: ${this.price} zł <br />
        </p>`;
    }
}
const b1 = new Book("Wędkarstwo","Tomasz Rybka",45.99); // const zmienna = new Funkcja()
const b2 = new Book("Kucharska","Renata Rybka",35.99);
console.log(b1,b2,Contact2);
document.querySelector("#ex3").innerHTML = b1.show()+b2.show();
//stworzyc obiekt Contact z polami imie, nazwisko, telefon, email
//oraz metode info wyswietlajaca na stronie informacje o kontakcie