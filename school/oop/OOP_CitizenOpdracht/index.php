<?php

require_once "City.php";

$city1 = new City("Utrecht");
$city2 = new City("Oss");

$citizen1 = new Citizen("Woeb");
$citizen1->setResidentCity("Utrecht");
$citizen1->setIdentityNumber(1);

$city1->AddCitizen($citizen1);

echo "<pre>";
print_r($city1);
print_r($city2);


$city1->RemoveCitizen($citizen1->getIdentityNumber());
$city2->AddCitizen($citizen1);

print_r($city1);
print_r($city2);
echo "</pre>";




?>