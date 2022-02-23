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
   $(listLi).each((e,elem)=>{
    // $(elem).on("click",function(){});
     $(elem).on("click",(event)=>{
       console.log(event.target);
       $(event.target).toggleClass('mark');
     });
   });
   console.log(listLi);
});
// $(function(){
//     console.log(this);
// });