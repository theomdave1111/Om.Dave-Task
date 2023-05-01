let string1 = '';
let string2 = '';
let string3 = '';
let string4 = '';


function myFun() {
    let number = document.getElementById("number").value;
    for (let i = 1; i <= number; i++) {
        for (let j = 1; j <= i; j++) {
            string1 += '* &nbsp';
        }
        string1 += "<br>";
    }
    document.getElementById("output1").innerHTML = string1;

    for (let i = number; i >= 0; i--) {
        if (i == 1) {
            string2 += ' ';
        } else {
            for (let j = 1; j <= i; j++) {
                string2 += '* &nbsp';
            }
        }
        string2 += "<br>";
    }
    document.getElementById("output2").innerHTML = string2;

    for (let i = 1; i <= number; i++) {
        for (let j = 1; j <= number - i; j++) {
            string3 += "&nbsp&nbsp";
        }
        for (let k = 1; k <= i; k++) {
            string3 += '* &nbsp';
        }
        string3 += "<br>";
    }
    document.getElementById("output3").innerHTML = string3;

    for (let i = number; i >= 0; i--) {
        for (let j = 1; j <= number - i; j++) {
            string4 += "&nbsp&nbsp";
        }
        for (let k = 1; k <= i; k++) {
            string4 += '* &nbsp';
        }
        string4 += "<br>";
    }
    document.getElementById("output4").innerHTML = string4;

}

function myHide() {
    document.getElementById("container").style.display = "none ";
}