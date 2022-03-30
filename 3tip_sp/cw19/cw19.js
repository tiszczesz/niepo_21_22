let date = new Date();
function ShowTimer(elem) {
  let time = new Date();
  elem.innerHTML = time.toLocaleTimeString();
}
const elem = document.querySelector(".timer");
ShowTimer(elem);
//setInterval(function(){ShowTimer(elem);}, 1000);
setInterval(() => ShowTimer(elem), 1000);
const months = [
  "Styczeń",
  "Luty",
  "Marzec",
  "Kwiecień",
  "Maj",
  "Czerwiec",
  "Lipiec",
  "Sierpień",
  "Wrzesień",
  "Październik",
  "Listopad",
  "Grudzień",
];
const days = [
  "nonname",
  "Poniedziałek",
  "Wtorek",
  "Środa",
  "Czwartek",
  "Piątek",
  "Sobota",
  "Niedziela",
];
document.querySelector(".year").innerHTML = date.getFullYear();
document.querySelector(".month").innerHTML = months[date.getMonth()];
document.querySelector(".date").innerHTML = date.getDate();
document.querySelector(".day").innerHTML = days[date.getDay()];
