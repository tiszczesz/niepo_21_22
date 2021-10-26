<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styl6.css">
    <title>Odloty samolotów</title>
</head>

<body>
    <section id="baner">
        <section id="b1">  <h2>Odloty z lotniska</h2>
        </section>
        <section id="b2">
            <img src="zad6.png" alt="logotyp">
        </section>
    </section>
    <section id="glowny">
    <h4>tabela odlotów</h4>
        <table>
            <tr>
                <th>lp.</th>     <th>numer rejsu</th>
                <th>czas</th>   <th>kierunek</th>
                <th>status</th>
            </tr>        
        </table>   <?php
            echo "z bazy danych"
            ?>
    </section>
<section id="stopka">
    <section id="s1">
        <a href="kwerendy.txt" target="_blank">Pobierz obraz</a>
    </section>
    <section id="s2">
        <?php echo "<p>tu ciasteczka</p>" ?>
    </section>
    <section id="s3">
        Autor XXXXXXXXXXX
    </section>
</section>
</body>

</html>