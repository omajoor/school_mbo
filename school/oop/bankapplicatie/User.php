<?php
require_once "Checkingaccount.php";
require_once "Savingaccount.php";
class User
{
    private $Name;
    private $PinCode;
    private $Saving;
    private $Checking;
    
    public function __construct($name,$pincode,$savingNr,$checkingNr)
    {
        $this->Name            = $name;
        $this->PinCode         = $pincode;
        $this->Checking = new CheckingAccount($checkingNr);
        $this->Saving  = new SavingAccount($savingNr);
        
    }
    
    public function getname()
    {
        return $this->Name;
    }
    
    
    
    public function deposit($amount)
    {
        
        return $this->Checking->deposit($amount);
        
    }
    public function withdraw($amount)
    {
        return $this->Checking->withdraw($amount);
    }
    public function TransferToCheckingAccount($amount)
    {
        if ($this->Saving->withdraw($amount) != "too poor") {
            $this->Checking->deposit($amount);
            return "gelukt";
        } else {
            return "te weinig cash";
        }
        
    }
    
    public function TransferToSavingsAccount($amount)
    {
        if ($this->Checking->withdraw($amount) != "too poor") {
            $this->Saving->deposit($amount);
            return "gelukt";
        } else {
            return "te weinig cash";
        }
    }
    
    public function CheckAllBalances()
    {
        $all = "SavingAccount: " . $this->Saving->getBalance() . "<br> Checking: " . $this->Checking->getBalance();
        return $all;
    }

    
    
    
}

?>