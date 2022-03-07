<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style>
        table{border-collapse: collapse;margin: auto;text-align: center;}
        th,td{border: solid 1px black;padding: 6px;}
        td{text-align: left;}
        th{background-color: lightgrey;}
    </style>
    <title>Document</title>
</head>
<body>
    <?php
    include_once "dane.php";
    echo GenerTab(GetContacts());

?>
</body>
</html>