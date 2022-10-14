<?php
class BankAccount
{
    
    
    private $TotalBalance = 150;
    private $AccountNumber;
    
    public function __construct($accountnr)
    {
        $this->AccountNumber = $accountnr;
    }
    
    public function getBalance()
    {
        return $this->TotalBalance;
    }
    
    public function withdraw($amount)
    {
        if ($this->TotalBalance - $amount > 0) 
        {
            $this->TotalBalance = $this->TotalBalance - $amount;
            return $this->TotalBalance;
        } else
        {
            return "too poor";
        }
    }
    public function deposit($amount)
    {
        $this->TotalBalance = $this->TotalBalance + $amount;
        return $this->TotalBalance;
    }
   
    
    public function setBalance($balance)
    {
        $this->TotalBalance = $balance;
    }
    
    
    
}


?>