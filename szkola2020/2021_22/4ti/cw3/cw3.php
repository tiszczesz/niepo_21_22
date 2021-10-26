<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ćwiczenie 3 - upload files</title>
</head>

<body>
    <h1>Wczytanie pliku na serwer</h1>
    <form action="f_upload.php" method="post" enctype="multipart/form-data">
        <label>Wybierz plik: </label>
        <input type="file" name="fileToUpload" id="fileToUpload">
        <input type="submit" value="Zapisz obrazek" name="submit">
    </form>
</body>

</html>