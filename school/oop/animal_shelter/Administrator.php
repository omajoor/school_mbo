<?php
require_once "Cat.php";
require_once "Dog.php";


class Administrator
{
    private $Animal;


    public function Add(Animal $animal) :bool  
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
                return True;
            }
        }
        return FALSE;
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
        foreach($this->Animal as $value)
        {
            if($chipRegistration == $value->getChipNumber())
            {
               return $value;
            }
        }
        return NULL;
    }
}
