let counter=0;
let sceneHeight = document.querySelector("#scene").offsetHeight;
let sceneWidth = document.querySelector("#scene").offsetWidth;
console.log(sceneHeight,sceneWidth);
document.querySelector("#scene").onclick = function(e){
    counter++;
    document.querySelector("#counter").innerText = counter;
}
createGift();

function createGift(){
    let gift = document.createElement("div");
    let left = Math.floor(Math.random()*(sceneWidth-52));
    let top = Math.floor(Math.random()*(sceneHeight-52));
    gift.className = "gift";
    gift.style.left = left+"px";
    gift.style.top = top+"px";  
    gift.style.opacity = 0; 
    gift.onclick = function(e){
        e.target.style.opacity = 1;
    }
    document.querySelector("#scene").appendChild(gift);
}