const express = require('express');

const app = express();

//console.log(app);
console.log(__dirname)
app.get('/',(req,res)=>{
    res.sendFile(__dirname+'/index.html');
});
app.listen(5000);

console.log('Serwer wystartował....');