<?php
require_once "Animal.php";
require_once "SimpleDate.php";
class Dog extends Animal
{
    private $LastWalkDate;



    public function __construct($chipRegistrationNumber,$dateOfBirth,$name,$lastWalkDate)
    {
        
        parent::__construct($chipRegistrationNumber,$dateOfBirth,$name);
        $this->LastWalkDate = $lastWalkDate = new SimpleDate(29,10,2019);
    }

    public function __toString()
    {
        return parent::__toString() . ' laatste wandeling was ' . $this->GetLastWalkDate();
    }

    public function GetLastWalkDate()
    {
        return $this->LastWalkDate;
    }


}