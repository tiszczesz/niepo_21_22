$(function(){
    $('#start1').on('click',()=>{
        const div = $('#pierwszy');
        div.animate({'left':'+=300'},'slow');
        div.animate({'top':'+=50'},'slow');
        div.animate({'left':'+=700'},600);
    });
    $('#start2').on('click',()=>{
        const div = $('#drugi');
        div.animate({'left':'+=300'},'slow');
        div.animate({'top':'+=50'},'slow');
        div.animate({'left':'+=700'},800);
    });
    $('#start3').on('click',()=>{
        $('#start1, #start2').click();        
    });
    $('#reset').on('click',()=>{
        $('#log').text('');
        $('#pierwszy, #drugi').css({left:'',top:''});
    });
    $('#stop').click(()=>{
        const kulka = $('.kulka');
        kulka.clearQueue();
        kulka.stop();
    });
});