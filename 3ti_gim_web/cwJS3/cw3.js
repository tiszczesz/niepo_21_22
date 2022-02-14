$(function(){
    const checks = $("[name='elem1[]']");
    console.log(checks);
    checks.each(function(){
        $(this).on("click",function(){    //$(this).click(function(){....})
            console.log($(this).val());
            $(this).next().toggleClass("check-click");
        });
    });
});