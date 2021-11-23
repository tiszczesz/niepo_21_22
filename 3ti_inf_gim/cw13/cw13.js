function generTab(rows, cols) {
  let html = "<table>";
  let liczba = 1;
  for (let i = 0; i < rows; i++) {    
    html += "<tr>";
    for (let j = 0; j < cols; j++) {
        ++liczba;
        let primal = isPrimal(liczba)? "class='primal'" : "";
      html += `<td ${primal}>${liczba}</td>`; // html = html + `<td>${++liczba}</td>`;
    }
    html += "</tr>";
  }
  return html + "</table>";
}
//console.log(generTab(3,1));
document.querySelector("#gener").onclick = function () {
  let rowsElem = document.querySelector("#rows");
  let colsElem = document.querySelector("#cols");
  let rowsOK = Validate(rowsElem);
  let colsOK = Validate(colsElem);
  if (!rowsOK || !colsOK) {
    document.querySelector("#result").innerHTML =
      "<span style='color:red'>Błędne dane!!!</span>";
    return;
  }
  document.querySelector("#result").innerHTML = generTab(rowsElem.value, colsElem.value);
  //const tds2 = document.getElementsByTagName("td");
  const tds = document.querySelectorAll("#result td");
  // for (const td of tds) {
  //   td.onclick = function(e){
  //     alert(e.target.innerHTML);
  //   }
  // }
  tds.forEach(function(e,i){
    e.onclick = function(event){
      console.log(event.target.innerHTML);
    }
  })
  console.log(tds);
  //console.log(rows,cols);
};
function Validate(elem) {
  let val = parseInt(elem.value);
  let next = elem.nextElementSibling;
  //debugger
  if (isNaN(val)) {
    next.innerHTML = "<img src='error.png' alt='error'>";
    return false;
  } else {
    next.innerHTML = "";
    return true;
  }
}

function isPrimal(number){
    if(number==1) return false;
    for(let i=2;i<number;i++){
        if(number%i==0)return false;
    }
    return true;
}
console.log("7",isPrimal(7));
console.log("4",isPrimal(4));
console.log("13",isPrimal(13));
console.log("26",isPrimal(26));
