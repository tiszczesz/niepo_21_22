// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

setTimeout(function() {
        const span = document.querySelector("#info1");
        span.innerText = "Jestem z JS'a";
        span.style.color = "green";
    },
    2000);