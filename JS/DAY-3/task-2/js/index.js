function myFun() {
    var name1 = document.getElementById("name").value;
    var email = document.getElementById("email").value;
    var no = document.getElementById("number").value;
    var address = document.getElementById("address").value;
    var city = document.getElementById("city").value;


    localStorage.setItem("name", name1);
    localStorage.setItem("email", email);
    localStorage.setItem("no", no);
    localStorage.setItem("address", address);
    localStorage.setItem("city", city);

}

function myNewPage() {

}

function createTable() {

    document.getElementById("td1").innerHTML = localStorage.getItem("name");
    document.getElementById("td2").innerHTML = localStorage.getItem("email");

    document.getElementById("td3").innerHTML = localStorage.getItem("no");

    document.getElementById("td4").innerHTML = localStorage.getItem("address");

    document.getElementById("td5").innerHTML = localStorage.getItem("city");





}