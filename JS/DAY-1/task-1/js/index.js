function newDate() {
    var date = new Date();
    var month = date.getMonth() + 1;
    if (month < 10) {
        month = "0" + month;
    }
    var day = date.getDate();
    if (day < 10) {
        day = "0" + day;
    }
    var year = date.getFullYear();
    var output1 = month + '-' + day + '-' + year;
    var output2 = month + '/' + day + '/' + year;
    var output3 = day + '/' + month + '/' + year;

    document.getElementById("date1").innerHTML = output1;
    document.getElementById("date2").innerHTML = output2;
    document.getElementById("date3").innerHTML = output3;
    document.getElementById("ul").style.display = "block";

}

function hide() {
    document.getElementById("ul").style.display = "none";
}

document.getElementById("ul").style.display = "none";