function myFun() {
    var x;
    var a = parseInt(document.getElementById("a").value);
    var b = parseInt(document.getElementById("b").value);
    var c = parseInt(document.getElementById("c").value);
    var d = parseInt(document.getElementById("d").value);
    var e = parseInt(document.getElementById("e").value);

    if (a > b && a > c && a > d && a > e) {
        x = a;
    } else if (b > a && b > c && b > d && b > e) {
        x = b;

    } else if (c > a && c > b && c > d && c > e) {
        x = c;

    } else if (d > a && d > b && d > c && d > e) {
        x = d;

    } else if (e > a && e > b && e > c && e > d) {
        x = e;
    }
    alert("The Largest no. is " + x);
}