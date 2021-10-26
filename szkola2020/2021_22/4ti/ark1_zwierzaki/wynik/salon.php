<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Salon pielęgnacji</title>
    <link rel="stylesheet" href="salon.css">
    
</head>
<body>

    <section 
    class="banner">
        <h1>SALON PIELĘGNACJI PSÓW I KOTÓW</h1>
    </section>
    <section 
    class="left">
        <h3>SALON ZAPRASZA W DNIACH</h3>
        <ul>
            <li>Poniedziałek, 12:00 - 18:00</li>
            <li>Wtorek, 12:00 - 18:00</li>
        </ul>
    <a href="pies.jpeg"><img src="pies-mini.jpeg" alt="pies-mini"></a>
    <p>Umów się telefonicznie na wizytę lub po prostu przyjdź!</p>
    </section>

    <section 
    class="middle">
    <h3>PRZYPOMNIENIE O NASTĘPNEJ WIZYCIE</h3>
    <div class="wynik">
    <?php
    $conn = new mysqli("localhost", "root", null, "4ti_zwierzaki2021");
    $sql = "SELECT zwierzeta.imie,zwierzeta.rodzaj,zwierzeta.nastepna_wizyta,zwierzeta.telefon FROM zwierzeta WHERE zwierzeta.nastepna_wizyta !=0;";
    $records = $conn->query($sql);
    $data = mysqli_fetch_array($records);
    $rodzaj = $data['rodzaj'];
    $imie = $data['imie'];
    if($rodzaj = 1){echo "Pies $imie";}
    elseif($rodzaj = 2){echo "Kot $imie";}
    ?>
    </div>
    </section>

    <section 
    class="right">
    <h3>USŁUGI</h3>
    </section>
    

</body>
</html>