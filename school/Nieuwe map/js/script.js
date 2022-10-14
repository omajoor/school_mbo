
( function( $ ) {
	
	
	$('form#subscribe').submit(function(e) {
		e.preventDefault();
		
		// Code
		var email = $('input#subemail').val();
		var message = alert("Wij nemen zo spoedig mogelijk contact met u op, op het volgende e-mailadres: " + email);
		
		location.reload();
	})

	

} )( jQuery );