//gdy w html <script type='text/javascript'>.....</script>

window.onload = function(){
    //dzieki temu wykonanie po zaladowaniu strony
    //typy: number string boolean array object undefined
    let a = 12; // zmienna o zasiegu blokowym typu number
    typeof(a); //sprawdzenie typu
    console.log(a); //wyswietlenie watosci a w konsoli F12
    const d = "STOP" // stała d o wartośći STOP
    var f = 45.8; // zmienna number o zasiegu funkcyjnym  f=34; --> window.f !!!!!!
    //petle takie same jak w innych
    let tekst = "ala ma kota"
    for(let i=0;i<tekst.length;i++){/* .....*/}
    let data = new Date(); //obiekt data czas ma swoje metody np toTime() ...
    let tab = [3,5,6,7]; let ob = {"ffff":445}
    document.querySelector("#id");  //pierwsze wystapienie elementu o id
    let ps = document.querySelectorAll("p"); //tablica wszystkich p  [] ps.length
    document.getElementById();
    document.getElementsByName();
    document.getElementsByClassName();
    //....
    let elem1 = document.querySelector("#btn1").onclick = function(event){//onload, onkeypress,onkeyup,
        event.target.style.color = "red";
       // this.style.display...a.
    }
 };