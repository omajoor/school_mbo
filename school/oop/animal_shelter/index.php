<?php

require_once "Administrator.php";

$admin = new Administrator();

$animal1 = new cat(1234567,"","tyfus","gilles-de-la-tourette");
$animal2 = new dog(3948,"","klotehond","");
$animal3 = new dog(393448,"","kloteefrhond","");

if ($admin->Add($animal1)) {
    echo "werkt yo";
}
elseif(!$admin->Add($animal1)){
    echo "werkt niet awe";
}
$admin->Add($animal2);

//echo $animal1 ."<br><br>" . $animal2;

echo "<pre>";
echo print_r($admin);
echo $admin->Find(1234567);
$admin->Add($animal3);
// $admin->remove(1234567);
echo print_r($admin);

echo "</pre>";


