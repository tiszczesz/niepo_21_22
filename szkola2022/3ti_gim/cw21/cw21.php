<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">

    <title>Document</title>
</head>
<body>
    <h1>Połączenie z bazą danych <b>gim_3ti_firstdb</b></h1>
    <pre>
    <?php
    $conn = new mysqli('localhost','root',null,'gim_3ti_firstdb');
    //var_dump($conn);
    $sqlQuery = "SELECT * FROM towary WHERE nazwa like '%a'"; //selekcja
    $result = $conn->query($sqlQuery);
    var_dump($result);
    echo "<table class='table'>\n";
    echo "<tr><th>nazwa</th><th>cena</th><th>data</th></tr>\n";
    // while($row = $result->fetch_row()){
    //     echo "<tr><td>{$row[1]}</td><td>{$row[2]}</td><td>{$row[3]}</td></tr>\n";
    // }
    echo "<h3>Za pomocą fetch_assoc()</h3>";
    echo "</table>\n";
    echo "<table class='table'>\n";
    echo "<tr><th>nazwa</th><th>cena</th><th>data</th></tr>\n";
    while($row = $result->fetch_assoc()){
       // var_dump($row);
        echo "<tr><td>{$row['nazwa']}</td><td>{$row['cena']}</td><td>{$row['Data']}</td></tr>\n";
    }
    echo "</table>\n";
    $conn->close();
    ?>
    </pre>
</body>
</html>