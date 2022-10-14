<?php
require_once "Animal.php";
class Cat extends Animal
{
    private $BadHabits;

    public function __construct($chipRegistrationNumber,$dateOfBirth,$name,$badHabits)
    {
        $this->BadHabits = $badHabits;
        parent:: __construct($chipRegistrationNumber,$dateOfBirth,$name);
    }
    public function __toString()
    {
        return parent::__toString() .  ' hij heeft last van ' . $this->BadHabits;
    }
}