//$     ---->   jQuery()
$(function(){
    // const div = $('.result');
    // const div2 = document.querySelector('.result');
    // console.log(div);
    // console.log(div2);
    //div2.innerHTML = "ala ma kota";
   // div.text("<span>ala ma kota</span>");      // tak jak .innetText= 'ala ma kota';
  //  div.html("<span>ala ma kota</span>");      // tak jak innerHTML = 'ala ma kota';
    $('.result').html("Hello from jQuery")
        .css({"color":"red","fontWeight":"bold","border":"1px solid green"});

    const imiona = ["ala","bela","olo","bolo"];
    $(".result2").html(generList(imiona));
    $(".result2")[0].onclick = function(){
        alert("ddddd");
    }
    
});
function generList(imiona){
    let html = "<ol>";
    for(imie of imiona){
        html += "<li>"+imie+"</li>";
    }
    html += "</ol>";
    return html;
}