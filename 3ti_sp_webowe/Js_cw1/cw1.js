$(()=>{
   // console.log(this);
   const jsObject = document.querySelector("#first");
   const jQueryObject = $("#first");
   //alert(jsObject.innerHTML);
   //alert(jQueryObject[0].innerHTML);
   console.log(jsObject,jQueryObject);
   jQueryObject.html("hello from jQuery object");

   const listLi = $("#first").next().children();
   // $(listLi).each(function(){
   //    $(this).addClass("mark");
   // console.log(this);
   // });
   listLi.each((e,elem)=>{
    // $(elem).on("click",function(){});
     $(elem).on("click",(event)=>{
       console.log(event.target);
       $(event.target).toggleClass('mark');
     });
   });
   console.log(listLi);
   //const li2 = 
   $("ul").eq(1).children().first().css({"color":"red","background-color":"blue"});
   $("#first").on("click",()=>{$("ul").eq(1).children().even().css({"font-weight":"bold"})});
   console.log($("ul:eq(1)>li:lt(4)"));
   $("ul:eq(1)>li:lt(4)").css({"color":"green"});
   //console.log(li2);
});
// $(function(){
//     console.log(this);
// });