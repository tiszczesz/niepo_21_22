export const colors = ["red","blue","green","yellow","black"];
export interface IWorker{
    id:number;
    firstname:string;
    lastname:string;
    age:number;
}
export const workers:IWorker[] = [
    {
        id:1,
        firstname: "Jan",
        lastname: "Nowak",
        age: 23
    },
    {
        id:2,
        firstname: "Anna",
        lastname: "Wanna",
        age: 34
    },
    {
        id:3,
        firstname: "Franiciszek",
        lastname: "Fryc",
        age:34
    }
];