window.onload = function(){
    let form = document.forms[0];
    console.log(form);
    form.onsubmit = function(){
        //alert("ggggg");
        const titleOK = document.querySelector("#title").value.trim().length>0;
        const gatunekId=parseInt(document.querySelector("#genre").value);
        const gatunekOK = !isNaN(gatunekId) && gatunekId>0 && gatunekId<6;
        const year = parseInt(document.querySelector("#year").value);
        const yearOK = !isNaN(year) && year>1850 && year <= (new Date().getFullYear());
        const ocena = parseInt(document.querySelector("#rating").value);
        const ocenaOK = !isNaN(ocena) && ocena>=1 && ocena <=6;
        return titleOK && gatunekOK && yearOK && ocenaOK;
    }
};