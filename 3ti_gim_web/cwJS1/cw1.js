// $(document).ready(function(){
//     const jq = $("#first");
//     const js = document.querySelector("#first");
//     console.log(jq,js);
//     js.html("gggg");
//    // js.innerHTML = "ala ma kota";
//    jq.html("aaaa");
//    // alert(jq[0]);
//    // alert(js);
// });
function UpdateTime(){
    const time = new Date().toLocaleTimeString();
    $("#first").html(time);
}
const u2 = ()=>{
    const time = new Date().toLocaleTimeString();
    $("#first").html(time);
}
$(function(){
    UpdateTime();
    setInterval(u2 , 1000);
});
//obiekt Colors z polem array kolory i metoda getRandomColor
// wywolana po kliknieciu na stronie