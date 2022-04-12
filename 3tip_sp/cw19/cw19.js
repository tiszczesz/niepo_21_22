let date = new Date();
function ShowTimer(elem) {
  let time = new Date();
  elem.innerHTML = time.toLocaleTimeString();
}
const elem = document.querySelector('.timer');
ShowTimer(elem);
//setInterval(function(){ShowTimer(elem);}, 1000);
setInterval(() => ShowTimer(elem), 1000);
const months = [
  'Styczeń',
  'Luty',
  'Marzec',
  'Kwiecień',
  'Maj',
  'Czerwiec',
  'Lipiec',
  'Sierpień',
  'Wrzesień',
  'Październik',
  'Listopad',
  'Grudzień',
];
const days = [
  'Niedziela',
  'Poniedziałek',
  'Wtorek',
  'Środa',
  'Czwartek',
  'Piątek',
  'Sobota',
];
document.querySelector('.year').innerHTML = date.getFullYear();
document.querySelector('.month').innerHTML = months[date.getMonth()];
document.querySelector('.date').innerHTML = date.getDate();
document.querySelector('.day').innerHTML = days[date.getDay()];
if (date.getDay() == 0) document.querySelector('.day').style.color = 'red';
else if (date.getDay() == 6)
  document.querySelector('.day').style.color = 'green';
else document.querySelector('.day').style.color = 'black';
