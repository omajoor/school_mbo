<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Top Klas</title>
    </head>
    <body>

        <?php

            require_once "./classes/klas.php";

            $name = $_POST['name'];
            $status = $_POST['status'];

            $klas1 = new Klas('AM2C');

            echo $klas1->getKlas(). "<br>";
            
            
            
            if (isset($_POST['name'])) {
             

                var_dump($klas1->addLeerling($name,$status));
                print_form();
              }
              else {
                 var_dump($klas1->getLeerlingen());
                print_form();
              }
              
             
              
              // This function is called when no name was sent to us over HTTP.
              function print_form() {
                echo '
                  <form name="form1" method="post" action="">
                  <p><label><input type="text" name="name" id="textfield" placeholder="voeg leerling toe"></label></p>
                  <p><label><input type="text" name="status" id="textfield" placeholder="status"></label></p>
                  <p><label><input type="submit" name="button" id="button" value="Submit"></label></p>
                  </form>
                ';
              }
        ?>
            
   

    </body>
</html>