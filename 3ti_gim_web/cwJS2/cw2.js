$(function(){
    const lis = $('li:even');
   // console.log(lis);

    $("input[type=button]").each(function(){
        $(this).click(function(){
           $("li").each(function(){
                $(this).removeClass();
           });
            //console.log($(this).attr("id"));
            switch($(this).attr("id")){
                case "b1": console.log($('li').first());
                $('li').first().addClass("mark");
                 break;
                case "b2": $('li').last().addClass("mark"); break;
                case "b3":$('li').even().addClass("mark"); break;
                case "b4": $('li').odd().addClass("mark"); break;
                case "b5": $('li').eq(3).addClass("mark"); break;
                case "b6": $('li:lt(3)').addClass("mark"); break;
                case "b7": $('li:gt(3)').addClass("mark"); break;
            }
        });
    });
    
});