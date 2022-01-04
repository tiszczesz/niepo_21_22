class Dish {
  constructor(name, price, quantity) {
    this.name = name;
    this.quantity = quantity;
    this.price = price;
  }
}
const data = [
  new Dish('Barszcz czerwony', 5.99, 3),
  new Dish('Karp smażony', 4.99, 3),
];
class ToHtml {
  static ToTable(tabOfDishes) {
    let elem = document.querySelector('.table');
    this.CreateNewTable(elem);
    let table = document.querySelector('#list');
    let lp = 1;
    for (const item of tabOfDishes) {
      let tr = this.createRow(item, lp++);
      table.appendChild(tr);
    }    
  }
  static CreateNewTable(elem) {
    // elem.innerHTML = "";
    let html = `<table id="list">
                <tr>
                    <th>Lp</th>
                    <th>Nazwa potrawy</th>
                    <th>cena</th>
                    <th>Ilość porcji</th>
                </tr>
            </table>`;
    elem.innerHTML = html;
  }
  static createRow(dish, lp) {
    let tr = document.createElement('tr');
    tr.innerHTML = `<td>${lp}</td><td>${dish.name}</td><td>${dish.price} PLN</td>
                <td>${dish.quantity}</td>`;
    return tr;
  }
}
let table = document.querySelector('#list');
ToHtml.ToTable(data);
document.querySelector("#total").innerHTML = "Całkowity koszt imprezy: "+TotalPrice(data);


document.querySelector('#addNew').onclick = function (e) {
  const dish = DishFromForm();
  if (dish == null) return;
  data.push(dish);
  ToHtml.ToTable(data);
  document.querySelector("#name").value = "";
  document.querySelector("#price").value = "";
  document.querySelector("#quantity").value = "";
  document.querySelector("#total").innerHTML = "Całkowity koszt imprezy: "+TotalPrice(data);
};
function DishFromForm() {
  let name = document.querySelector('#name').value;
  let price = parseFloat(document.querySelector('#price').value);
  let quantity = parseInt(document.querySelector('#quantity').value);
  //todo Validation
  if (name.trim() === '' || isNaN(price) || isNaN(quantity)) {
    return null;
  }
  return new Dish(name, price, quantity);
}
function TotalPrice(data){
  let total = 0;
  for (const elem of data) {
    total+=(elem.price*elem.quantity);
  }

  return total;
}