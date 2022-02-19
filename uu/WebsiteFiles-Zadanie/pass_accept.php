<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <meta name="description" content="">
  <meta name="author" content="">
  <title>HackerU</title>
  <!-- Bootstrap core CSS -->
  <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
  <!-- Custom fonts for this template -->
  <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
  <link href='https://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic' rel='stylesheet' type='text/css'>
  <link href='https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>
  <!-- Custom styles for this template -->
  <link href="css/clean-blog.min.css" rel="stylesheet">
</head>

<body style="background-image: url('img/background.jfif'); background-size:100% 100%">
  <!-- Page Header -->
  <div class="container py-5">
      <div class="col-12 col-md-8 col-lg-6 mx-auto">
          <div style="background-color: rgb(255,255,255,0.4)" class="p-3 shadow">
            <?php
                if ($_POST["pws"] === base64_decode("VGgxNV8xNV81VFIwbjY") && $_POST["srt"] === "1352" && !empty($_POST["fName"])) {
                  echo 'var div_1 = document.querySelector("#d1");<br>
                                  var div_2 = document.querySelector("#d2");<br>
                            var header = document.querySelector("#h");<br>
                            
                            var div_style = window.getComputedStyle(div_1);<br>
                            var header_style = window.getComputedStyle(header);<br>
                        
                            function A1() {<br>
                                if (div_1.children[0].nodeName === "DIV") {<br>
                                    console.log("You nailed it !");<br>
                                    if (div_2.children[0].nodeName === "H1") {<br>
                                        div_2.children[0].innerHTML = "This is correct too!";<br>
                                        A3();<br>
                                    }<br>
                                }<br>
                            }<br>
                            <br><br>
                            function A2(params) {<br>
                                if ((params / (10 % 4)) === 132.993) {<br>
                                    var m = document.querySelector("Math");<br>
                                    m.innerHTML = "Set Text In Here :";<br>
                                    var arr = [m];<br>
                                    arr.push("Element");<br>
                                    arr.push("Second Element");<br>
                                    m.addEventListener("click", A2(arr));<br>
                                }<br>
                            }<br>
                            <br><br>
                            function A3() {<br>
                                if (div_style["textAlign"] === "center" && div_style["fontFamily"] === "fantasy") {<br>
                                    console.log("Just one more step");<br>
                                    if (header_style.color === "rgb(255, 99, 71)" && header_style.transform === "matrix(-1, 0, 0, -1, 0, 0)") {<br>
                                        alert("AMAZING YOU DID IT !!!");<br>
                                    }<br>
                                }<br>
                            }<br><br>
                            
                            A1();';
                }
                ?>
          </div>
      </div>      
  </div>

</body>

</html>