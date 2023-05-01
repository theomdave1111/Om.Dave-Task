function calculate() {
    var a = document.getElementById("display").value;
    document.getElementById("display").value = eval(a);
}

function myfun(a) {
    document.getElementById("display").value += a;
}

function myfunclear() {
    document.getElementById("display").value = "";
}