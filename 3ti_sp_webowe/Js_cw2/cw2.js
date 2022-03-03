$(()=>{
    $("h1").on("click",()=>{
        console.log($("dd").last());
        $("dl").last().append("<dd>Najnowsza definicja</dd><dt>A to jej treść</dt>");
    });
    $("h1").on("mousedown",(event)=>{
        console.log(event.originalEvent);
        if(event.originalEvent.buttons===2){
            event.originalEvent.preventDefault();
            console.log("prawy");
        $("dl").last().prepend("<dd>Najnowsza definicja na początek</dd><dt>A to jej treść</dt>");

        }
       
    });
    $("h1").on("contextmenu",(event)=>{
        event.preventDefault();
       
    });
    $("dd").each((i,e) => {
       // console.log(e);
        $(e).on("click",(event)=>{
            //console.log($(this));
           // console.log(event.target);
            console.log($(event.target).next());
            $(event.target).next().slideToggle(100);
        });
    });
});