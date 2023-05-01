$(document).ready(function() {

    var myform = JSON.parse(sessionStorage.getItem("myform"));
    if (myform != null) {
        showInTable(myform);
        $("#p").hide();

    }
    check();
});
old_id = -1;
var new_input = true;

function savedata() {
    let x = validate();
    if (!x) {
        return;
    }
    $("#warning").html("");
    var sessionData = sessionStorage.getItem("myform");
    var name = $("#name").val();
    var email = $("#email").val();
    var phone_no = $("#phone_no").val();
    var age = $("#age").val();
    var city = $("#city").val();


    var data = {
        Name: name,
        Email: email,
        Phone_no: phone_no,
        Age: age,
        City: city,

    }


    var myform = JSON.stringify(data);
    if (sessionData === null) {
        let myform = [];
        data.id = 0;
        myform.push(data);
        sessionStorage.setItem("myform", JSON.stringify(myform))
        showInTable(JSON.parse(sessionStorage.getItem("myform")))
    } else if (!new_input) {
        var form = JSON.parse(sessionStorage.getItem("myform"));
        data.id = old_id;
        form[old_id] = Object.assign({}, data);
        myform = JSON.stringify(form);
        sessionStorage.setItem("myform", myform);

        showInTable(form);
        newinput = true;
        old_id = -1;
    } else {
        var form = JSON.parse(sessionStorage.getItem("myform"));
        data.id = form.length;

        form.push(data);
        myform = JSON.stringify(form);
        sessionStorage.setItem("myform", myform);

        showInTable(form);
    }
    $("input").val("");
    $("#p").hide();
};


function showInTable(myform) {
    var dataInSession = "";
    for (data of myform) {
        dataInSession +=
            `
        <tr>
            <td id="id"> ${data.id+1}</td>
            <td id= "name"> ${data.Name}</td>
            <td id="email"> ${data.Email}</td>
            <td id="phoneno"> ${data.Phone_no}</td>
            <td id="age"> ${data.Age}</td>
            <td id="city"> ${data.City}</td>
            <td> 
                <a href="index.html" id="delete-btn" type="button" onclick="deletedata(${data.id}) " class="btn btn-sm btn-danger"
                data-bs-toggle="modal" data-bs-target="#myModal"><i class="fa-regular fa-trash"></i></a>
                <a href="index.html" id="btn-edit" type="button" onclick="updatedata(${data.id}) " class="btn btn-sm btn-danger"
                data-bs-toggle="modal" data-bs-target="#myModal"><i class="fa-regular fa-pen-to-square"></i></a>
            </td>
        </tr>
    `;
    }
    $("#formdata").html(dataInSession);

    check();
}



function deletedata(myid) {
    var notification = confirm("Do you want to delete ?");
    if (notification == true) {
        var form = $.parseJSON(sessionStorage.getItem("myform"));
        var deleteIndex = form.findIndex(item => item.id == myid);
        form.splice(deleteIndex, 1)
        for (let d_id = myid; d_id < form.length; d_id++) {
            --form[d_id].id;
        }
        var myform = JSON.stringify(form);
        sessionStorage.setItem("myform", myform);

        showInTable(form);
    } else {
        alert("thank you!");
    }
    $("input").val("");
}

function updatedata(myid) {
    $("#warning").html("");
    var notification = confirm("Do you want to edit ?");
    if (notification == true) {
        var form = JSON.parse(sessionStorage.getItem("myform"));


        $("#name").val(form[myid].Name);
        $("#email").val(form[myid].Email);
        $("#phone_no").val(form[myid].Phone_no);
        $("#age").val(form[myid].Age);
        $("#city").val(form[myid].City);

        new_input = false;
        old_id = myid;
        $("#btn-edit").hide();
    } else {
        alert("thank you, your data is in the table!");
    }

}

function validate() {

    var name_v = $("#name").val();
    var email_v = $("#email").val();
    var phone_v = $("#phone_no").val();
    var age_v = $("#age").val();
    var city_v = $("#city").val();

    let warning_text = "*";
    let wrong_input = true;


    let name = /^\w{1,10}(\s\w{1,10})?$/i;
    let email = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/i;
    let phone_no = /^\d{10}$/i;
    let age = /^\d{1,2}$/i;
    let city = /^\w{3,15}(\s\w{3,10})?$/i;
    if (name_v == "") {
        warning_text += "Please enter Name.<br>";
        wrong_input = false;
    } else if ((!name.test(name_v))) {
        warning_text += " *Enter valid name : No special char, No digit<br> ";
        warning_text += "Name : no special char , no digit , length = (3 , 20)<br>";
        wrong_input = false;
    }
    if (email_v == "") {
        warning_text += "Please enter email.<br>";
        wrong_input = false;
    } else if ((!email.test(email_v))) {
        warning_text += "* Enter a proper email !<br>";
        wrong_input = false;
    }
    if (phone_v == "") {
        warning_text += "Please enter phone no.<br>";
        wrong_input = false;

    } else if ((!phone_no.test(phone_v))) {
        warning_text += " * Enter 10 digit number !<br>";
        wrong_input = false;
    }
    if (age_v == "") {
        warning_text += "Please enter Age.<br>";
        wrong_input = false;
    } else if ((!age.test(age_v))) {
        warning_text += "Invalid age(1 to 99)!<br>";
        wrong_input = false;
    }
    if (city_v == "") {
        warning_text += "Please enter city.<br>";
        wrong_input = false;
    } else if ((!city.test(city_v))) {
        warning_text += "* Enter valid City : no special char , no digit , length = (3 , 20)<br>";
        wrong_input = false;
    }

    if (wrong_input == false) {
        $("#warning").html(warning_text);
    }

    return wrong_input;

};

function check() {
    var myform = $.parseJSON(sessionStorage.getItem("myform"));
    if (myform.length == 0) {
        $("#p").show();
    }

}