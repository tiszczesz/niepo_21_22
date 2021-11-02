(async function () {
  console.log("started execution");
  delay(2000)
    .then(() => {
      console.log("In the middle of execution");
      return delay(2000);
    })
    .then(() => {
      console.log("Stopped execution");
    });
})();
function delay(ms) {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      resolve();
    }, ms);
  });
}
