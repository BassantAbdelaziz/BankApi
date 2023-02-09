// Get the login form
var loginForm = document.getElementById("login-form");

// Attach an event handler to the form's submit event
loginForm.addEventListener("submit", function(event) {
    // Prevent the form from submitting
    event.preventDefault();

    // Perform any validation or authentication checks here

    // If the validation is successful, redirect to the customer data page
    window.location = "/www.google.com";
});