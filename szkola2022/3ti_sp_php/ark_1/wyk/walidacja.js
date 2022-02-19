//document.addEventListener("DOMContentLoaded",function(){
    const form = document.forms[0];
    // form.onsubmit = function(e){
    //     return false;
    // }
    form.addEventListener("submit",function(e){
        let imieOK = ValidateText(document.querySelector("#imie"));
        let nazwiskoOK = ValidateText(document.querySelector("#nazwisko"));
        let adresOK = ValidateText(document.querySelector("#adres"));
        if(imieOK && nazwiskoOK && adresOK){
            return true;
        }
        e.preventDefault();
        return false;
    });
  
    function ValidateText(elem){
        let span = elem.nextElementSibling;
        if(elem.value.length>0){
            span.innerHTML = "";
            return true;
        }else{
            span.innerHTML = "Podaj porawne dane";
            return false;
        }
    }
//});
