$(function(){
    const checks = $("[name='elem1[]']");
  //  console.log(checks);
    checks.each(function(){
        $(this).on("click",function(){    //$(this).click(function(){....})
        //    console.log($(this).val());
            $(this).next().toggleClass("check-click");
        });
    });
    $("#elem2").on("focus",function(){
    //    console.log("focus");
        $(this).css({"backgroundColor":"red"});
    });
    $("#elem2").on("blur",function(){
       // console.log("blur");
        $(this).css({"backgroundColor":"white"});
      //  console.log( $(this).next());
        $(this).next().html($(this).val());
    });
    $(".line textarea").on("keyup",(event)=>{
       // console.log("keyup",event.originalEvent);
    });
    $(".line>textarea").on("keydown",(event)=>{
        console.log(event);
       // console.log("keydown",event.originalEvent.key);
        const char = event.originalEvent.key.toLowerCase();
      //  console.log(char);
        const path = /^[a-ząężśćółńź]$/i
        if(path.test(char)|| char===' ' || event.originalEvent.key==="Backspace") return true;
       // if(char>='a' && char<='z') return true;
        return false;
    });
    $(".line>textarea").on("keypress",(event)=>{
       // console.log("keypress",event.originalEvent);
    });
});