$(function(){
    $('#start1').on('click',()=>{
        const div = $('#first');
        div.animate({'left':'+=300'/*,'top':'+=200'*/},1000,()=>{
            console.log("po animacji");
        });
        div.animate({'top':'+=50'},'slow');
        div.animate({'left':'+=700'},600);
    });
    $("#start2").on('click',()=>{
        const div = $('#second');
        div.animate({'left':'+=400'},'slow');
        div.animate({'top':'+=80'},2000);
        div.animate({'left':'+=800'},800);
    });
    $('#start3').on('click',()=>{
        $('#start1, #start2').click();
    });
    $('#stop').click(()=>{
        const kulka = $('.kulka');
        console.log(kulka);
        kulka.clearQueue();
        kulka.stop();
    });
    $('#reset').on('click',()=>{
        $('#first, #second').css({left:'',top:''});
    });
});