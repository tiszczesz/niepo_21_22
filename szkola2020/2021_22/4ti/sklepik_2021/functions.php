<?php
function &getConnection(): ?mysqli
{
    $conn = new mysqli("localhost", "root", null, "sklep_4ti_2021");
    if ($conn->connect_errno != 0) {
        return null;
    }
    $conn->query("SET NAMES utf8");
    return $conn;
}

function getCustomers(): string
{
    $conn = getConnection();
    if ($conn == null) die("error!!!");
    $sql = "SELECT * FROM klienci";
    //echo $sql;
    $result = $conn->query($sql);
    if ($result == false) die("error zapytania!!!");
    $html = "<ol>";
    while ($row = $result->fetch_row()) {
        $html .=  "<li>Imię: {$row[1]} Nazwisko: {$row[2]} <a href='zamowienia.php?id={$row[0]}'>Szczegóły klienta</a></li>";
    }
    $conn->close();
    return $html . "</ol>";
}
function &getCustomerById(int $id): ?array
{
    $conn = getConnection();
    if ($conn == null) return [];
    $sql = "SELECT * FROM klienci WHERE id={$id}";
    //echo $sql;
    $result = $conn->query($sql);
    if ($result == false) return [];
    $wynik = $result->fetch_row();
    $conn->close();
    return $wynik;
}
function &getOrders(int $id = -1): ?array
{
    $conn = getConnection();
    if ($conn == null) return [];
    $where = $id == -1 ? "" : "WHERE klient_id={$id}";
    $sql = "SELECT * FROM zamowienia {$where}";
    $result = $conn->query($sql);
    if ($result == false) return [];
    $data = [];
    while ($row = $result->fetch_row()) {
        $data[] = $row;
    }
    $conn->close();
    return $data;
}
function showOrders(array $data): string
{
    if ($data == null || count($data) == 0) return "<div>Lista zamówień jest pusta</div>";
    $html = "Lista zamówień:<br><ul class='list-group'>";
    foreach ($data as $item) {
        $html .= "<li class='list-group-item'>{$item[1]} wartość: {$item[2]}PLN</li>";
    }
    return $html . "</ul>";
}
function getTotal(int $id = -1): string
{
    $conn = getConnection();
    $where = $id == -1 ? "" : "WHERE klient_id={$id}";
    if ($conn == null) return "";
    $sql = "SELECT SUM(cena) FROM zamowienia {$where}";
    $result = $conn->query($sql);
    if ($result == false) return "";
    $total = $result->fetch_row()[0];
    $conn->close();
    return "<div>Całkowity koszt: (SUM) {$total}PLN</div>";
}
