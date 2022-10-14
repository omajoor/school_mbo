<?php
require_once "Bankaccount.php";
class SavingAccount extends BankAccount
{
    private $InterestRate = 1.04;

    public function __construct($accountnr)
    {
        parent::__construct($this->Accountnumber = $accountnr);

    }
    

    public function Addinterest()
    {
        return $this->TotalBalance*$this->InterestRate;
    }
}
