const express = require('express');

const app = express();

//console.log(app);

app.get('/',(req,res)=>{
    res.sendFile(__dirname+'/index.html')
});
app.listen(5000);
console.log('Server up!!!');