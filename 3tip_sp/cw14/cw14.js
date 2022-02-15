class Contact {
  constructor(firstname, lastname, phone) {
    this.firstname = firstname;
    this.lastname = lastname;
    this.phone = phone;
  }
  generRow(index) {
    return `
            <tr>
            <td>${index}</td>
            <td>${this.firstname}</td>
            <td>${this.lastname}</td>
            <td>${this.phone}</td>
            </tr>
        `;
  }
}

const contacts = [
  new Contact("Adam","Małecki","45678789"),
  new Contact("Monkia","Róża","345333"),
  new Contact("Renata","Sałata","67890987"),
  new Contact("Tomasz","Bomasz","56789098"),
]





class ToHtml{
  static ToTable(dane){
    let html = '<table class="table table-striped"><tr><th>Lp</th><th>Imię</th><th>Nazwisko</th><th>Telefon</th></tr>';
    let lp = 0;
    for (const contact of contacts) {
      lp++;
      html += contact.generRow(lp);
    }
    return html +"</table>";
  }
}

//kod aplikacji
document.querySelector("#tabelka").innerHTML = ToHtml.ToTable(contacts);
document.querySelector("#addContact").onclick = function(){
  let firstname = document.querySelector("#imie").value.trim();
  let lastname = document.querySelector("#nazwisko").value.trim();
  let phone = document.querySelector("#telefon").value.trim();
  //console.log(firstname);
  
  if(firstname.length>0 && lastname.length>0 && phone.length>0){
    
    contacts.push(new Contact(firstname,lastname,phone));
    document.querySelector("#tabelka").innerHTML = ToHtml.ToTable(contacts);
  }
};

document.querySelector("#clearContacts").onclick = function(){
  contacts.length=0;
  document.querySelector("#tabelka").innerHTML = ToHtml.ToTable(contacts);
};