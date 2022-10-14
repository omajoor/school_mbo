<?php
    require_once "Citizen.php";
    class City
    {
        private $Name;
        private $Citizens = [];

        public function __construct($name)
        {
            $this->Name = $name;
        }

        public function AddCitizen($citizen)
        {
            $this->Citizens [] = $citizen;
        }

        public function RemoveCitizen($identityNumber)
        {
            foreach($this->Citizens as $index => $value)
            {
                if($identityNumber == $value->getIdentityNumber())
                {
                    array_splice($this->Citizens,$index,1);
                }
            }
        }


    }

?>