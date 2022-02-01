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
    email: "ffff@gmail.com",
    info: function(){
        return `<div style="color:blue;border:solid 1px black;">
        Kontakt: ${this.imie} ${this.nazwisko} tel. ${this.telefon} ${this.email}
        </div>`;
    }
}
document.querySelector("#ex2").innerHTML = Contact.info()+Contact2.info();
//stworzyc obiekt Contact z polami imie, nazwisko, telefon, email
//oraz metode info wyswietlajaca na stronie informacje o kontakcie