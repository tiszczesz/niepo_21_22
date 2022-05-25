console.log("Hello");
fetch('https://jsonplaceholder.typicode.com/comments')
  .then(response => response.json())
  .then(json => console.log(json))
