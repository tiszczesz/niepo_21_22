class Dish{
    constructor(name,price,quantity){
        this.name=name;
        this.quantity=quantity;
        this.price=price;
    }
}
const data = [
    new Dish("Barszcz czerwony",5.99,3),
    new Dish("Karp smażony",4.99,3)
];
class ToHtml{
    static ToTable(tabOfDishes,table){
        let lp = 1;
        for (const item of tabOfDishes) {
            let tr = this.createRow(item,lp++)
            table.appendChild(tr);
        }
    }
    static createRow(dish,lp){
        let tr = document.createElement("tr");
        tr.innerHTML = `<td>${lp}</td><td>${dish.name}</td><td>${dish.price} PLN</td>
                <td>${dish.quantity}</td>`;
        return tr;
    }
}
let table = document.querySelector("#list");
ToHtml.ToTable(data,table);
document.querySelector("#addNew").onclick = function(e){
    //todo
}