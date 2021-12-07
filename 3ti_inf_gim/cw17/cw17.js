let count = 0;
let scene = document.querySelector(".scene");
scene.onclick = function(){
    count++;
    document.querySelector("#klik").innerText = count;
};
setGift();



function setGift(){
    let gift = document.createElement("div");
    gift.className = "gift";
    let widthScene = scene.offsetWidth;
    let heightScene = scene.offsetHeight;
    console.log(widthScene,heightScene);
    const left = Math.floor(Math.random()*(widthScene-52));
    const top = Math.floor(Math.random()*(heightScene-52));
    console.log(left,top);
    gift.style.left = left+"px";
    gift.style.top = top+"px";
    scene.appendChild(gift);
}
