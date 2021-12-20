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

const users = [
    new User("Antoni","Hajduk",23),
    new User("Monika","Grabska",25,new Date('2020-03-12'))
    
];
document.querySelector(".root").innerHTML = `<div class='userInfo'>${users[0].showString()}</div>
                        <div class='userInfo'>${users[1].showString()}</div>`;