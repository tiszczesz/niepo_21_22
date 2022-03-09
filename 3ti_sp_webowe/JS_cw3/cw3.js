$(function(){
    let start;
    $('#text').on('focus',(event)=>{
        console.log(event);
        console.log(event.originalEvent);
        $(event.target).css({"background-color":"yellow"});
    });
    $('#text').on('blur',(event)=>{
        console.log("blur");
        $(event.target).css({"background-color":"white"});
    });
    ShowTime($('#timer'));
    setInterval(()=>{
        ShowTime($("#timer"));
    },1000);
    $("#text").on("mouseover",(event)=>{
        console.log(event);
        let tt = 0;
        start = setInterval(()=>{
            $("#timer2").html(++tt);
        },10);
    });
    $("#text").on("mouseout",(event)=>{
        console.log(event);
        clearInterval(start);
    });
    $('#text').on("keydown",(event)=>{
        const path = /^[0-9]$/;
        if(path.test(event.key)){
            return false;
        }
        return true;
    });
});
function ShowTime(elem){
    let time = new Date().toLocaleTimeString();
    elem.html(time);
}