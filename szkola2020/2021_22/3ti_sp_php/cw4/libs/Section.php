<?php
class Section{
    public int $id;
    public string $name;
    public string $description;
    public function __construct(int $id,string $name,string $desc)
    {
        $this->id = $id;
        $this->name = $name;
        $this->description = $desc;
    }
}