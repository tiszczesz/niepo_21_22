$(()=>{
   // console.log(this);
   const jsObject = document.querySelector("#first");
   const jQueryObject = $("#first");
   alert(jsObject.innerHTML);
   alert(jQueryObject.html());
   console.log(jsObject,jQueryObject);
   jQueryObject.html("hello from jQuery object");
});
// $(function(){
//     console.log(this);
// });