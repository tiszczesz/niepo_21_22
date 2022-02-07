$(function(){
    const lis = $('li:even');
   // console.log(lis);

    $("input[type=button]").each(function(){
        $(this).click(function(){
           $("li a").each(function(){
                $(this).removeClass();
           });
            //console.log($(this).attr("id"));
            switch($(this).attr("id")){
                case "b1": ; break;
                case "b2": alert("d"); break;
                case "b3": alert("t"); break;
                case "b4": alert("c"); break;
                case "b5": alert("p"); break;
                case "b6": alert("sz"); break;
                case "b7": alert("si"); break;
            }
        });
    });
    
});