function stgOrNot() {
    var input = document.getElementById("input").value;
    if (isNaN(input)) {
        var x = "The Given input is <strong>String</strong> ";
        document.getElementById("output").innerHTML = x;
    } else {
        var x = "The Given input is  <strong>Number</strong>";
        document.getElementById("output").innerHTML = x;
    }

}