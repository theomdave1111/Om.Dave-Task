function myFun() {
    var userText = document.getElementById("user-text-value").value;
    document.getElementById("user-text").innerHTML = userText;
}

function change() {
    var userText = document.getElementById("user-text-value").value;
    var inputNumber = document.getElementById("input-number").value;

    var output1 = userText.slice(0, inputNumber);
    var output2 = userText.slice(++inputNumber, userText.length)
    var output = output1 + output2;

    document.getElementById("text").innerHTML = output;
}