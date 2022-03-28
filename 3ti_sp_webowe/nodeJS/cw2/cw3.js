"use strict";
function canDrive(user = { name: "ererer", age: 454 }) {
    console.log("użytkownik: ", user.name);
    if (user.age >= 18) {
        console.log("może prowadzić samochód..");
    }
    else {
        console.log("nie może prowadzić samochodu..");
    }
}
const roman = { name: "Roman", age: 23 };
const tom = { name: "Tomasz", age: 12 };
const hania = { name: "Hania", pensja: 2323, age: 23 };
canDrive(roman);
canDrive(tom);
canDrive(hania);
canDrive();
