$(function(){
    const checks = $("[name='elem1[]']");
    console.log(checks);
    checks.each(function(){
        $(this).on("click",function(){    //$(this).click(function(){....})
            console.log($(this).val());
            $(this).next().toggleClass("check-click");
        });
    });
    $("#elem2").on("focus",function(){
        console.log("focus");
        $(this).css({"backgroundColor":"yellow"});
    });
    $("#elem2").on("blur",function(){
        console.log("blur");
        $(this).css({"backgroundColor":"white"});
    });
    $(".line>textarea").on("keyup",(event)=>{console.log("keyup",event.originalEvent);});
    $(".line>textarea").on("keydown",(event)=>{console.log("keydown",event.originalEvent);});
    $(".line>textarea").on("keypress",(event)=>{console.log("keypress",event.originalEvent);});
});