document.querySelector('#area').onfocus = function () {
  console.log('focus');
  this.style.backgroundColor = 'lightgreen';
};
document.querySelector('#area').onblur = function () {
  console.log('blur');
  this.style.backgroundColor = 'white';
  //this.value = this.value.toUpperCase();
  document.querySelector(".result").innerHTML =
       `<p>Ilość znaków: ${this.value.length}</p>`
       +`<p>Ilość liter: ${CountLetter(this.value)}</p>`
       +`<p>Ilość cyfr: ${CountDigit(this.value)}</p>`;
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

function isAlpha(char){
  return typeof char ==='string' && char.length === 1
        && ((char>='a' && char<='z') || (char>='A' && char<='Z'));
}
function isAlpha2(char){ //sprawdza polskie litery
  return /^[a-ząęśćżźółń]$/i.test(char);
}
function CountLetter(text){
  let count = 0;
  for(let i=0;i<text.length;i++){
    if(isAlpha2(text[i])) count++;
  }
  return count;
}
function CountDigit(text){
  let count = 0;
  for(let i=0;i<text.length;i++){
    if(text[i]>='0' && text[i]<='9') count++
  }
  return count;
}
document.querySelector("#liczba").onkeydown = function(e){
  //e.preventDefault();
  console.log(e);
  if(e.key>='0' && e.key<='9' || e.key=='Backspace' 
        || e.key=='Delete' || e.key=='ArrowRight' || e.key=='ArrowLeft') return true;
  return false;
}

