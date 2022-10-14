<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Sport</title>
</head>
<body>
    
<?php

require_once "class_sport.php";


$sport1 = new Sport("ufc","eredivisie","nhl");


 
echo $sport1->getMmaLeague() .  '<br>';
echo $sport1->getVoetbalLeague() . '<br>';
echo $sport1->getIjshockeyLeague() . '<br>';









?>



</body>
</html>