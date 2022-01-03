document.querySelector('#search').onclick = function () {
  const imiona = Array.from(document.querySelector('.tosearch').children);
  const imiona2 = document.querySelectorAll('.tosearch>li');
 

  const result = imiona.filter(function(elem){
      return elem.innerText.length>3;
  });

  console.log(result);
};
