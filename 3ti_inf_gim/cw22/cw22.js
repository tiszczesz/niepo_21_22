$(function () {
  // console.log(document.querySelector('#first'));
  // console.log($('#second'));
  const first = document.querySelector('#first');
  const second = $('#second');
  first.innerHTML = 'Ala ma kota';
  second.html('Ala ma kotka');
  console.log(second.text());
  console.log(second.html());
  $('#pobierz').click(function () {
    console.log($('#date').val());
  });
//   document.querySelector("#pobierz").onclick = function(){
//     alert(document.querySelector('#date').value);
//   };
});
