<?php

spl_autoload_register( function($className) {

	// Check if classname has either Controller or Model in the name. 
	if ( strpos($className, 'Controller') !== false ) {
		// Set the dir of a controller class
		$filename = 'class\controllers\\';
	} elseif ( strpos($className, 'Model') !== false ) {
		// Set the dir of a model class
		$filename = 'class\models\\';
	}

	// Add $classname with extension to the filename
	$filename .= $className.'.php';
	
	if ( file_exists($filename) ) {
		include $filename;
	} else {
		throw new \Exception( 'No such class file: '.$filename );
	}
} );