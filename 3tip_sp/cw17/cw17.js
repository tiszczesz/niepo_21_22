document.querySelector("#start").onclick = function () {
  document.querySelector(".scene").innerHTML = generTable(30, 50);
  document.querySelector("table").addEventListener("contextmenu", function (e) {
    console.log("menu");
    e.preventDefault();
    return false;
  });
  const tds = document.querySelectorAll(".scene td");
  //console.log(tds);
  for (let td of tds) {
    //console.log(td);
    td.addEventListener("mousedown", function (e) {
      //console.log(e);
      switch (e.buttons) {
        case 1:           
          this.innerHTML = "<img src='krzyzyk.png' alt='X'>";
          break;
        case 2:           
          this.innerHTML = "<img src='kolko.png' alt='X'>";;
          break;
        default:  
        console.log("_");      
          this.innerHTML = "";
      }
    });
  }
};

function generTable(rows, cols) {
  let html = "<table>";
  for (let i = 0; i < rows; i++) {
    html += "<tr>";
    for (let j = 0; j < cols; j++) {
      html += "<td></td>";
    }
    html += "</tr>";
  }
  return html + "</table>";
}
