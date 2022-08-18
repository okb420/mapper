import express from "express";

import bodyParser from "body-parser";
import cors from 'cors';

// import go from './routes/go.js'

const port = 3001;
const app = express();
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended:true}));
app.use(cors());
// all your routes will come here
// app.use("/api/user",user);
// middle ware error here

app.get("/", (req, res) => {
    console.log("API HIT!");
    res.json({status:200, message:"hello bitch"});
})

app.listen(port,()=>{
    console.log(`Server has started at ${port}`);
})