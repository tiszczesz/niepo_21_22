$(function(){
    $('#start1').on('click',()=>{
        const div = $('#first');
        div.animate({'left':'+=300'/*,'top':'+=200'*/},1000,()=>{
            console.log("po animacji");
        });
        div.animate({'top':'+=50'},'slow');
        div.animate({'left':'+=700'},600);
    });
});