<?php

require_once "Section.php";
require_once "Worker.php";

class Repository{
    private string $db;
    private string $user;
    private string $server;
    private ?string $pswd;
    private mysqli $conn;
    public function __construct(string $server="localhost",
                                string $user="root",?string $pswd = null,string $db)
    {
        $this->db = $db;
        $this->user = $user;
        $this->server = $server;
        $this->pswd = $pswd;
        $this->conn = new mysqli($this->server,$this->user,$this->pswd,$this->db);
    }
    public function &GetAllSections():array {
        $result = $this->conn->query("SELECT id,name,description FROM sections");
        if($result==false) return [];
        $sections = [];
        while($row=$result->fetch_row()){
            $sections[] = new Section($row[0],$row[1],$row[2]);
        }
        return $sections;
    }
    public function &getWorkers(?int $id):array
    {
       $where = $id==null ? "" : " where sections.id={$id}";
            $sql = "SELECT workers.id,firstname,lastname,salary,sections.name "
               ."FROM workers INNER JOIN sections on section=sections.id {$where}";
            $result = $this->conn->query($sql); 
            $dane = [];
            if($result){               
                while($row=$result->fetch_row()){
                    $w = new Worker();
                    $w->Id = $row[0];
                    $w->FirstName = $row[1];
                    $w->LastName = $row[2];
                    $w->Salary = $row[3];
                    $w->Section = $row[4];
                    $dane[] = $w;
                }
            }
            return $dane;        
    }

    public function __destruct()
    {
        $this->conn->close();
    }

}