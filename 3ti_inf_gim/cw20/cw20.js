class User{
    constructor(firstname,lastname,age,dateOfRe = new Date()){
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
        this.dateOfRe = dateOfRe;
    }
    showString(){
        return `${this.firstname} ${this.lastname} wiek: ${this.age} data rejestracji: ${this.dateOfRe.toLocaleDateString()}`;
    }
}
class ToHtml{
    static UsersToTable(data){
        let html = "<table><tr><th>Imię</th><th>Nazwisko</th><th>Wiek</th><th>Data rejestracji</th></tr>";
        for (const user of data) {
            html += `<tr>
                <td>${user.firstname}</td>
                <td>${user.lastname}</td>
                <td>${user.age}</td>
                <td>${user.dateOfRe.toLocaleDateString()}</td>
            </tr>`;
        }
        return html+"</table>";
    }
}
const users = [
    new User("Antoni","Hajduk",23),
    new User("Monika","Grabska",25,new Date('2020-03-12'))
    
];
// document.querySelector(".root").innerHTML = `<div class='userInfo'>${users[0].showString()}</div>
//                         <div class='userInfo'>${users[1].showString()}</div>`;
document.querySelector(".root").innerHTML = ToHtml.UsersToTable(users);