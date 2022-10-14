<?php
require_once "SimpleDate.php";

class Animal
{
    protected $ChipRegistrationNumber;
    protected $Name;
    protected $IsReserved;
    protected $DateOfBirth;

    public function __construct($chipRegistrationNumber,$dateOfBirth,$name)
    {
        $this->ChipRegistrationNumber = $chipRegistrationNumber;
        $this->Name = $name;
        $this->DateOfBirth = $dateOfBirth = new SimpleDate(03,10,2009);
    }

    public function __tostring()
    {
        return "registratieNummer: " .  $this->ChipRegistrationNumber . " Naam: " . $this->Name . " GeboorteDatum: " . $this->DateOfBirth;
    }

    public function getName()
    {
        return $this->Name;
    }

    public function getChipNumber()
    {
        return $this->ChipRegistrationNumber;
    }

}