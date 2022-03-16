$(()=>{
    $('#start1').on('click',()=>{
        const div = $('#first');
        div.animate({'left':'+=300','top':'+=50'},1000,()=>{console.log("koniec")});
        div.animate({'top':'+=100'},'slow');
        div.animate({'left':'+=300'},1000,()=>{console.log("koniec")});
    });
    $('#start2').on('click',()=>{
        const div = $('#second');
        div.animate({'top':'-=100'},1000);
        div.animate({'left':'+=600'},1000);
    });
    $('#start3').on('click',()=>{
        $('#start1, #start2').click();
    });
    $('#stop').on('click',()=>{
        const kulka = $('.kulka');
        kulka.clearQueue();
        kulka.stop();
        console.log(kulka);
    });
    $('#reset').on('click',()=>{
        $('#first, #second').css({'left':'','top':''});
    });
});