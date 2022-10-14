<?php
require_once "Bankaccount.php";
class CheckingAccount extends BankAccount
{
    private $Fee;
    
    public function __construct($accountnr)
    {
        parent::__construct($this->Accountnumber = $accountnr);

    }

    public function DeductFee()
    {

    }
}
