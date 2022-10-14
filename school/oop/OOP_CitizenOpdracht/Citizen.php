<?php

    class Citizen
    {
        private $Name;
        private $ResidentCity;
        private $IdentityNumber;
        private  static $NextIdentityNumber = 0; 

        public function __construct($name)
        {
            $this->Name = $name;
            $this->IdentityNumber = self::$NextIdentityNumber;
            self::$NextIdentityNumber++;

        }

        public function setResidentCity($cityName)
        {
            $this->ResidentCity = $cityName;
        }

        public function getResidentCity()
        {
            return $this->ResidentCity;
        }

        public function setIdentityNumber($identityNumber)
        {
            $this->IdentityNumber = $identityNumber;
        }

        public function getIdentityNumber()
        {
            return $this->IdentityNumber;
        }


    }




?>