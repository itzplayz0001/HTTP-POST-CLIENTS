var bodyParser = require('body-parser')
const express = require("express");
const app = express();

app.use(express.static("public"));
app.use(bodyParser.text())

app.get("/", (request, response) => {
  response.sendFile(__dirname + "/public/index.html");
});

app.post("/test", (request, response) => {
    console.log("Message received - " + request.body);
})

const listener = app.listen(3000, () => {
    console.log("Running on localhost:3000");
});
