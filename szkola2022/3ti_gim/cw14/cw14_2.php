<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw14.css">
    <title>Document</title>
</head>
<body>
    <main class="container">
        <div class="menu">
            <div class="menuitem"><a href='cw14.php'>Strona główna</a></div>
            <div class="menuitem"><a href='cw14_1.php'>Klienci</a></div>
            <div class="menuitem"><a href='cw14_2.php'>Dodaj pracownika</a></div>
            <div class="menuitem"><a href='cw14_3.php'>Dodaj klienta</a></div>
        </div>
        <h1>Formularz zgłoszeniowy:</h1>
        <form action="addWorker.php" method="post">
            <fieldset>
                <legend>Informacje o pracowniku: </legend>
            <div class="line">
                <label for="imie">Imię: </label>
                <input type="text" name="imie" id="imie">
                <span class="error"></span>
            </div>
            <div class="line">
                <label for="nazwisko">Nazwisko: </label>
                <input type="text" name="nazwisko" id="nazwisko">
                <span class="error"></span>
            </div>
            <div class="line">
                <label for="pensja">Pensja: </label>
                <input type="text" name="pensja" id="pensja">
                <span class="error"></span>
            </div>
            <div class="line">
                <label for="stanowisko">Stanowisko: </label>
                <input type="text" name="stanowisko" id="stanowisko">
                <span class="error"></span>
            </div>
            <div class="line"><input type="submit" value="Zapisz"></div>
            </fieldset>
        </form>
        <?php
        require_once "functions.php";
        require_once "configure.php";
       
       // var_dump($dane);
    ?>
    </main>
    
</body>
</html>