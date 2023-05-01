function myFun() {
    var a = parseFloat(document.getElementById("a").value);
    var b = parseFloat(document.getElementById("b").value);

    var c = document.getElementById('dropdown').value;
    if (b == 0 && c == "/") {
        alert("not a number");
        document.getElementById("output").style.display = "none";
    }


    switch (c) {
        case "+":
            output = (a + b);
            break;
        case "-":
            output = (a - b);
            break;
        case "/":
            output = (a / b);
            break;
        case "*":
            output = (a * b);
            break;
    }
    document.getElementById("output").innerHTML = output;

}