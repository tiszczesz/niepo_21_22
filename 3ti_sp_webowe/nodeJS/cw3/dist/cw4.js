"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const readline_1 = __importDefault(require("readline"));
const r1 = readline_1.default.createInterface({
    input: process.stdin,
    output: process.stdout
});
const q1 = () => {
    return new Promise((resolve, reject) => {
        r1.question("Podaj a: ", (a) => {
            console.log('Podałeś: a= ' + a);
            resolve(a);
        });
    });
};
const q2 = () => {
    return new Promise((resolve, reject) => {
        r1.question("Podaj b: ", (b) => {
            console.log('Podałeś: b= ' + b);
            resolve(b);
        });
    });
};
const main = async () => {
    const aa = parseFloat(await q1());
    const bb = parseFloat(await q2());
    if (isNaN(aa) || isNaN(bb))
        console.log("Błędne dane!!!!");
    else
        console.log(`${aa} + ${bb} = ${aa + bb}`);
    r1.close();
};
main();
