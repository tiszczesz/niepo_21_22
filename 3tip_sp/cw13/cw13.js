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

//stworzyc obiekt Contact z polami imie, nazwisko, telefon, email
//oraz metode info wyswietlajaca na stronie informacje o kontakcie