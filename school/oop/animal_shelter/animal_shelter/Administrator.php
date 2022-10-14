<?php
require_once "Cat.php";
require_once "Dog.php";


class Administrator
{
    private $Animal;
    public function __construct()
    {

    }

    public function Add(Animal $animal)  
    {
       $this->Animal [] = $animal;
    
       if($this->Find($animal->getChipNumber()) == $animal)
        {
            return true;
        }else
        {
            return false;
        }

    }

    public function Remove($chipRegistration)
    {
        foreach($this->Animal as $index => $value)
        {
            if($chipRegistration == $value->getChipNumber())
            {
                unset($this->Animal[$index]);
            }
        }
        if(!$this->Find($chipRegistration))
        {
            return TRUE;
        }else
        {
            return FALSE;
        }

    }

    public function Find($chipRegistration)
    {
        foreach($this->Animal as $index => $value)
        {
            if($chipRegistration == $value->getChipNumber())
            {
               return $value;
            }
        }
        return FALSE;
    }
}
