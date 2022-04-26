import express from "express";
import path from 'path';
import { fileURLToPath } from "url";

const app = express();
const __filename = fileURLToPath(import.meta.url);
console.log(__filename);
const __dirname = path.dirname(__filename);
console.log(__dirname);

app.get('/',(req,res)=>{
    res.sendFile(__dirname+'/index.html')
});
app.get('/index2.html',(req,res)=>{
    res.sendFile(__dirname+'/index2.html')
});
app.listen(5000);
console.log('Server up!!!');