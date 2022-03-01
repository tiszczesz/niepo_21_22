document.querySelector("#text").onkeydown = function(e){
    document.querySelector("#result").innerHTML = this.value;
};