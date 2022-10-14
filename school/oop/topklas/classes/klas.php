<?php
require_once "leerling.php";

class Klas
{
    private $Klas;
    private $Leerlingen;
    
    
    
    
    
    
    public function __construct($klas)
    {
        $this->Klas = $klas;
        $this->Leerlingen = array(new Leerling("Olaf","Aanwezig"),new Leerling("Nuha","Te Laat"));
        
        
    }
    
    public function getKlas()
    {

        return $this->Klas;
    }

    public function getLeerlingen()
    {

        return $this->Leerlingen;
    }

    public function addLeerling($name,$status)
    {
           array_push($this->Leerlingen,new Leerling($name,$status));
        
       return $this->Leerlingen;
    }
   
    
}
    
     





?>