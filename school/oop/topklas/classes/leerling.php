<?php

class Leerling
{
    private $Naam;
    private $Status;

    public function __construct($naam,$status)
    {

        $this->Naam = $naam;
        $this->Status = $status;
    }

    public function getNaam()
    {
        return $this->Naam;
     }

    public function setStatus($status){

        $this->Status = $status;
    }

    public function getStatus()
    {
        return $this->Status;
    }

    



}



?>