function myFun() {
    let x = prompt("Please enter your name ", "Om Dave");

    if (x != null) {
        if (confirm("Are You sure !")) {
            document.getElementById("demo").innerHTML = "Hello " + x + " <strong>True !</strong>";

        } else {
            document.getElementById("demo").innerHTML = " <strong>False !</strong> ";

        }

    } else {
        document.getElementById("demo").innerHTML = " <strong>False !</strong> ";

    }

}