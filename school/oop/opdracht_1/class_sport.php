<?php 
    
    class Sport

    {

        private $MmaLeague;
        private $VoetbalLeague;
        private $IjshockeyLeague;


        public function __construct($MmaLeague,$VoetbalLeague,$IjshockeyLeague)
        {
            $this->MmaLeague = $mmaleague;
            $this->VoetbalLeague = $VoetbalLeague;
            $this->IjshockeyLeague = $ijshockeyleague;
        }
        
        
        public function getMmaLeague()
        {
            return $this->MmaLeague;
        }


        public function getVoetbalLeague()
        {
            return $this->VoetbalLeague;
        }

       

        public function getIjshockeyLeague()
        {
            return $this->IjshockeyLeague;
        }

        
        
    }
    


?>