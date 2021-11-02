(async function () {
    console.log("started execution");
    await delay(2000);
    console.log("In the middle of execution");
    await delay(2000);
    console.log("Stopped execution");  
  })();
  function delay(ms) {
    return new Promise((resolve, reject) => {
      setTimeout(() => {
        resolve();
      }, ms);
    });
  }
  