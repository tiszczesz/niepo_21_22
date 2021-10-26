const pars = document.querySelectorAll("p");
console.log(pars);
//kod bieda
// pars[0].onclick = function(){
//     console.log("kliknięto 1 par");
// }
// pars[1].onclick = function(){
//     console.log("kliknięto 2 par");
// }
// pars[2].onclick = function(){
//     console.log("kliknięto 3 par");
// }
// pars[3].onclick = function(){
//     console.log("kliknięto 4 par");
// }
// for(let i=0;i<pars.length;i++){
//     pars[i].onclick = function(event){
//         console.log(event.target.innerText);
//         if(event.target.style.color!="red"){
//             event.target.style.color = "red";
//         }else{
//             event.target.style.color = "black";
//         }        
//     }
// }
for(let i=0;i<pars.length;i++){
    pars[i].onclick = function(event){
       // debugger;
        console.log(event.target);
        // if(event.target.classList.contains("mark")){
        //     event.target.classList.remove("mark");
        // }else{
        //     event.target.classList.add("mark");
        // }
        if(event.target.className==""){
            event.target.className="mark";
        }else{
            event.target.className="";
        }
    }
}