(async function () {
  console.log("started execution");
  delay(2000, () => {
    console.log("In the middle of execution");
    delay(2000, () => {
      console.log("Stopped execution");
    });
  });
})();

function delay(ms, collback) {
  setTimeout(() => {
    collback();
  }, ms);
}
