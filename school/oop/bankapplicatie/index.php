<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    <?php
    
        require_once "User.php";

         
        
        $user1 = new User("Olaf",1234,134,233);
        
       

        
        if (isset($_POST['deposit']))
        {
            $user1-> Deposit($_POST['deposit']);
        }
        if(isset($_POST['withdraw']))
        {
            $user1->withdraw($_POST['withdraw']);
        }
        if(isset($_POST['transferS']))
        {
            $user1->TransferToSavingsAccount($_POST['transferS']);
        }
        if(isset($_POST['transferC']))
        {
            $user1->TransferToCheckingAccount($_POST['transferC']);
        }
        
        echo "<pre>";
         print_r($user1);
         echo "</pre>";
        
        print_form();
        echo("Accountnaam: " . $user1->getname() . "<br>");
        echo($user1->CheckAllBalances() ."<br>");
        
        
    
         
        
         function print_form() {
           echo '
             <form name="form1" method="post" action="">
             <p><label><input type="number" name="deposit"  id="textfield" placeholder="deposit"></label></p>
             <p><label><input type="number" name="withdraw"  id="textfield" placeholder="withdraw"></label></p>
             <p><label><input type="number" name="transferC"  id="textfield" placeholder="transferC"></label></p>
             <p><label><input type="number" name="transferS"  id="textfield" placeholder="transferS"></label></p>
             <p><label><input type="submit" name="button" id="button" value="Submit"></label></p>
             </form>
           ';
         }

        ?>

      


       
        
</body>
</html>