
//Start-Implement event listeners using plain JavaScript 
function Search() {
    var text = document.getElementById("textSearch").value;
    if (text === "Search" || text === "") {
        document.getElementById("textSearch").value = "Please Enter a keyword";
        return false;
    }
    else {
        alert("You are searching for: " + text);
        return true;
    }
}

function showLoginForm() {
    var x = document.getElementById("login-form");
    document.getElementById("sign-in").style.color = "black";
    if (x.style.display === "none") {
        x.style.display = "block";

    }
    else {
        validateAccount();
    }
}

function validateAccount() {
    var textName = document.getElementById("username").value;
    var textPass = document.getElementById("password").value;
    var x = document.getElementById("login-form");

    if (textName === "Enter your Username" || textName === "") {
        alert("Username Incorrect");
    }
    else if (textPass === "Enter your password" || textPass === "") {
        alert("Password Incorrect");
    }
    else {
        x.style.display = "none";
        document.getElementById("sign-in").style.color = "white";
        document.getElementById("sign-in").innerHTML = "Hi " + textName + " !";
    }
}

function subscribeEmail() {
    var text = document.getElementById("email").value;
    if (text === "Your email" || text === "") {
        alert("Pls Enter Your Email");
        return false;
    }
    else {
        document.getElementById("subscribebtn").innerHTML = "Subscribed";
        document.getElementById("subscribebtn").style.color = "#007bff";
        alert("Thank you for subscribing! ");
        return true;
    }
}
//End-Implement event listeners using plain JavaScript 

//Start-Implement event listeners using plain JQuery
function expandGoalButton() {
    $('#goal-button').hover(function () {
        $(this).css("cursor", "pointer");
        $(this).animate({
            width: 300,
            height: 50,
            'font-size': '1.2rem',
            'font-weight': 750,
            'borderWidth': '3px',
        }, 'slow');
    }, function () {
        $(this).animate({
            width: 205,
            height: 38,
            'font-size': '0.875rem',
            'font-weight': 400,
            'borderWidth': '1px',
        }, 'slow');
    });
}

function extendSearchBar() {
    $('#textSearch').hover(function () {
        $(this).css("cursor", "pointer");
        $(this).animate({
            width: 300,
        }, 'slow');
    }, function () {
        $(this).animate({
            width: 205,
        }, 'slow');
    });
}