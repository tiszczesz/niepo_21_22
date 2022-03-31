'use strict';
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const readline_1 = __importDefault(require("readline"));
const rl = readline_1.default.createInterface({
    input: process.stdin,
    output: process.stdout
});
const question1 = () => {
    return new Promise((resolve, reject) => {
        rl.question('q1 What do you think of Node.js? ', (answer) => {
            console.log(`Thank you for your valuable feedback: ${answer}`);
            resolve();
        });
    });
};
const question2 = () => {
    return new Promise((resolve, reject) => {
        rl.question('q2 What do you think of Node.js? ', (answer) => {
            console.log(`Thank you for your valuable feedback: ${answer}`);
            resolve();
        });
    });
};
const main = async () => {
    await question1();
    await question2();
    rl.close();
};
main();
