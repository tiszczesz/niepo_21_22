document.querySelector('#area').onfocus = function () {
  console.log('focus');
  this.style.backgroundColor = 'lightgreen';
};
document.querySelector('#area').onblur = function () {
  console.log('blur');
  this.style.backgroundColor = 'white';
  this.value = this.value.toUpperCase();
};
document.querySelector('#area').onkeyup = function (event) {
  console.log('keyup');
  console.log(event);
};
document.querySelector('#area').onkeydown = function (event) {
  console.log('keydown');
  console.log(event);
};
document.querySelector('#area').onkeypress = function (event) {
  console.log('keypress');
  console.log(event);
};
