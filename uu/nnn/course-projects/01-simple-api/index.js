//console.log('This is working');
const http = require("http");
const fs = require("fs").promises; // z promises
//const fs = require("fs");
const server = http.createServer();

server.listen(/*process.env.SERVER_PORT*/ 3000, () => {
  console.log("Server started", process.env.SERVER_PORT);
});

server.on("request", async (req, res) => {
  switch (req.url) {    // z promisami
    case "/favicon.ico":
      const data = await fs.readFile("./static/favicon.ico");
      res.write(data);
      return res.end();
    default:
      res.write("Hello to my Node.js server");
      return res.end();
  }
  //-----------------------------------------------
  // switch (    req.url // bez promises z collback
  // ) {
  //   case "/favicon.ico":
  //     return fs.readFile("./static/favicon.ico", (err, data) => {
  //       if (err) {
  //         throw new Error("File was not load");
  //       }
  //       res.write(data);
  //       res.end();
  //     });

  //   default:
  //     res.write("Hello to my Node.js server");
  //     return res.end();
  // }
});
