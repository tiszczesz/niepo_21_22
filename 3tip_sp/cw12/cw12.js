document.querySelector('#search').onclick = function () {
    document.querySelector("#result").innerHTML = "";
  const imiona = Array.from(document.querySelector('.tosearch').children);
  //const imiona2 = document.querySelectorAll('.tosearch>li');

  const minLength = parseInt(document.querySelector('#length').value);
  const result = imiona.filter(function (elem) {
    return elem.innerText.length >= minLength;
  });
  document.querySelector("#result").appendChild(generList(result));
  console.log(result);
};
function generList(data){
    const ol = document.createElement("ol");
    let html = "";
    for (const elem of data) {
        html += `<li>${elem.innerText}</li>`;
    }
    ol.innerHTML = html;
    return ol;
}
